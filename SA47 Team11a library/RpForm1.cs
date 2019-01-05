using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA47_Team11a_library
{
    public partial class RpForm1 : Form
    {
        public RpForm1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            BookListDS ds = new BookListDS();
            BookListDSTableAdapters.BooksTableAdapter ta = new BookListDSTableAdapters.BooksTableAdapter();
            ta.Fill(ds.Books);
            //ta.Fill(ds.BookCategories);

            CrystalReport1 bookList = new CrystalReport1();
            bookList.SetDataSource(ds.Tables["Books"]);
            crystalReportViewer1.ReportSource = bookList;



        }
    }
}
