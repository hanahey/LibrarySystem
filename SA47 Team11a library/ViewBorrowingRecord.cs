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
    public partial class ViewBorrowingRecord : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;
        int posn;
        public ViewBorrowingRecord()
        {
            InitializeComponent();
        }

        private void ViewBorrowingRecord_Load(object sender, EventArgs e)
        {
        }

        private void SearchByMemberIDButton_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local);initial catalog=SA47Team11ALibraryDB;integrated security=SSPI";
            cn = new SqlConnection(conS);
            cm = new SqlCommand();
            cm.CommandText = "Select * from IssueTran where memberID = '"+ SearchMemberByIDTextBox.Text +"'";
            cm.Connection = cn;
            da = new SqlDataAdapter(cm);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "IssueTran");

            dataGridView1.DataSource = ds.Tables["IssueTran"];
        }

        private void LoadAllMembersButton_Click(object sender, EventArgs e)
        {
            string conS = "data source=(local);initial catalog=SA47Team11ALibraryDB;integrated security=SSPI";
            cn = new SqlConnection(conS);
            cm = new SqlCommand();
            cm.CommandText = "Select * from IssueTran";
            cm.Connection = cn;
            da = new SqlDataAdapter(cm);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "IssueTran");

            dataGridView1.DataSource = ds.Tables["IssueTran"];
        }
    }
}
