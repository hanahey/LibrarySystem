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
    public partial class ListOfBooksReport : Form
    {
        public ListOfBooksReport()
        {
            InitializeComponent();
        }

        private void ListOfBooksReport_Load(object sender, EventArgs e)
        {
            SA47Team11aLibraryDS ds = new SA47Team11aLibraryDS();
            SA47Team11aLibraryDSTableAdapters.BooksTableAdapter ta
                = new SA47Team11aLibraryDSTableAdapters.BooksTableAdapter();
            ta.Fill(ds.Books);

            ListOfBooksCR cr = new ListOfBooksCR();
            cr.SetDataSource(ds);
            listOfBooksReportViewer.ReportSource = cr;
        }
    }
}
