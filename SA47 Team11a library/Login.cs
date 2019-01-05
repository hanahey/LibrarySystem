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
    public partial class LoginForm : Form
    {
        string conS = "data source = (local);integrated security=SSPI;initial catalog = SA47Team11ALibraryDB";
        SqlConnection cn;
        SqlCommand cm;
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        public LoginForm()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        public LoginForm(string info) : this()
        {            // 在TextBox中显示信息初值            
            employeeIDtextbox.Text = "";
        }         /// <summary>        /// 获取修改后的信息        /// </summary>        
        public string Information
        {
            get { return employeeIDtextbox.Text; }
        }
    

          
            private void loginButton_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(conS);
            cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "select * from employees";
            da = new SqlDataAdapter(cm);
            da.Fill(ds, "employees");

            string str = ds.Tables[0].Rows.Count.ToString();
            int a = Convert.ToInt32(str);
            int i = 0;

            for (i = 0; i < a; i++)
            {
                if (employeeIDtextbox.Text == ds.Tables[0].Rows[i]["employeename"].ToString())
                {
                    //MessageBox.Show(ds.Tables[0].Rows[i]["employeename"].ToString());
                    if(passwordTextbox.Text== ds.Tables[0].Rows[i]["password"].ToString())
                    {
                        MessageBox.Show("Login correctly");
                        Form1.i = 1;
                        Form1.b = ds.Tables[0].Rows[i]["employeename"].ToString();
                        break;
                    }

                }
            }
            if (i==a)
            {
                MessageBox.Show("Login failed!");

            }

        }
    }
}
