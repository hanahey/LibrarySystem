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
    public partial class MaintainBooksInfoForm : Form
    {
        SqlConnection connection;
        SqlCommand cmBooks;
        SqlCommand cmPublishers;
        SqlCommand cmBookkCategories;
        SqlCommand cmIssueTran;
        SqlDataAdapter daBooks;
        SqlDataAdapter daBookCategories;
        SqlDataAdapter daPublishers;
        SqlDataAdapter daIssueTran;
        SqlCommandBuilder cmbBooks;
        SqlCommandBuilder cmbBookCategories;
        SqlCommandBuilder cmbPublishers;
        DataSet ds;
        DataRow BooksDr;
        DataRow PublishersDr;
        DataRow BookCategoriesDr;
        int posnBooks = 0;
        int posnBookCategories;
        int posnPublishers;
        public MaintainBooksInfoForm()
        {
            InitializeComponent();
            setToolTip();
        }
        private void setToolTip()
        {
            FindToolTip.SetToolTip(FindButton, "Input the Book ID to find.");
        } 
        private void MaintainBooksInfoForm_Load(object sender, EventArgs e)
        {
            //FindToolStripStatusLabel.Text = "Record " + posnBooks + " in the book list.";
            string conString = "data source=(local);integrated security=SSPI;initial catalog=SA47Team11ALibraryDB";
            connection = new SqlConnection(conString);

            cmBooks = new SqlCommand();
            cmPublishers = new SqlCommand();
            cmBookkCategories = new SqlCommand();
            cmIssueTran = new SqlCommand();


            cmBooks.CommandText = "Select BookID,BookName,Author,PublishingYear,Edition,BookCategoryID,TotalStock,NumberBorrowed,PublisherID from Books";
            cmPublishers.CommandText = "Select PublisherName,PublisherID from Publishers";
            cmBookkCategories.CommandText = "Select BookCategoryID,Location from BookCategories";
            cmIssueTran.CommandText = "Select BookID from IssueTran";

            cmBooks.Connection = connection;
            cmPublishers.Connection = connection;
            cmBookkCategories.Connection = connection;
            cmIssueTran.Connection = connection;

            daBooks = new SqlDataAdapter(cmBooks);
            daBookCategories = new SqlDataAdapter(cmBookkCategories);
            daPublishers = new SqlDataAdapter(cmPublishers);
            daIssueTran = new SqlDataAdapter(cmIssueTran);

            cmbBooks = new SqlCommandBuilder(daBooks);
            cmbBookCategories = new SqlCommandBuilder(daBookCategories);
            cmbPublishers = new SqlCommandBuilder(daPublishers);

            ds = new DataSet();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            posnBooks = 0;
            daBooks.Fill(ds, "Books");
            daPublishers.Fill(ds, "Publishers");
            daBookCategories.Fill(ds, "BookCategories");
            Display();
        }
        private void Display()
        {
            BookIDTextBox.Text = ds.Tables["Books"].Rows[posnBooks]["BookID"].ToString();
            BookNameTextBox.Text = ds.Tables["Books"].Rows[posnBooks]["BookName"].ToString();
            AuthorTextBox.Text = ds.Tables["Books"].Rows[posnBooks]["Author"].ToString();
            PubYearTextBox.Text = ds.Tables["Books"].Rows[posnBooks]["PublishingYear"].ToString();
            EdiNumberTextBox.Text = ds.Tables["Books"].Rows[posnBooks]["Edition"].ToString();
            TotalStockTextBox.Text = ds.Tables["Books"].Rows[posnBooks]["TotalStock"].ToString();
            NumBorrowedTextBox.Text = ds.Tables["Books"].Rows[posnBooks]["NumberBorrowed"].ToString();
            BookCategoryComboBox.SelectedItem = ds.Tables["Books"].Rows[posnBooks]["BookCategoryID"].ToString();
            for (int i = 0; i < ds.Tables["BookCategories"].Rows.Count; i++)
            {
                if (ds.Tables["BookCategories"].Rows[i]["BookCategoryID"].ToString() == BookCategoryComboBox.SelectedItem.ToString())
                {
                    posnBookCategories = i;
                    break;
                }
            }
            for (int i = 0; i < ds.Tables["Publishers"].Rows.Count; i++)
            {
                if (ds.Tables["Publishers"].Rows[i]["PublisherID"].ToString() == ds.Tables["Books"].Rows[posnBooks]["PublisherID"].ToString())
                {
                    posnPublishers = i;
                    break;
                }
            }

            LocationTextBox.Text = ds.Tables["BookCategories"].Rows[posnBookCategories]["Location"].ToString();
            PublisherTextBox.Text = ds.Tables["Publishers"].Rows[posnPublishers]["PublisherName"].ToString();
            FindToolStripStatusLabel.Text = "Record " + (posnBooks+1) + " in the book list.";
        }

        private void AddButton_Click(object sender, EventArgs e)
        { 
            daBooks.Fill(ds, "Books");
            daPublishers.Fill(ds, "Publishers");
            daBookCategories.Fill(ds, "BookCategories");

            bool InputID = (BookIDTextBox.Text == "");
            bool InputName = (BookNameTextBox.Text == "");
            bool InputAuthor = (AuthorTextBox.Text == "");
            bool InputPubYear = (PubYearTextBox.Text == "");
            bool InputEdiNumber = (EdiNumberTextBox.Text == "");
            bool InputStock = (TotalStockTextBox.Text == "");
            bool InputNumBorrowed = (NumBorrowedTextBox.Text == "");
            bool InputLocation = (LocationTextBox.Text == "");
            bool InputPublisher = (PublisherTextBox.Text == "");
            bool SelectCategory = (BookCategoryComboBox.SelectedItem == null);


            if (InputID || InputName || InputAuthor || InputPubYear || InputEdiNumber ||
                InputStock || InputNumBorrowed || InputLocation || InputPublisher || SelectCategory)
            {
                MessageBox.Show("Please fill in every blank.");
            }
            else
            {
                BooksDr = ds.Tables["Books"].NewRow();
                PublishersDr = ds.Tables["Publishers"].NewRow();
                BookCategoriesDr = ds.Tables["BookCategories"].NewRow();
                bool IDexist = false;
                for (int i = 0; i < ds.Tables["Books"].Rows.Count; i++)
                {
                    if (BookIDTextBox.Text == ds.Tables["Books"].Rows[i]["BookID"].ToString())
                    {
                        MessageBox.Show("This book ID is already used,so you cannot add");
                        IDexist = true;
                        break;
                    }
                }
                if (!IDexist)
                {
                    BooksDr["BookID"] = BookIDTextBox.Text;
                    BooksDr["BookName"] = BookNameTextBox.Text;
                    BooksDr["Author"] = AuthorTextBox.Text;
                    BooksDr["PublishingYear"] = PubYearTextBox.Text;
                    BooksDr["Edition"] = EdiNumberTextBox.Text;
                    BooksDr["TotalStock"] = TotalStockTextBox.Text;
                    BooksDr["NumberBorrowed"] = 0;
                    BooksDr["BookCategoryID"] = BookCategoryComboBox.SelectedItem;
                    for (int i = 0; i < ds.Tables["BookCategories"].Rows.Count; i++)
                    {
                        if (ds.Tables["BookCategories"].Rows[i]["BookCategoryID"].ToString() == BookCategoryComboBox.SelectedItem.ToString())
                        {
                            posnBookCategories = i;
                            break;
                        }
                    }
                    for (int i = 0; i < ds.Tables["Publishers"].Rows.Count; i++)
                    {
                        if (ds.Tables["Publishers"].Rows[i]["PublisherID"].ToString() == ds.Tables["Books"].Rows[posnBooks]["PublisherID"].ToString())
                        {
                            posnPublishers = i;
                            break;
                        }
                    }

                    bool exist = false;
                    for (int i = 0; i < ds.Tables["Publishers"].Rows.Count; i++)
                    {
                        if (PublisherTextBox.Text == ds.Tables["Publishers"].Rows[i]["PublisherName"].ToString())
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (exist == false)
                    {
                        MessageBox.Show(PublisherTextBox.Text, "show content",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                        PublishersDr["PublisherName"] = PublisherTextBox.Text;
                        PublishersDr["PublisherID"] = PublisherTextBox.Text.Substring(0, 3).ToUpper();
                        ds.Tables["Publishers"].Rows.Add(PublishersDr);
                        daPublishers.Update(ds, "Publishers");
                    }

                    BooksDr["PublisherID"] = PublisherTextBox.Text.Substring(0, 3).ToUpper();
                    ds.Tables["Books"].Rows.Add(BooksDr);

                    daBooks.Update(ds, "Books");

                    MessageBox.Show("Added!! ");
                }
                else
                {
                    //MessageBox.Show("Cannot Add!");
                    return;
                }

            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            daBooks.Fill(ds, "Books");
            daPublishers.Fill(ds, "Publishers");
            daBookCategories.Fill(ds, "BookCategories");

            bool InputID = (BookIDTextBox.Text == "");
            bool InputName = (BookNameTextBox.Text == "");
            bool InputAuthor = (AuthorTextBox.Text == "");
            bool InputPubYear = (PubYearTextBox.Text == "");
            bool InputEdiNumber = (EdiNumberTextBox.Text == "");
            bool InputStock = (TotalStockTextBox.Text == "");
            bool InputNumBorrowed = (NumBorrowedTextBox.Text == "");
            bool InputLocation = (LocationTextBox.Text == "");
            bool InputPublisher = (PublisherTextBox.Text == "");
            bool SelectCategory = (BookCategoryComboBox.SelectedItem == null);


            if (InputID || InputName || InputAuthor || InputPubYear || InputEdiNumber ||
                InputStock || InputNumBorrowed || InputLocation || InputPublisher || SelectCategory)
            {
                MessageBox.Show("There are blank(s).");
            }
            else
            {

                bool IDexist = false;
                for (int i = 0; i < ds.Tables["Books"].Rows.Count; i++)
                {
                    if (BookIDTextBox.Text == ds.Tables["Books"].Rows[i]["BookID"].ToString())
                    {
                        IDexist = true;
                        break;
                    }
                }
                if (IDexist)
                {
                    ds.Tables["Books"].Rows[posnBooks]["BookName"] = BookNameTextBox.Text;
                    ds.Tables["Books"].Rows[posnBooks]["Author"] = AuthorTextBox.Text;
                    ds.Tables["Books"].Rows[posnBooks]["PublishingYear"] = PubYearTextBox.Text;
                    ds.Tables["Books"].Rows[posnBooks]["Edition"] = EdiNumberTextBox.Text;
                    ds.Tables["Books"].Rows[posnBooks]["TotalStock"] = TotalStockTextBox.Text;
                    ds.Tables["Books"].Rows[posnBooks]["NumberBorrowed"] = NumBorrowedTextBox.Text;
                    ds.Tables["Books"].Rows[posnBooks]["BookCategoryID"] = BookCategoryComboBox.SelectedItem;
                    bool nameExist = false;
                    for (int i = 0; i < ds.Tables["Publishers"].Rows.Count; i++)
                    {
                        if (PublisherTextBox.Text == ds.Tables["Publishers"].Rows[i]["PublisherName"].ToString())
                        {
                            nameExist = true;
                        }
                    }
                    if (nameExist)
                    {
                        ds.Tables["Books"].Rows[posnBooks]["PublisherID"] = PublisherTextBox.Text.Substring(0, 3).ToUpper();
                        daBooks.Update(ds, "Books");
                        MessageBox.Show("Updated!! ");
                    }
                    else
                    {
                        PublishersDr = ds.Tables["Publishers"].NewRow();
                        PublishersDr["PublisherID"] = PublisherTextBox.Text.Substring(0, 3).ToUpper();
                        PublishersDr["PublisherName"] = PublisherTextBox.Text;
                        ds.Tables["Publishers"].Rows.Add(PublishersDr);
                        daBooks.Update(ds, "Books");
                        daPublishers.Update(ds, "Publishers");
                        MessageBox.Show("Updated!! ");
                    }
                }
                else
                {
                    MessageBox.Show("Cannot find this book!");
                    return;
                }
            }
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            daBooks.Fill(ds, "Books");
            daPublishers.Fill(ds, "Publishers");
            daBookCategories.Fill(ds, "BookCategories");
            posnBooks = 0;
            Display();
        }

        private void Lastbutton_Click(object sender, EventArgs e)
        {
            daBooks.Fill(ds, "Books");
            daPublishers.Fill(ds, "Publishers");
            daBookCategories.Fill(ds, "BookCategories");
            posnBooks = ds.Tables["Books"].Rows.Count - 1;
            Display();
        }

        private void PriorButton_Click(object sender, EventArgs e)
        {
            if (posnBooks > 0)
            {
                posnBooks--;
                Display();
            }
            else if (BookIDTextBox.Text == "")
            {
                MessageBox.Show("Please load first.");
            }
            else if (posnBooks==0)
            {
                MessageBox.Show("This is the first record already.");
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            daBooks.Fill(ds, "Books");
            daPublishers.Fill(ds, "Publishers");
            daBookCategories.Fill(ds, "BookCategories");
            if (BookIDTextBox.Text=="")
            {
                MessageBox.Show("Please load first.");
            }
            else
            {
                posnBooks++;
                Display();
            }
           
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            daIssueTran.Fill(ds, "IssueTran");
            bool IDexistsBooks = false;
            bool IDexistsIssueTran = false;
            for (int i = 0; i < ds.Tables["Books"].Rows.Count; i++)
            {
                if (BookIDTextBox.Text == ds.Tables["Books"].Rows[i]["BookID"].ToString())
                {
                    IDexistsBooks = true;
                    break;
                }
            }

            for (int i = 0; i < ds.Tables["IssueTran"].Rows.Count; i++)
            {
                if (BookIDTextBox.Text == ds.Tables["IssueTran"].Rows[i]["BookID"].ToString())
                {
                    IDexistsIssueTran = true;
                    break;
                }
            }
            if (IDexistsBooks && (!IDexistsIssueTran))
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete?",
                "Confirm delete", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    ds.Tables["Books"].Rows[posnBooks].Delete();
                    daBooks.Update(ds, "Books");
                    MessageBox.Show("Already deleted!");
                }
            }
            else if (!IDexistsBooks)
            {
                MessageBox.Show("Cannot find this book.");
            }
            else if (IDexistsIssueTran)
            {
                MessageBox.Show("This book has been borrowed, so you cannot delete it now!");
            }

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            daBooks.Fill(ds, "Books");
            daPublishers.Fill(ds, "Publishers");
            daBookCategories.Fill(ds, "BookCategories");

            BookIDTextBox.Text = "";
            BookNameTextBox.Text = "";
            AuthorTextBox.Text = "";
            PubYearTextBox.Text = "";
            EdiNumberTextBox.Text = "";
            TotalStockTextBox.Text = "";
            NumBorrowedTextBox.Text = "";
            BookCategoryComboBox.SelectedItem = "";
            LocationTextBox.Text = "";
            PublisherTextBox.Text = "";
            FindToolStripStatusLabel.Text = "";

            int i;
            for (i = 0; i < ds.Tables["Books"].Rows.Count; i++)
            {
                if (ds.Tables["Books"].Rows[i]["BookID"].ToString() == FindTextBox.Text.Trim())
                {
                    posnBooks = i;
                    break;
                }
            }
            if (i < ds.Tables["Books"].Rows.Count)
            {
                Display();
            }
            else
            {
                MessageBox.Show("This book can not be found!");
                FindToolStripStatusLabel.Text = "This book can not be found!";
            }
                
        }

        private void BookCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            daBookCategories.Fill(ds, "BookCategories");
            for (int i = 0; i < ds.Tables["BookCategories"].Rows.Count; i++)
            {
                if (ds.Tables["BookCategories"].Rows[i]["BookCategoryID"].ToString() == BookCategoryComboBox.SelectedItem.ToString())
                {
                    posnBookCategories = i;
                    break;
                }
            }
            LocationTextBox.Text = ds.Tables["BookCategories"].Rows[posnBookCategories]["Location"].ToString();
        }

        private void FindTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void BookIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //BookIDTextBox.ReadOnly=true;
        }

        private void EdiNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TotalStockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumBorrowedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PubYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BookNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void AuthorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void PublisherTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
