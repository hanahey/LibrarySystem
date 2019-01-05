using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace SA47_Team11a_library
{

    public partial class Form1 : Form
    {

        public static int i = 0;
        public static string b;
        public int Changes
        {
            set
            {
                label1.Text = b;
                button1.Visible=true;
            }
        }
       
        public Form1()
        {
            InitializeComponent();
            
        }


        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form search = new SearchForm();
            //search.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form newbook = new Newbook();
            //newbook.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                MaintainBooksInfoForm maintain1 = new MaintainBooksInfoForm();
                maintain1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login!");

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form deletebook = new Deletebook();
            //deletebook.Show();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                MaintainMembersInfo mainmem = new MaintainMembersInfo();
                mainmem.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login!");

            }
          
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LoginForm login = new LoginForm();
            //login.ShowDialog();


            LoginForm formInfo = new LoginForm(label1.Text);                        // 以对话框方式显示FormInfo           
            DialogResult result = formInfo.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {                // 如果点击了FromInfo的“确定”按钮，获取修改后的信息并显示                
                if (i == 1)
                {
                    //MessageBox.Show("Last step");
                    loginToolStripMenuItem.Visible = false;
                    button1.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Hello "+formInfo.Information;
                }
            }

     


        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            loginToolStripMenuItem.Visible = true;
            button1.Visible = false;
            label1.Visible = false;
            label1.Text = "";
            //MessageBox.Show(Convert.ToString( i));
            //label2.Text = Convert.ToString(i);

        }

        private void reserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {

                SA47_Team11a_Reservation reserve = new SA47_Team11a_Reservation();
                reserve.Show();
            }
            else
            {
                MessageBox.Show("Please login!");

            }

        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {


            FormSearch searchform = new FormSearch();
            searchform.ShowDialog();

        }

        private void searchAvailabilityDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
         

            AvaDateForm avaDate1 = new AvaDateForm();
            avaDate1.ShowDialog();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (i == 1)
            {
                SA47_Team11a_Borrow borrowform = new SA47_Team11a_Borrow();
                borrowform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login!");

            }


            
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listOfBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                ListOfBooksReport bookrp = new ListOfBooksReport();
                bookrp.Show();
            }
            else
            {
                MessageBox.Show("Please login!");

            }

          
        }

        private void listOfMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                Member_list_Report mbr = new Member_list_Report();
                mbr.Show();
            }
            else
            {
                MessageBox.Show("Please login!");

            }


        }

        private void crossToTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                CrossTabReportForm crossform = new CrossTabReportForm();
                crossform.Show();
            }
            else
            {
                MessageBox.Show("Please login!");

            }


        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {

                SA47_Team11a_Return returnform = new SA47_Team11a_Return();
                returnform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login!");

            }

        }

        private void viewBorrowingRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                ViewBorrowingRecord vbr = new ViewBorrowingRecord();
                vbr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login!");

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void borrowReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {   

            

            if (i == 1)
            {
                BorrowReceiptForm bore = new BorrowReceiptForm();
                bore.Show();
            }
            else
            {
                MessageBox.Show("Please login!");

            }
        }
    }
}
