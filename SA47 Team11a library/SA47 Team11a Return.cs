using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;

namespace SA47_Team11a_library
{
    public partial class SA47_Team11a_Return : Form
    {
        string str = "data source=(local); initial catalog = SA47Team11ALibraryDB; integrated security=SSPI;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da, da2,da3;
        SqlCommandBuilder cmb;
        DataSet ds, ds2, ds3;

        private void btnQuery_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select BookName,Author,PublisherName, PublishingYear,TotalStock,NumberBorrowed,Edition from Books,Publishers where dbo.Books.PublisherID = dbo.Publishers.PublisherID and BookID = @BookID;";
            SqlParameter pBookID = new SqlParameter("@BookID", SqlDbType.Int);

            cmd.Parameters.Add(pBookID);
            pBookID.Value = Convert.ToInt32(txtBookID.Text);

            da2 = new SqlDataAdapter(cmd);
            ds2 = new DataSet();
            da2.Fill(ds2, "Books");
            if (ds2.Tables["Books"].Rows.Count > 0)
            {
                PopulateBookTextBoxes();
            }
            else
            {
                txtAuthor.Clear();
                txtBookName.Clear();
                txtPublisherName.Clear();
                txtPublishingDate.Clear();
                txtTotalStock.Clear();

                MessageBox.Show("No match found BookID! in Database.");
            }

           

        }

        public SA47_Team11a_Return()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            if (txtBookID.Text == "" || maskedtxtMemberID.Text == "" )
            {
                MessageBox.Show("Type Carefully!");
            }
            else {

                SqlCommand cmdSelectIssueTran = new SqlCommand();
                cmdSelectIssueTran.Connection = con;

                cmdSelectIssueTran.CommandText = "select * from IssueTran where MemberID=@TMemberID and BookID=@TBookID and BorrowedStatus='OUT' ";
                SqlParameter pTMemberID = new SqlParameter("@TMemberID", SqlDbType.NVarChar, 10);
                cmdSelectIssueTran.Parameters.Add(pTMemberID);
                SqlParameter pTBookID = new SqlParameter("@TBookID", SqlDbType.Int);
                cmdSelectIssueTran.Parameters.Add(pTBookID);

                
                pTMemberID.Value = maskedtxtMemberID.Text;
                pTBookID.Value = Convert.ToInt32(txtBookID.Text);
                

                da3 = new SqlDataAdapter(cmdSelectIssueTran);
                ds3 = new DataSet();
                da3.Fill(ds3, "Trans");
                
                if (ds3.Tables["Trans"].Rows.Count > 0)
                {


                    DateTime BorrowedDate = Convert.ToDateTime(ds3.Tables["Trans"].Rows[0]["DateIssue"].ToString());
                    if (DateTime.Compare(dateTimePickerDateActualReturn.Value, BorrowedDate) > 0)
                    {
                        SqlCommand cmdUpdateIssueTran = new SqlCommand();
                        cmdUpdateIssueTran.Connection = con;

                        cmdUpdateIssueTran.CommandText = "update IssueTran set BorrowedStatus = 'IN', DateActualReturn=@DateActualReturn, Remarks=@Remarks where MemberID=@MemberID and BookID=@BookID";

                        //cmdInsertIssueTran.CommandText = "Insert into IssueTran(MemberID, BookID, BorrowedStatus, DateIssue, DueDate) values(@MemberID, @BookID, 'OUT', @DateIssue, @DueDate)";
                        SqlParameter pMemberID = new SqlParameter("@MemberID", SqlDbType.NVarChar, 10);
                        SqlParameter pBookID = new SqlParameter("@BookID", SqlDbType.Int);
                        SqlParameter pDateActualReturn = new SqlParameter("@DateActualReturn", SqlDbType.DateTime);
                        SqlParameter pRemarks = new SqlParameter("@Remarks", SqlDbType.NVarChar, 250);


                        SqlParameter[] pArr = new SqlParameter[] { pMemberID, pBookID, pDateActualReturn, pRemarks };
                        cmdUpdateIssueTran.Parameters.AddRange(pArr);


                        SqlCommand cmdUpdateBook = new SqlCommand();
                        cmdUpdateBook.Connection = con;
                        cmdUpdateBook.CommandText = "update Books set NumberBorrowed= NumberBorrowed-1 where BookID=@BookID1";
                        SqlParameter pBookID2 = new SqlParameter("@BookID1", SqlDbType.Int);
                        cmdUpdateBook.Parameters.Add(pBookID2);


                        using (TransactionScope ts = new TransactionScope())
                        {

                            con.Open();


                            pMemberID.Value = maskedtxtMemberID.Text;
                            pBookID.Value = Convert.ToInt32(txtBookID.Text);
                            pRemarks.Value = txtRemarks.Text;
                            pDateActualReturn.Value = dateTimePickerDateActualReturn.Value;

                            pBookID2.Value = Convert.ToInt32(txtBookID.Text);

                            cmdUpdateIssueTran.ExecuteNonQuery();
                            cmdUpdateBook.ExecuteNonQuery();

                            ts.Complete();
                        }
                        con.Close();
                        MessageBox.Show("Thank You!");
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Your return date is invalid!");
                    }
                   
                }
                else
                {
                    MessageBox.Show("This member doesn't borrow this book.");
                    ClearText();
                }
            }

         }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            
                

            
        }

        private void txtBookID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if ((e.KeyChar >= 47 && e.KeyChar <= 58) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        public void ClearText()
        {
            maskedtxtMemberID.Clear();
            txtBookID.Clear();
            //dateTimePickerDateActualReturn.CustomFormat = " ";
            //dateTimePickerDateActualReturn.Format = DateTimePickerFormat.Custom;
            txtRemarks.Clear();
            txtMemberName.Clear();
            txtIdentificationNum.Clear();
            txtOccupation.Clear();
            txtPhoneNumber.Clear();
            txtAvailableToBorrow.Clear();
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublisherName.Clear();
            txtPublishingDate.Clear();
            txtTotalStock.Clear();


        }
           
            
       
       
        private void SA47_Team11a_Return_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select (select COUNT(*) from IssueTran where MemberID = @MemberID and BorrowedStatus = 'OUT') as BorrowedBook,MemberName,IdentificationNumber,PhoneNumber,Occupation from Members where MemberID = @MemberID; ";
            SqlParameter pMemberID = new SqlParameter("@MemberID", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add(pMemberID);
            pMemberID.Value = Convert.ToString(maskedtxtMemberID.Text);

            da = new SqlDataAdapter(cmd);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Members");

            //add the mathmatical method
            string member = maskedtxtMemberID.Text;
            if (member.Length == 5)
            {
                string firstle = member.Substring(member.Length - 5, 1);
            string secondle = member.Substring(member.Length - 4, 1);
            string thirdle = member.Substring(member.Length - 3, 1);
            string fourthle = member.Substring(member.Length - 2, 1);
            string fifthle = member.Substring(member.Length - 1, 1);

                //MessageBox.Show(fifthle);
                if (firstle != " " && secondle != " " && thirdle != " " && fourthle != " " && fifthle != " ")
                {
                    int firstnum = Convert.ToInt32(firstle);
            int secondnum = Convert.ToInt32(secondle);
            int thirdnum = Convert.ToInt32(thirdle);
            int fourthnum = Convert.ToInt32(fourthle);
            int fifthnum = Convert.ToInt32(fifthle);
            int checkval = (firstnum + secondnum * 2 + thirdnum * 3 + fourthnum * 4) % 10;
                    if (checkval == fifthnum)
                    {
                        PopulateMemberTextBoxes();
                        if (ds.Tables["Members"].Rows.Count > 0)
                        {
                            PopulateMemberTextBoxes();
                        }
                        else
                        {
                            maskedtxtMemberID.Clear();
                            MessageBox.Show("No match found MemberID in Database!");
                        }
                    }
                    else
                    {
                        txtMemberName.Text = " ";
                        txtOccupation.Text = " ";
                        txtPhoneNumber.Text = " ";
                        txtIdentificationNum.Text = " ";
                        txtAvailableToBorrow.Text = " ";
                        MessageBox.Show("The input MemberID is invalid!");

                    }

            }
            else
            {
                txtMemberName.Text = " ";
                txtOccupation.Text = " ";
                txtPhoneNumber.Text = " ";
                txtIdentificationNum.Text = " ";
                txtAvailableToBorrow.Text = " ";
                MessageBox.Show("The input is invalid!");

            }
        }
            else
            {
                txtMemberName.Text = " ";
                txtOccupation.Text = " ";
                txtPhoneNumber.Text = " ";
                txtIdentificationNum.Text = " ";
                txtAvailableToBorrow.Text = " ";
                MessageBox.Show("Your MemberID should be 5 numbers");
            }


        }


        public void PopulateMemberTextBoxes()
        {
            txtMemberName.Text = ds.Tables["Members"].Rows[0]["MemberName"].ToString();
            txtOccupation.Text = ds.Tables["Members"].Rows[0]["Occupation"].ToString();
            txtPhoneNumber.Text = ds.Tables["Members"].Rows[0]["PhoneNumber"].ToString();
            txtIdentificationNum.Text = ds.Tables["Members"].Rows[0]["IdentificationNumber"].ToString();
            if (txtOccupation.Text == "Student")
            {
                txtAvailableToBorrow.Text = Convert.ToString(10 - Convert.ToInt32(ds.Tables["Members"].Rows[0]["BorrowedBook"].ToString()));
            }
            else
            {
                txtAvailableToBorrow.Text = Convert.ToString(15 - Convert.ToInt32(ds.Tables["Members"].Rows[0]["BorrowedBook"].ToString()));
            }

        }
        public void PopulateBookTextBoxes()
        {
            txtAuthor.Text = ds2.Tables["Books"].Rows[0]["Author"].ToString();
            txtBookName.Text = ds2.Tables["Books"].Rows[0]["BookName"].ToString();
            txtPublisherName.Text = ds2.Tables["Books"].Rows[0]["PublisherName"].ToString();
            txtPublishingDate.Text = ds2.Tables["Books"].Rows[0]["PublishingYear"].ToString();
            txtTotalStock.Text = Convert.ToString(Convert.ToInt32(ds2.Tables["Books"].Rows[0]["TotalStock"].ToString()) - Convert.ToInt32(ds2.Tables["Books"].Rows[0]["NumberBorrowed"].ToString()));
        }
    }
}
