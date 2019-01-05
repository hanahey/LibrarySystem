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

namespace SA47_Team11a_library
{
    public partial class SA47_Team11a_Reservation : Form
    {
        string str = "data source=(local); initial catalog = SA47Team11ALibraryDB; integrated security=SSPI";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da1, da2;
        SqlCommandBuilder cmb, cmb2;
        DataSet ds1, ds2;

        string conS = "data source = (local);integrated security=SSPI;initial catalog = SA47Team11ALibraryDB";
        SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        public SA47_Team11a_Reservation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            cn = new SqlConnection(conS);
            cm = new SqlCommand();
            cm.Connection = cn;
            //cm.CommandText = "select * from members";
           // da = new SqlDataAdapter(cm);
            //da.Fill(ds, "members");

            //string str = ds.Tables[0].Rows.Count.ToString();
            //int a = Convert.ToInt32(str);

            //add the mathmatical method
            string member = maskedTextBox1.Text;
            if (member.Length == 5)
            {

                string firstle = member.Substring(member.Length - 5, 1);
                string secondle = member.Substring(member.Length - 4, 1);
                string thirdle = member.Substring(member.Length - 3, 1);
                string fourthle = member.Substring(member.Length - 2, 1);
                string fifthle = member.Substring(member.Length - 1, 1);
                if (firstle!=" "&&secondle!=" "&&thirdle!=" "&&fourthle!=" "&&fifthle!=" ")
                {
                    //MessageBox.Show(fifthle);

                    int firstnum = Convert.ToInt32(firstle);
                    int secondnum = Convert.ToInt32(secondle);
                    int thirdnum = Convert.ToInt32(thirdle);
                    int fourthnum = Convert.ToInt32(fourthle);
                    int fifthnum = Convert.ToInt32(fifthle);
                    int checkval = (firstnum + secondnum * 2 + thirdnum * 3 + fourthnum * 4) % 10;

                    //校验检验部分
                    //MessageBox.Show(firstle);
                    //MessageBox.Show(secondle);
                    //MessageBox.Show(thirdle);
                    //MessageBox.Show(fourthle);
                    //MessageBox.Show(fifthle);
                    //MessageBox.Show(Convert.ToString(checkval));



                    con = new SqlConnection(conS);
                    cmd = new SqlCommand();

                    if (checkval == fifthnum)
                    {
                        // int i = 0;
                        // for (i = 0; i < a; i++)


                        // if (maskedTextBox1.Text == ds.Tables[0].Rows[i]["memberid"].ToString())
                        //  {

                        cmd.Connection = con;
                        cmd.CommandText = "select (select COUNT(*) from IssueTran where MemberID = @MemberID and BorrowedStatus = 'OUT') as BorrowedBook,MemberName,IdentificationNumber,PhoneNumber,Occupation from Members where MemberID = @MemberID; ";
                        SqlParameter pMemberID = new SqlParameter("@MemberID", SqlDbType.NVarChar, 10);
                        cmd.Parameters.Add(pMemberID);
                        pMemberID.Value = Convert.ToString(maskedTextBox1.Text);

                        da1 = new SqlDataAdapter(cmd);
                        cmb = new SqlCommandBuilder(da1);
                        ds1 = new DataSet();
                        da1.Fill(ds1, "Members");
                        if (ds1.Tables["Members"].Rows.Count > 0)
                        {
                            textBox12.Text = ds1.Tables["Members"].Rows[0]["MemberName"].ToString();
                            textBox11.Text = ds1.Tables["Members"].Rows[0]["Occupation"].ToString();
                            textBox10.Text = ds1.Tables["Members"].Rows[0]["PhoneNumber"].ToString();
                            textBox13.Text = ds1.Tables["Members"].Rows[0]["IdentificationNumber"].ToString();
                            //textBox12.Text = ds.Tables["Members"].Rows[0]["MemberName"].ToString();
                            //textBox11.Text = ds.Tables["Members"].Rows[0]["Occupation"].ToString();
                            // textBox10.Text = ds.Tables["Members"].Rows[0]["PhoneNumber"].ToString();
                            //textBox13.Text = ds.Tables["Members"].Rows[0]["IdentificationNumber"].ToString();
                            if (textBox11.Text == "Student")
                            {
                                textBox9.Text = Convert.ToString(10 - Convert.ToInt32(ds1.Tables["Members"].Rows[0]["BorrowedBook"].ToString()));
                            }
                            else
                            {
                                textBox9.Text = Convert.ToString(15 - Convert.ToInt32(ds1.Tables["Members"].Rows[0]["BorrowedBook"].ToString()));
                            }

                            //PopulateMemberTextBoxes();

                            //    textbox12.text = ds.tables[0].rows[i]["membername"].tostring();
                            //    textbox13.text = ds.tables[0].rows[i]["identificationnumber"].tostring();
                            //    textbox10.text = ds.tables[0].rows[i]["phonenumber"].tostring();
                            //    textbox11.text = ds.tables[0].rows[i]["occupation"].tostring();
                            //textBox9.Text = ds.Tables[0].Rows[i]["IdentificationNumber"].ToString();

                            // break;
                            //}
                        }
                        else
                        {
                            MessageBox.Show("No Member ID in the database !");

                        }

                        //if (i == a)
                        //{
                        //     MessageBox.Show("No Member ID in the database !");
                        // }
                    }
                    else
                    {
                        MessageBox.Show("The input is invalid!");

                    }
                }
                else
                {
                    MessageBox.Show("The input is invalid!");

                }
            }
            else
            {
                MessageBox.Show("Your input length is wrong!");
            }
        }

        public void PopulateMemberTextBoxes()
        {
            textBox12.Text = ds.Tables["Members"].Rows[0]["MemberName"].ToString();
            textBox11.Text = ds.Tables["Members"].Rows[0]["Occupation"].ToString();
            textBox10.Text = ds.Tables["Members"].Rows[0]["PhoneNumber"].ToString();
            textBox13.Text = ds.Tables["Members"].Rows[0]["IdentificationNumber"].ToString();
            if (textBox11.Text == "Student")
            {
                textBox9.Text = Convert.ToString(10 - Convert.ToInt32(ds.Tables["Members"].Rows[0]["BorrowedBook"].ToString()));
            }
            else
            {
                textBox9.Text = Convert.ToString(15 - Convert.ToInt32(ds.Tables["Members"].Rows[0]["BorrowedBook"].ToString()));
            }

        }

        int num1 = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(conS);
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "select * from books";
            da = new SqlDataAdapter(cm);
            da.Fill(ds, "books");

            

            string str = ds.Tables[0].Rows.Count.ToString();
            int a = Convert.ToInt32(str);
            int i = 0;

            for (i = 0; i < a; i++)
            {
                if (textBox2.Text == ds.Tables[0].Rows[i]["bookid"].ToString())
                {
                    textBox3.Text = ds.Tables[0].Rows[i]["BookName"].ToString();
                    textBox4.Text = ds.Tables[0].Rows[i]["Author"].ToString();
                    textBox5.Text = ds.Tables[0].Rows[i]["PublisherID"].ToString();
                    textBox6.Text = ds.Tables[0].Rows[i]["PublishingYear"].ToString();
                    textBox7.Text = ds.Tables[0].Rows[i]["TotalStock"].ToString();
                    if(ds.Tables[0].Rows[i]["Totalstock"].ToString()!=ds.Tables[0].Rows[i]["NumberBorrowed"].ToString())
                    {
                        num1 = 1;
                    }
                    break;
                }

            }
            if (i == a )
            {
                MessageBox.Show("Can't find this book!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cn = new SqlConnection(conS);
            
            cm = new SqlCommand();
            SqlCommand cm1 = new SqlCommand();
            cm.Connection = cn;
            cm1.Connection = cn;
            cm.CommandText = "select * from reservations";
            //cm1.CommandText = "select * from books";


            da = new SqlDataAdapter(cm);
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            da.Fill(ds, "reservations");
            if ((maskedTextBox1.Text.Length != 0) && (textBox2.Text.Length != 0))
            {
                if (num1 == 1)
                {

                    //da.InsertCommand.Parameters["customerid"].Value = maskedTextBox1.Text;
                    //da.InsertCommand.Parameters["customername"].Value = textBox2.Text;
                    //da.InsertCommand.Parameters["mambercategory"].Value = textBox3.Text;

                    DataRow r = ds.Tables["reservations"].NewRow();

                    string str = ds.Tables[0].Rows.Count.ToString();
                    int a = Convert.ToInt32(str);
                    a = a - 1;
                    //string b= ds.Tables["reservations"].Rows[a]["reservationid"].ToString();
                    //int c = Convert.ToInt32(b);
                    // c = c + 1;

                    // r["reservationid"] = c;
                    r["memberid"] = maskedTextBox1.Text;
                    r["Bookid"] = Convert.ToInt32(textBox2.Text);
                    r["Datereserved"] = dateTimePicker1.Value;

                    ds.Tables["reservations"].Rows.Add(r);
                    da.Update(ds, "reservations");
                    MessageBox.Show("Complete!");


                }
                else
                {
                    MessageBox.Show("The book doesn't need reservation!");

                }
            }
            else
            {
                MessageBox.Show("Please input all values!");

            }
        }

        private void SA47_Team11a_Reservation_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                //数字0~9所对应的keychar为48~57，小数点是46，Backspace是8
                e.Handled = true;
                //输入0-9和Backspace del 有效
                if ((e.KeyChar >= 47 && e.KeyChar <= 58) || e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                if (e.KeyChar == 46)                       //小数点      
                {
                    if (maskedTextBox1.Text.Length <= 0)
                        e.Handled = true;           //小数点不能在第一位      
                    else
                    {
                        float f;
                        if (float.TryParse(maskedTextBox1.Text + e.KeyChar.ToString(), out f))
                        {
                            e.Handled = false;
                        }
                    }
                }
            }


        
    }
}
