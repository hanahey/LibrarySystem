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
    public partial class BorrowReceiptForm : Form
    {
        public BorrowReceiptForm()
        {
            InitializeComponent();
        }

        private void BorrowReceiptForm_Load(object sender, EventArgs e)
        {
            string conS = "data source=(local);initial catalog=SA47Team11ALibraryDB;integrated security=SSPI";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            cm.Connection = cn;
            cn.Open();
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();
            cm.CommandText = "select Books.BookID,BookName,Author,TransactionID,IssueTran.MemberID," +
                "MemberName,Occupation,DateIssue,DueDate from Books,IssueTran,Members " +
                "where Books.BookID=IssueTran.BookID and IssueTran.MemberID=Members.MemberID " +
                "and TransactionID=(select Max(TransactionID) from IssueTran)";
            da.Fill(ds, "Books");
            da.Fill(ds2, "IssueTran");
            da.Fill(ds3, "Members");
            BorrowReceiptIssue cr = new BorrowReceiptIssue();
            cr.Database.Tables["Books"].SetDataSource(ds.Tables["Books"]);
            cr.Database.Tables["IssueTran"].SetDataSource(ds2.Tables["IssueTran"]);
            cr.Database.Tables["Members"].SetDataSource(ds3.Tables["Members"]);
            BorrowReceiptViewer.ReportSource = cr;
            cn.Close();
        }
    }
}
