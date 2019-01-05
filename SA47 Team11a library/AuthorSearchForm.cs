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
    public partial class AuthorSearchForm : Form
    {
        string authorBook;
        public string AuthorBook
        {
            get
            {
                return authorBook;
            }
        }
        public AuthorSearchForm()
        {
            InitializeComponent();
        }

        public AuthorSearchForm(string AuthorName)
        {
            InitializeComponent();
            AuthorNameLabel.Text = AuthorName;
        }


        private void selectBookButton_Click(object sender, EventArgs e)
        {
            authorBook = AuthorBooksDataGridView.SelectedCells[0].Value.ToString();
            DialogResult = DialogResult.OK;
        }

        private void AuthorSearchForm_Load(object sender, EventArgs e)
        {
            string conS = "data source=(local);initial catalog=SA47Team11ALibraryDB;integrated security=SSPI";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            cm.Connection = cn;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            cm.CommandText = "select BookID,BookName,Author,Subject from Books,BookCategories " +
                "where Books.BookCategoryID=BookCategories.BookCategoryID and Author=@an";
            SqlParameter pAN = new SqlParameter("@an", SqlDbType.NVarChar, 50);
            cm.Parameters.Add(pAN);
            pAN.Value = AuthorNameLabel.Text;

            cn.Open();
            da.Fill(ds);
            da.Fill(dt);
            AuthorBooksDataGridView.DataSource = dt;
            cn.Close();
            AuthorBooksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
