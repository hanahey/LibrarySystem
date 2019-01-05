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
    public partial class Member_list_Report : Form
    {
        public Member_list_Report()
        {
            InitializeComponent();
        }

        private void Member_list_Report_Load(object sender, EventArgs e)
        {

            SA47Team11aLibraryDS ds = new SA47Team11aLibraryDS();
            SA47Team11aLibraryDSTableAdapters.MembersTableAdapter ta = new SA47Team11aLibraryDSTableAdapters.MembersTableAdapter();
            ta.Fill(ds.Members);

            MemberList memberList = new MemberList();

            memberList.SetDataSource(ds.Tables["Members"]);
            crMember.ReportSource = memberList;
        }
    }
}
