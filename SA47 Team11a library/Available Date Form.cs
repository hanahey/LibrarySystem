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
    public partial class AvaDateForm : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
        DataTable dt;
        bool correctTyping = false;
        bool validInput = false;


        public AvaDateForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local);initial catalog=SA47Team11ALibraryDB;integrated security=SSPI";
            cn = new SqlConnection(conS);
            cm = new SqlCommand();
            da = new SqlDataAdapter(cm);
            dt = new DataTable();
            cm.Connection = cn;

            
            if (BookIDRadioButton.Checked == true)
            {
                if (SearchTextBox.Text == "")
                {
                    MessageBox.Show("Nothing has been entered!");
                }
                else
                {
                    cm.CommandText = "select Books.BookID, BookName, Author, DueDate from Books, IssueTran " +
                        "where Books.BookID=@BI and BorrowedStatus='OUT' and IssueTran.BookID=Books.BookID";
                    SqlParameter pBI = new SqlParameter("@BI", SqlDbType.Int);
                    cm.Parameters.Add(pBI);
                    cn.Open();
                    pBI.Value = Convert.ToString(SearchTextBox.Text);
                    da.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (SearchTextBox.Text == dt.Rows[0][i].ToString())
                        {
                            validInput = true;
                            AvaDateDataGridView.DataSource = dt;
                            cn.Close();
                            break;
                        }
                    }
                    if (validInput == false)
                    {
                        MessageBox.Show("Invalid input! Please check if this BookID is correct or if there are any copies on loan.");
                        cn.Close();
                    }
                }

            }
            else if (BookNameRadioButton.Checked == true)
            {
                if (SearchTextBox.Text == "")
                {
                    MessageBox.Show("Nothing has been entered!");
                }
                else
                {
                    cm.CommandText = "select Books.BookID, BookName, Author, DueDate from Books, IssueTran where " +
                        "Books.BookID=IssueTran.BookID and BorrowedStatus='OUT' and BookName like @BN+'%' order by Books.BookID";
                    SqlParameter pBN = new SqlParameter("@BN", SqlDbType.NVarChar, 50);
                    cm.Parameters.Add(pBN);
                    cn.Open();
                    pBN.Value = Convert.ToString(SearchTextBox.Text);
                    da.Fill(dt);
                    AvaDateDataGridView.DataSource = dt;
                    cn.Close();
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid input! \nPlease check if this Book Name is correct or if there are any copies on loan.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing has been entered!");
            }
            SearchTextBox.Clear();
        }

        private void AvaDateForm_Load(object sender, EventArgs e)
        {
           
        }

        private void BookNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            if (BookIDRadioButton.Checked == true || BookNameRadioButton.Checked == true)
            {
                SearchTextBox.ReadOnly = false;
            }
            else
            {
                SearchTextBox.ReadOnly = true;
            }
        }

        private void BookIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
            if (BookIDRadioButton.Checked == true || BookNameRadioButton.Checked == true)
            {
                SearchTextBox.ReadOnly = false;
            }
            else
            {
                SearchTextBox.ReadOnly = true;
            }
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (correctTyping == false)
            {
                e.Handled = true;
            }
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (BookNameRadioButton.Checked == true)
            {
                if ((e.KeyCode == Keys.A) || (e.KeyCode == Keys.B) || (e.KeyCode == Keys.C)
                   || (e.KeyCode == Keys.D) || (e.KeyCode == Keys.E) || (e.KeyCode == Keys.F)
                   || (e.KeyCode == Keys.G) || (e.KeyCode == Keys.H) || (e.KeyCode == Keys.I)
                   || (e.KeyCode == Keys.J) || (e.KeyCode == Keys.K) || (e.KeyCode == Keys.L)
                   || (e.KeyCode == Keys.M) || (e.KeyCode == Keys.N) || (e.KeyCode == Keys.O)
                   || (e.KeyCode == Keys.P) || (e.KeyCode == Keys.Q) || (e.KeyCode == Keys.R)
                   || (e.KeyCode == Keys.S) || (e.KeyCode == Keys.T) || (e.KeyCode == Keys.U)
                   || (e.KeyCode == Keys.V) || (e.KeyCode == Keys.W) || (e.KeyCode == Keys.X)
                   || (e.KeyCode == Keys.Y) || (e.KeyCode == Keys.Z) || (e.KeyCode == Keys.Space)
                   || (e.KeyCode == Keys.Back) || (e.KeyCode == Keys.ShiftKey) || (e.KeyCode == Keys.OemSemicolon))
                {
                    correctTyping = true;
                }
                else
                {
                    correctTyping = false;
                }
            }
            if (BookIDRadioButton.Checked == true)
            {
                if ((e.KeyCode == Keys.D1) || (e.KeyCode == Keys.D2) || (e.KeyCode == Keys.D3)
                   || (e.KeyCode == Keys.D4) || (e.KeyCode == Keys.D5) || (e.KeyCode == Keys.D6)
                   || (e.KeyCode == Keys.D7) || (e.KeyCode == Keys.D8) || (e.KeyCode == Keys.D9)
                   || (e.KeyCode == Keys.D0) || (e.KeyCode == Keys.Back))
                {
                    correctTyping = true;
                }
                else
                {
                    correctTyping = false;
                }
            }
        }
    }
}
