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
    public partial class FormSearch : Form
    {
        public static string AuthorName;

        SA47Team11aLibraryDS ds; // books
        SA47Team11aLibraryDSTableAdapters.BooksTableAdapter ta;
        SA47Team11aLibraryDS ds2; // publishers
        SA47Team11aLibraryDSTableAdapters.PublishersTableAdapter ta2;
        SA47Team11aLibraryDS ds3; // book categories
        SA47Team11aLibraryDSTableAdapters.BookCategoriesTableAdapter ta3;
        int currentIndex;
        string CurrentBookCatID;
        bool correctTyping = true;
        

        public FormSearch()
        {
            InitializeComponent();
        }

        public void fillTextboxes()
        {
            BookIDTextBox.Text = ds.Tables["Books"].Rows[currentIndex]["BookID"].ToString();
            BookNameTextBox.Text = ds.Tables["Books"].Rows[currentIndex]["BookName"].ToString();
            AuthorTextBox.Text = ds.Tables["Books"].Rows[currentIndex]["Author"].ToString();
            string publisherID = ds.Tables["Books"].Rows[currentIndex]["PublisherID"].ToString();
            PublisherTextBox.Text = ds2.Publishers.FindByPublisherID(publisherID).PublisherName.ToString();
            string bookCatID = ds.Tables["Books"].Rows[currentIndex]["BookCategoryID"].ToString();
            LocationTextBox.Text = ds3.BookCategories.FindByBookCategoryID(bookCatID).Location.ToString();
            int borrowed = (int)ds.Tables["Books"].Rows[currentIndex]["NumberBorrowed"];
            int totalStock = (int)ds.Tables["Books"].Rows[currentIndex]["TotalStock"];
            NumAvaTextBox.Text = (totalStock - borrowed).ToString();
            NumBorrowedTextBox.Text = ds.Tables["Books"].Rows[currentIndex]["NumberBorrowed"].ToString();
        }
        private void FormSearch_Load(object sender, EventArgs e)
        {
            ds = new SA47Team11aLibraryDS();
            ta = new SA47Team11aLibraryDSTableAdapters.BooksTableAdapter();
            ta.Fill(ds.Books);
            ds2 = new SA47Team11aLibraryDS();
            ta2 = new SA47Team11aLibraryDSTableAdapters.PublishersTableAdapter();
            ta2.Fill(ds2.Publishers);
            ds3 = new SA47Team11aLibraryDS();
            ta3 = new SA47Team11aLibraryDSTableAdapters.BookCategoriesTableAdapter();
            ta3.Fill(ds3.BookCategories);
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            subjectBooksComboBox.Items.Clear();
            subjectBooksLabel.Visible = false;
            subjectBooksComboBox.Visible = false;
            

            if (SearchBycomboBox.SelectedItem == SearchBycomboBox.Items[0]) // Search By Title
            {
                for (int i = 0; i < ds.Tables["Books"].Rows.Count; i++)
                {
                    if (ds.Tables["Books"].Rows[i]["BookName"].ToString().ToLower() == SearchTextBox.Text.ToLower())
                    {
                        currentIndex = i;
                        fillTextboxes();
                        break;
                    }
                    else
                    {
                        currentIndex = 0;
                    }
                }
                if (currentIndex== 0)
                {
                    MessageBox.Show("This book does not exist in the database!");
                }
            }
            else if (SearchBycomboBox.SelectedItem == SearchBycomboBox.Items[1]) // Search By Author
            {
                for (int i = 0; i < ds.Tables["Books"].Rows.Count; i++)
                {
                    if (ds.Tables["Books"].Rows[i]["Author"].ToString().ToLower() == SearchTextBox.Text.ToLower())
                    {

                        AuthorName = SearchTextBox.Text;
                        AuthorSearchForm a = new AuthorSearchForm(AuthorName);

                        if (a.ShowDialog() == DialogResult.OK)
                        {
                            for (int j = 0; j < ds.Tables["Books"].Rows.Count;j++)
                            {
                                if (ds.Tables["Books"].Rows[j]["BookID"].ToString() == a.AuthorBook)
                                {
                                    currentIndex = j;
                                    fillTextboxes();
                                    break;
                                }
                            }
                        }
                        break;

                    }
                    else
                    {
                        currentIndex = 0;
                    }
                }
                if (currentIndex == 0)
                {
                    MessageBox.Show("This author does not exist in the database!");
                }
            }
            else
            {
                MessageBox.Show("Nothing has been entered!");
            }
            SearchTextBox.Clear();
        }
        private void SearchBycomboBox_SelectedIndexChanged(object sender, EventArgs e) // Search by Subject
        {
            SearchTextBox.ReadOnly = false;
            SearchTextBox.Clear();

            if (SearchBycomboBox.SelectedIndex == 2)
            {
                SearchTextBox.Clear();
                subjectsComboBox.Visible = true;
                SearchTextBox.ReadOnly = true;
               
            }
            else
            {
                subjectsComboBox.Visible = false;
                SearchTextBox.ReadOnly = false;
                subjectBooksLabel.Visible = false;
                subjectBooksComboBox.Visible = false;
            }
        }
        private void subjectBooksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < ds.Tables["Books"].Rows.Count; i++) // get selected book in combo box
            {
                if (ds.Tables["Books"].Rows[i]["BookName"] == subjectBooksComboBox.SelectedItem)
                {
                    currentIndex = i;
                    fillTextboxes();
                    break;
                }
            }
        }
        private void subjectsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectBooksComboBox.Items.Clear();
            subjectBooksLabel.Text = subjectsComboBox.SelectedItem.ToString() + " Book List";
            subjectBooksLabel.Visible = true;
            subjectBooksComboBox.Visible = true;
            
            for (int j = 0; j < ds3.Tables["BookCategories"].Rows.Count; j++)
            {
                if (ds3.Tables["BookCategories"].Rows[j]["Subject"].ToString() == subjectsComboBox.SelectedItem.ToString())
                {
                    CurrentBookCatID = ds3.Tables["BookCategories"].Rows[j]["BookCategoryID"].ToString();
                    break;
                }
            }
            for (int i = 0; i < ds.Tables["Books"].Rows.Count; i++) // fill Subject Combo Box
            {
                if (ds.Tables["Books"].Rows[i]["BookCategoryID"].ToString() == CurrentBookCatID)
                {
                    subjectBooksComboBox.Items.Add(ds.Tables["Books"].Rows[i]["BookName"]);
                }
            }
        }
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((SearchBycomboBox.SelectedItem == SearchBycomboBox.Items[0])) // typing check for Book Titles
            {
                if ((e.KeyCode == Keys.A) || (e.KeyCode == Keys.B) || (e.KeyCode == Keys.C)
                   || (e.KeyCode == Keys.D) || (e.KeyCode == Keys.E) || (e.KeyCode == Keys.F)
                   || (e.KeyCode == Keys.G) || (e.KeyCode == Keys.H) || (e.KeyCode == Keys.I)
                   || (e.KeyCode == Keys.J) || (e.KeyCode == Keys.K) || (e.KeyCode == Keys.L)
                   || (e.KeyCode == Keys.M) || (e.KeyCode == Keys.N) || (e.KeyCode == Keys.O)
                   || (e.KeyCode == Keys.P) || (e.KeyCode == Keys.Q) || (e.KeyCode == Keys.R)
                   || (e.KeyCode == Keys.S) || (e.KeyCode == Keys.T) || (e.KeyCode == Keys.U)
                   || (e.KeyCode == Keys.V) || (e.KeyCode == Keys.W) || (e.KeyCode == Keys.X)
                   || (e.KeyCode == Keys.Y) || (e.KeyCode == Keys.Z) || (e.KeyCode == Keys.Space)
                   || (e.KeyCode == Keys.Back) || (e.KeyCode == Keys.ShiftKey) || (e.KeyCode == Keys.OemSemicolon))
                {
                    correctTyping = true;
                }
                else
                {
                    correctTyping = false;
                }
            }
            if (SearchBycomboBox.SelectedItem == SearchBycomboBox.Items[1]) // Typing Check for Authors
            {
                if ((e.KeyCode == Keys.A) || (e.KeyCode == Keys.B) || (e.KeyCode == Keys.C)
                   || (e.KeyCode == Keys.D) || (e.KeyCode == Keys.E) || (e.KeyCode == Keys.F)
                   || (e.KeyCode == Keys.G) || (e.KeyCode == Keys.H) || (e.KeyCode == Keys.I)
                   || (e.KeyCode == Keys.J) || (e.KeyCode == Keys.K) || (e.KeyCode == Keys.L)
                   || (e.KeyCode == Keys.M) || (e.KeyCode == Keys.N) || (e.KeyCode == Keys.O)
                   || (e.KeyCode == Keys.P) || (e.KeyCode == Keys.Q) || (e.KeyCode == Keys.R)
                   || (e.KeyCode == Keys.S) || (e.KeyCode == Keys.T) || (e.KeyCode == Keys.U)
                   || (e.KeyCode == Keys.V) || (e.KeyCode == Keys.W) || (e.KeyCode == Keys.X)
                   || (e.KeyCode == Keys.Y) || (e.KeyCode == Keys.Z) || (e.KeyCode == Keys.Space)
                   || (e.KeyCode == Keys.Back) || (e.KeyCode == Keys.ShiftKey))
                {
                    correctTyping = true;
                }
                else
                {
                    correctTyping = false;
                }
            }
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (correctTyping == false)
            {
                e.Handled = true;
            }
        }

        private void AllBooksButton_Click(object sender, EventArgs e)
        {
            AllBooksForm f = new AllBooksForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ds.Tables["Books"].Rows.Count; i++)
                {
                    if (ds.Tables["Books"].Rows[i]["BookName"].ToString() == f.BookName)
                    {
                        currentIndex = i;
                        fillTextboxes();
                        break;
                    }
                }
            }
        }
    }
}
