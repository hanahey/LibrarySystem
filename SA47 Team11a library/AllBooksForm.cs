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
    public partial class AllBooksForm : Form
    {
        string bookName;
        public string BookName
        {
            get
            {
                return bookName;
            }
        }
        public AllBooksForm()
        {
            InitializeComponent();
        }

        private void AllBooksForm_Load(object sender, EventArgs e)
        {
            string conS = "data source=(local);initial catalog=SA47Team11ALibraryDB;integrated security=SSPI";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            cm.Connection = cn;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            cm.CommandText = "select BookName,Author, Subject from Books,BookCategories " +
                "where Books.BookCategoryID=BookCategories.BookCategoryID order by BookName";
            cn.Open();
            da.Fill(ds);
            da.Fill(dt);
            AllBooksDataGridView.DataSource = dt;
            cn.Close();
            AllBooksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void selectBookButton_Click(object sender, EventArgs e)
        {
            bookName = AllBooksDataGridView.SelectedCells[0].Value.ToString();
            DialogResult = DialogResult.OK;
        }

        private void AllBooksDataGridView_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
