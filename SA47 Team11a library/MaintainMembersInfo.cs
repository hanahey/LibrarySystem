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
    public partial class MaintainMembersInfo : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlCommand cmIssueTran;
        SqlDataAdapter da;
        SqlDataAdapter daIssueTran;
        SqlCommandBuilder cmb;
        DataSet ds;
        int posn;
        public MaintainMembersInfo()
        {
            InitializeComponent();
        }

        private void MaintainMembersInfo_Load(object sender, EventArgs e)
        {
            string conS = "data source=(local);initial catalog=SA47Team11ALibraryDB;integrated security=SSPI";
            cn = new SqlConnection(conS);
            cm = new SqlCommand();
            cmIssueTran = new SqlCommand();
            cm.CommandText = "Select * from Members";
            cmIssueTran.CommandText = "Select MemberID from IssueTran";
            cm.Connection = cn;
            cmIssueTran.Connection = cn;
            da = new SqlDataAdapter(cm);
            daIssueTran = new SqlDataAdapter(cmIssueTran);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Members");



        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            bool IDexist = false;
            for (int i = 0; i < ds.Tables["Members"].Rows.Count; i++)
            {
                if (ds.Tables["Members"].Rows[i]["MemberID"].ToString() == MemberIDTextBox.Text.Trim())
                {
                    IDexist = true;
                    break;
                }

            }
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Please fill in your name, it is a required field");
            }
            else if (IdentificationNoTextBox.Text == "")
            {
                MessageBox.Show("Please fill in your identification number, it is a required field");
            }
            else if (IDexist)
            {
                UpdateData();
                da.Update(ds, "Members");
                MessageBox.Show("Updated successfully!");

            }
            else
            {
                MessageBox.Show("Cannot find this member!");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            posn = 0;
            PopulateTextBoxes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            daIssueTran.Fill(ds, "IssueTran");
            bool IDexistsMembers = false;
            bool IDexistsIssueTran = false;
            for (int i = 0; i < ds.Tables["Members"].Rows.Count; i++)
            {
                if (MemberIDTextBox.Text == ds.Tables["Members"].Rows[i]["MemberID"].ToString())
                {
                    IDexistsMembers = true;
                    break;
                }
            }

            for (int i = 0; i < ds.Tables["IssueTran"].Rows.Count; i++)
            {
                if (MemberIDTextBox.Text == ds.Tables["IssueTran"].Rows[i]["MemberID"].ToString())
                {
                    IDexistsIssueTran = true;
                    break;
                }
            }
            if (IDexistsMembers && (!IDexistsIssueTran))
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete this member?",
                "Confirm delete", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    ds.Tables["Members"].Rows[posn].Delete();
                    da.Update(ds, "Members");
                    MessageBox.Show("Member has been deleted!");
                }
            }
            else if (!IDexistsMembers)
            {
                MessageBox.Show("Cannot find this Member.");
            }
            else if (IDexistsIssueTran)
            {
                MessageBox.Show("This member has borrowed book(s), so you cannot delete him/her now!");
            }

















            
        }
        
        private void CreateButton_Click(object sender, EventArgs e)
        {
            //string PhoneNo = PhoneNoMaskedTextBox.Text;
            //if (PhoneNo.Length != 8)
            //{
            //    MessageBox.Show("Please enter a valid phone number");
            //}
            //if (NameTextBox.Text == "")
            //{
            //    MessageBox.Show("Please fill in your name, it is a required field");
            //}
            //if (IdentificationNoTextBox.Text =="")
            //{
            //    MessageBox.Show("Please fill in your identification number, it is a required field");
            //}
            bool IDexist=false;
            for (int i=0; i<ds.Tables["Members"].Rows.Count; i++)
            {
                if(ds.Tables["Members"].Rows[i]["MemberID"].ToString() == MemberIDTextBox.Text.Trim())
                {
                    IDexist = true;
                    break;  
                }

            }
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Please fill in your name, it is a required field");
            }
            else if (IdentificationNoTextBox.Text =="")
            {
                MessageBox.Show("Please fill in your identification number, it is a required field");
            }
            else if (!IDexist && MemberIDTextBox.Text !="")
            {
                DataRow dr = ds.Tables["Members"].NewRow();
                dr["MemberID"] = MemberIDTextBox.Text;
                dr["MemberName"] = NameTextBox.Text;
                dr["IdentificationNumber"] = IdentificationNoTextBox.Text;
                dr["Occupation"] = OccupationComboBox.SelectedItem;
                dr["PhoneNumber"] = PhoneNoMaskedTextBox.Text;
                dr["Address"] = AddressTextBox.Text;
                ds.Tables["Members"].Rows.Add(dr);
                da.Update(ds, "Members");
                MessageBox.Show("Created!!");
            }
            else
            {
                MessageBox.Show("Member ID already exists");
                return;
            }  
                
               
            
        }

        private void FindMemberByIDButton_Click(object sender, EventArgs e)
        {
            int i;
            for(i=0; i<ds.Tables["Members"].Rows.Count; i++)
            {
                if(FindMemberByIDTextBox.Text.Trim()==ds.Tables["Members"].Rows[i]["MemberID"].ToString())
                {
                    posn = i;
                    break;
                } 
            }
            if (i < ds.Tables["Members"].Rows.Count)
            {
                PopulateTextBoxes();
            } else
                MessageBox.Show("Member not found!!");
        }

        private void FowardButton_Click(object sender, EventArgs e)
        {
            if (posn < ds.Tables["Members"].Rows.Count-1)
            {
                posn++;
                PopulateTextBoxes();
            }
            int last = ds.Tables["Members"].Rows.Count - 1;
            if (posn == last)
            {
                FirstLastRecordPromptLabel.Text = "This is the last member";
            }
            else
            {
                FirstLastRecordPromptLabel.Text = "";
            }
        }

        private void BackwardsButton_Click(object sender, EventArgs e)
        {
            if(posn>0)
            {
                posn--;
                PopulateTextBoxes();
            }
            if(posn==0)
            {
                FirstLastRecordPromptLabel.Text = "This is the first member";
            }
            else
            {
                FirstLastRecordPromptLabel.Text = "";
            }
        }

        private void ClearFieldsButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            MemberIDTextBox.Text = "";
            NameTextBox.Text = "";
            IdentificationNoTextBox.Text = "";
            OccupationComboBox.ResetText();
            PhoneNoMaskedTextBox.Text = "";
            AddressTextBox.Text = "";
        }

        private void PopulateTextBoxes()
        {
            MemberIDTextBox.Text = ds.Tables["Members"].Rows[posn]["MemberID"].ToString();
            NameTextBox.Text = ds.Tables["Members"].Rows[posn]["MemberName"].ToString();
            IdentificationNoTextBox.Text = ds.Tables["Members"].Rows[posn]["IdentificationNumber"].ToString();
            OccupationComboBox.SelectedItem = ds.Tables["Members"].Rows[posn]["Occupation"].ToString();
            PhoneNoMaskedTextBox.Text = ds.Tables["Members"].Rows[posn]["PhoneNumber"].ToString();
            AddressTextBox.Text = ds.Tables["Members"].Rows[posn]["Address"].ToString();
        }

        private void UpdateData()
        {
            ds.Tables["Members"].Rows[posn]["MemberID"] = MemberIDTextBox.Text;
            ds.Tables["Members"].Rows[posn]["MemberName"] = NameTextBox.Text;
            ds.Tables["Members"].Rows[posn]["IdentificationNumber"] = IdentificationNoTextBox.Text;
            ds.Tables["Members"].Rows[posn]["Occupation"] = OccupationComboBox.SelectedItem.ToString();
            ds.Tables["Members"].Rows[posn]["PhoneNumber"] = PhoneNoMaskedTextBox.Text;
            ds.Tables["Members"].Rows[posn]["Address"] = AddressTextBox.Text;
        }

        private void GenerateNewMemberID()
        {
            int previousMemberPosition = Convert.ToInt32(ds.Tables["Members"].Rows.Count.ToString()) - 1;  //latest position
            string previousMemberID = ds.Tables["Members"].Rows[previousMemberPosition]["MemberID"].ToString(); //store latest member id
            //MessageBox.Show(previousMemberID);

            if (previousMemberID.Length == 5)
            {
                
                string firstle = previousMemberID.Substring(previousMemberID.Length - 5, 1);
                string secondle = previousMemberID.Substring(previousMemberID.Length - 4, 1);
                string thirdle = previousMemberID.Substring(previousMemberID.Length - 3, 1);
                string fourthle = previousMemberID.Substring(previousMemberID.Length - 2, 1);
                string fifthle = previousMemberID.Substring(previousMemberID.Length - 1, 1);

               

                int firstnum = Convert.ToInt32(firstle);
                int secondnum = Convert.ToInt32(secondle);
                int thirdnum = Convert.ToInt32(thirdle);
                int fourthnum = Convert.ToInt32(fourthle); //add 1 before running algorithm
                int fifthnum = Convert.ToInt32(fifthle);
                //int checkval = (firstnum + secondnum * 2 + thirdnum * 3 + fourthnum * 4) % 10;

                string laternum = firstle + secondle + thirdle + fourthle;
                int numla = Convert.ToInt32(laternum);
                numla = numla + 1;

                laternum = Convert.ToString(numla);


                string newFirstLe = laternum.Substring(laternum.Length - 4, 1);
                string newSecondLe = laternum.Substring(laternum.Length - 3, 1);
                string newThirdLe = laternum.Substring(laternum.Length - 2, 1);
                string newFourthLe = laternum.Substring(laternum.Length -1, 1);

                int checkval = (Convert.ToInt32(newFirstLe) + Convert.ToInt32(newSecondLe) * 2 + Convert.ToInt32(newThirdLe) * 3 + Convert.ToInt32(newFourthLe) * 4) % 10;

                string newFifthLe = checkval.ToString();
                //MessageBox.Show(newFifthLe);


                string newMemberID = newFirstLe + newSecondLe + newThirdLe + newFourthLe + newFifthLe;
               // MessageBox.Show(newMemberID);

                MemberIDTextBox.Text = newMemberID;
            }
            else
            {
                MessageBox.Show("MemberID not valid");
            }
        }

        private void GenerateNewMemberIDButton_Click(object sender, EventArgs e)
        {
            GenerateNewMemberID();
        }

        

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
