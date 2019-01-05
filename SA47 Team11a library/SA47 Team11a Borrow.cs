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
    public partial class SA47_Team11a_Borrow : Form
    {
     

        string str = "data source=(local); initial catalog = SA47Team11ALibraryDB; integrated security=SSPI;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da, da2;
        SqlCommandBuilder cmb;
        DataSet ds, ds2;
        
        //Confirm for Borrow Book
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Program written by Thett Oo Eain
            //Testing TextBoxes are blank, Due date and borrow date.
            if (txtBookID.Text == "" || maskedTxtMemberID.Text == "" || maskedTxtMemberID.Text.Length < 5 || txtAvailableToBorrow.Text == "" || txtTotalStock.Text == "")
            {
                MessageBox.Show("Type Carefully and Check Aagin!");
            }
            else
            {
                int BDay = dateTimePickerBorrowDate.Value.Day;
                int DDay = dateTimePickerDueDate.Value.Day;

                int BMonth = dateTimePickerBorrowDate.Value.Month;
                int DMonth = dateTimePickerDueDate.Value.Month;

                int BYear = dateTimePickerBorrowDate.Value.Year;
                int DYear = dateTimePickerDueDate.Value.Year;
                if ((BYear < DYear && BMonth < DMonth))
                {


                    if (Convert.ToInt32(txtAvailableToBorrow.Text) > 0 && Convert.ToInt32(txtTotalStock.Text) > 0)
                    {
                        con = new SqlConnection(str);
                        SqlCommand cmdInsertIssueTran = new SqlCommand();
                        cmdInsertIssueTran.Connection = con;

                        cmdInsertIssueTran.CommandText = "Insert into IssueTran(MemberID, BookID, BorrowedStatus, DateIssue, DueDate) values(@MemberID, @BookID, 'OUT', @DateIssue, @DueDate)";
                        SqlParameter pMemberID = new SqlParameter("@MemberID", SqlDbType.NVarChar, 10);
                        SqlParameter pBookID = new SqlParameter("@BookID", SqlDbType.Int);
                        SqlParameter pDateIssue = new SqlParameter("@DateIssue", SqlDbType.DateTime);
                        SqlParameter pDueDate = new SqlParameter("@DueDate", SqlDbType.DateTime);


                        SqlParameter[] pArr = new SqlParameter[] { pMemberID, pBookID, pDateIssue, pDueDate };
                        cmdInsertIssueTran.Parameters.AddRange(pArr);


                        SqlCommand cmdUpdateBook = new SqlCommand();
                        cmdUpdateBook.Connection = con;
                        cmdUpdateBook.CommandText = "update Books set NumberBorrowed= NumberBorrowed+1 where BookID=@BookID1";
                        SqlParameter pBookID2 = new SqlParameter("@BookID1", SqlDbType.Int);
                        cmdUpdateBook.Parameters.Add(pBookID2);


                        using (TransactionScope ts = new TransactionScope())
                        {
                            con.Open();


                            pMemberID.Value = maskedTxtMemberID.Text;
                            pBookID.Value = Convert.ToInt16(txtBookID.Text);
                            pDateIssue.Value = dateTimePickerBorrowDate.Value;
                            pDueDate.Value = dateTimePickerDueDate.Value;

                            pBookID2.Value = Convert.ToInt16(txtBookID.Text);

                            cmdInsertIssueTran.ExecuteNonQuery();
                            cmdUpdateBook.ExecuteNonQuery();


                            ts.Complete();

                        }
                        con.Close();

                        BorrowReceiptForm bowform = new BorrowReceiptForm();
                        bowform.Show();
                        MessageBox.Show("Borrow Successful");

                        //BorrowReceiptForm bowform = new BorrowReceiptForm();
                        //bowform.Show();
                        ClearText();

                    }
                    else
                    {
                        MessageBox.Show("Not Available");
                        ClearText();
                    }


                }

                else if ((BMonth < DMonth && BDay < DDay) || (BMonth < DMonth && BDay > DDay)||(BMonth==DMonth && BDay<DDay))
                {
                    if (Convert.ToInt32(txtAvailableToBorrow.Text) > 0 && Convert.ToInt32(txtTotalStock.Text) > 0)
                    {
                        con = new SqlConnection(str);
                        SqlCommand cmdInsertIssueTran = new SqlCommand();
                        cmdInsertIssueTran.Connection = con;

                        cmdInsertIssueTran.CommandText = "Insert into IssueTran(MemberID, BookID, BorrowedStatus, DateIssue, DueDate) values(@MemberID, @BookID, 'OUT', @DateIssue, @DueDate)";
                        SqlParameter pMemberID = new SqlParameter("@MemberID", SqlDbType.NVarChar, 10);
                        SqlParameter pBookID = new SqlParameter("@BookID", SqlDbType.Int);
                        SqlParameter pDateIssue = new SqlParameter("@DateIssue", SqlDbType.DateTime);
                        SqlParameter pDueDate = new SqlParameter("@DueDate", SqlDbType.DateTime);


                        SqlParameter[] pArr = new SqlParameter[] { pMemberID, pBookID, pDateIssue, pDueDate };
                        cmdInsertIssueTran.Parameters.AddRange(pArr);


                        SqlCommand cmdUpdateBook = new SqlCommand();
                        cmdUpdateBook.Connection = con;
                        cmdUpdateBook.CommandText = "update Books set NumberBorrowed= NumberBorrowed+1 where BookID=@BookID1";
                        SqlParameter pBookID2 = new SqlParameter("@BookID1", SqlDbType.Int);
                        cmdUpdateBook.Parameters.Add(pBookID2);


                        using (TransactionScope ts = new TransactionScope())
                        {

                            con.Open();


                            pMemberID.Value = maskedTxtMemberID.Text;
                            pBookID.Value = Convert.ToInt16(txtBookID.Text);
                            pDateIssue.Value = dateTimePickerBorrowDate.Value;
                            pDueDate.Value = dateTimePickerDueDate.Value;

                            pBookID2.Value = Convert.ToInt16(txtBookID.Text);

                            cmdInsertIssueTran.ExecuteNonQuery();
                            cmdUpdateBook.ExecuteNonQuery();

                            ts.Complete();
                        }

                        con.Close();


                        MessageBox.Show("Borrow Successful");

                        BorrowReceiptForm bowform = new BorrowReceiptForm();
                        bowform.Show();
                        ClearText();


                    }
                    else
                    {
                        MessageBox.Show("Not Available");
                        ClearText();
                    }


                }

                else
                {
                    MessageBox.Show("Your Due Date should be greater than the Borrow Date. ");
                    ClearText();
                }

            }
        }

        //Qerry For Book
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
                txtPublishierID.Clear();
                txtPublishingDate.Clear();
                txtTotalStock.Clear();

                MessageBox.Show("No match found BookID! in Database.");
            }


        }

        public SA47_Team11a_Borrow()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(str);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select (select COUNT(*) from IssueTran where MemberID = @MemberID and BorrowedStatus = 'OUT') as BorrowedBook,MemberName,IdentificationNumber,PhoneNumber,Occupation from Members where MemberID = @MemberID; ";
            SqlParameter pMemberID = new SqlParameter("@MemberID", SqlDbType.NVarChar, 10);
            cmd.Parameters.Add(pMemberID);
            pMemberID.Value = Convert.ToString(maskedTxtMemberID.Text);

            da = new SqlDataAdapter(cmd);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Members");

            //add the mathmatical method
            string member = maskedTxtMemberID.Text;
            if (member.Length == 5)
            {
                string firstle = member.Substring(member.Length - 5, 1);
                string secondle = member.Substring(member.Length - 4, 1);
                string thirdle = member.Substring(member.Length - 3, 1);
                string fourthle = member.Substring(member.Length - 2, 1);
                string fifthle = member.Substring(member.Length - 1, 1);
                if (firstle != " " && secondle != " " && thirdle != " " && fourthle != " " && fifthle != " ")
                {    //MessageBox.Show(fifthle);

                    int firstnum = Convert.ToInt32(firstle);
                    int secondnum = Convert.ToInt32(secondle);
                    int thirdnum = Convert.ToInt32(thirdle);
                    int fourthnum = Convert.ToInt32(fourthle);
                    int fifthnum = Convert.ToInt32(fifthle);


                    int checkval = (firstnum + secondnum * 2 + thirdnum * 3 + fourthnum * 4) % 10;
                    if (checkval == fifthnum)
                    {
                        if (ds.Tables["Members"].Rows.Count > 0)
                        {
                            PopulateMemberTextBoxes();
                        }
                        else
                        {
                            maskedTxtMemberID.Clear();
                            txtMemberName.Text = " ";
                            txtOccupation.Text = " ";
                            txtPhoneNumber.Text = " ";
                            txtIdentificationNum.Text = " ";
                            txtAvailableToBorrow.Text = " ";
                            MessageBox.Show("No match found MemberID in Database!");

                        }
                    }
                    else
                    {
                        maskedTxtMemberID.Clear();
                        MessageBox.Show("The input MemberID is invalid!");
                    }

                }

                else
                {
                    maskedTxtMemberID.Clear();
                    txtMemberName.Text = " ";
                    txtOccupation.Text = " ";
                    txtPhoneNumber.Text = " ";
                    txtIdentificationNum.Text = " ";
                    txtAvailableToBorrow.Text = " ";
                    MessageBox.Show("The input MemberID is invalid1!");

                }
            }
            else
            {
                MessageBox.Show("Your MemberID should be 5 numbers");
            }

        }

        private void dateTimePickerDueDate_ValueChanged(object sender, EventArgs e)
        {

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
            txtPublishierID.Text = ds2.Tables["Books"].Rows[0]["PublisherName"].ToString();
            txtPublishingDate.Text = ds2.Tables["Books"].Rows[0]["PublishingYear"].ToString();
            txtTotalStock.Text = Convert.ToString(Convert.ToInt32(ds2.Tables["Books"].Rows[0]["TotalStock"].ToString()) - Convert.ToInt32(ds2.Tables["Books"].Rows[0]["NumberBorrowed"].ToString()));

        }


        public void ClearText()
        {
            maskedTxtMemberID.Clear();
            txtBookID.Clear();
            // dateTimePickerBorrowDate.CustomFormat = " ";
            // dateTimePickerBorrowDate.Format = DateTimePickerFormat.Custom;
            // dateTimePickerDueDate.CustomFormat = " ";
            // dateTimePickerDueDate.Format = DateTimePickerFormat.Custom;
            txtMemberName.Clear();
            txtIdentificationNum.Clear();
            txtOccupation.Clear();
            txtPhoneNumber.Clear();
            txtAvailableToBorrow.Clear();
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublishierID.Clear();
            txtPublishingDate.Clear();
            txtTotalStock.Clear();


        }


    }
}