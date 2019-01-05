namespace SA47_Team11a_library
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SearchBycomboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subjectBooksLabel = new System.Windows.Forms.Label();
            this.subjectBooksComboBox = new System.Windows.Forms.ComboBox();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.NumBorrowedTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.NumAvaTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.NumAvaLabel = new System.Windows.Forms.Label();
            this.NumBorrowedLabel = new System.Windows.Forms.Label();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.subjectsComboBox = new System.Windows.Forms.ComboBox();
            this.AllBooksButton = new System.Windows.Forms.Button();
            this.AllBooksButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchByToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(831, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 24);
            this.label.TabIndex = 3;
            this.label.Text = "Hello ";
            this.label.Visible = false;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(943, 24);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 5;
            this.LogoutButton.Text = "logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            // 
            // SearchBycomboBox
            // 
            this.SearchBycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchBycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBycomboBox.FormattingEnabled = true;
            this.SearchBycomboBox.Items.AddRange(new object[] {
            "Title ",
            "Author ",
            "Subject"});
            this.SearchBycomboBox.Location = new System.Drawing.Point(88, 62);
            this.SearchBycomboBox.Name = "SearchBycomboBox";
            this.SearchBycomboBox.Size = new System.Drawing.Size(108, 24);
            this.SearchBycomboBox.TabIndex = 6;
            this.SearchBycomboBox.SelectedIndexChanged += new System.EventHandler(this.SearchBycomboBox_SelectedIndexChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(595, 62);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 21);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchByToolTip.SetToolTip(this.SearchButton, "Please select an item from the \'Search By\' dropdown");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subjectBooksLabel);
            this.groupBox1.Controls.Add(this.subjectBooksComboBox);
            this.groupBox1.Controls.Add(this.BookIDTextBox);
            this.groupBox1.Controls.Add(this.BookIDLabel);
            this.groupBox1.Controls.Add(this.NumBorrowedTextBox);
            this.groupBox1.Controls.Add(this.AuthorTextBox);
            this.groupBox1.Controls.Add(this.PublisherTextBox);
            this.groupBox1.Controls.Add(this.LocationTextBox);
            this.groupBox1.Controls.Add(this.NumAvaTextBox);
            this.groupBox1.Controls.Add(this.BookNameTextBox);
            this.groupBox1.Controls.Add(this.AuthorLabel);
            this.groupBox1.Controls.Add(this.PublisherLabel);
            this.groupBox1.Controls.Add(this.LocationLabel);
            this.groupBox1.Controls.Add(this.NumAvaLabel);
            this.groupBox1.Controls.Add(this.NumBorrowedLabel);
            this.groupBox1.Controls.Add(this.BookNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(14, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 391);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Results";
            // 
            // subjectBooksLabel
            // 
            this.subjectBooksLabel.AutoSize = true;
            this.subjectBooksLabel.Location = new System.Drawing.Point(578, 22);
            this.subjectBooksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subjectBooksLabel.Name = "subjectBooksLabel";
            this.subjectBooksLabel.Size = new System.Drawing.Size(107, 12);
            this.subjectBooksLabel.TabIndex = 17;
            this.subjectBooksLabel.Text = "subjectBooksLabel";
            this.subjectBooksLabel.Visible = false;
            // 
            // subjectBooksComboBox
            // 
            this.subjectBooksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectBooksComboBox.FormattingEnabled = true;
            this.subjectBooksComboBox.Location = new System.Drawing.Point(710, 20);
            this.subjectBooksComboBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.subjectBooksComboBox.Name = "subjectBooksComboBox";
            this.subjectBooksComboBox.Size = new System.Drawing.Size(214, 20);
            this.subjectBooksComboBox.TabIndex = 16;
            this.subjectBooksComboBox.Visible = false;
            this.subjectBooksComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectBooksComboBox_SelectedIndexChanged);
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.Location = new System.Drawing.Point(240, 37);
            this.BookIDTextBox.Multiline = true;
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.ReadOnly = true;
            this.BookIDTextBox.Size = new System.Drawing.Size(75, 22);
            this.BookIDTextBox.TabIndex = 15;
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDLabel.Location = new System.Drawing.Point(26, 38);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(70, 21);
            this.BookIDLabel.TabIndex = 14;
            this.BookIDLabel.Text = "Book ID";
            // 
            // NumBorrowedTextBox
            // 
            this.NumBorrowedTextBox.Location = new System.Drawing.Point(240, 263);
            this.NumBorrowedTextBox.Multiline = true;
            this.NumBorrowedTextBox.Name = "NumBorrowedTextBox";
            this.NumBorrowedTextBox.ReadOnly = true;
            this.NumBorrowedTextBox.Size = new System.Drawing.Size(75, 22);
            this.NumBorrowedTextBox.TabIndex = 13;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(240, 108);
            this.AuthorTextBox.Multiline = true;
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.ReadOnly = true;
            this.AuthorTextBox.Size = new System.Drawing.Size(281, 22);
            this.AuthorTextBox.TabIndex = 12;
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(240, 147);
            this.PublisherTextBox.Multiline = true;
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.ReadOnly = true;
            this.PublisherTextBox.Size = new System.Drawing.Size(281, 22);
            this.PublisherTextBox.TabIndex = 11;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(240, 186);
            this.LocationTextBox.Multiline = true;
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(281, 22);
            this.LocationTextBox.TabIndex = 10;
            // 
            // NumAvaTextBox
            // 
            this.NumAvaTextBox.Location = new System.Drawing.Point(240, 224);
            this.NumAvaTextBox.Multiline = true;
            this.NumAvaTextBox.Name = "NumAvaTextBox";
            this.NumAvaTextBox.ReadOnly = true;
            this.NumAvaTextBox.Size = new System.Drawing.Size(75, 22);
            this.NumAvaTextBox.TabIndex = 9;
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(240, 69);
            this.BookNameTextBox.Multiline = true;
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.ReadOnly = true;
            this.BookNameTextBox.Size = new System.Drawing.Size(281, 22);
            this.BookNameTextBox.TabIndex = 8;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(26, 111);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(70, 21);
            this.AuthorLabel.TabIndex = 6;
            this.AuthorLabel.Text = "Author";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublisherLabel.Location = new System.Drawing.Point(26, 150);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(70, 21);
            this.PublisherLabel.TabIndex = 5;
            this.PublisherLabel.Text = "Publisher";
            // 
            // LocationLabel
            // 
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(26, 188);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(70, 21);
            this.LocationLabel.TabIndex = 4;
            this.LocationLabel.Text = "Location";
            // 
            // NumAvaLabel
            // 
            this.NumAvaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumAvaLabel.Location = new System.Drawing.Point(26, 227);
            this.NumAvaLabel.Name = "NumAvaLabel";
            this.NumAvaLabel.Size = new System.Drawing.Size(102, 21);
            this.NumAvaLabel.TabIndex = 3;
            this.NumAvaLabel.Text = "Number Available";
            // 
            // NumBorrowedLabel
            // 
            this.NumBorrowedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBorrowedLabel.Location = new System.Drawing.Point(26, 266);
            this.NumBorrowedLabel.Name = "NumBorrowedLabel";
            this.NumBorrowedLabel.Size = new System.Drawing.Size(102, 21);
            this.NumBorrowedLabel.TabIndex = 2;
            this.NumBorrowedLabel.Text = "Number Borrowed";
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameLabel.Location = new System.Drawing.Point(26, 72);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(70, 21);
            this.BookNameLabel.TabIndex = 1;
            this.BookNameLabel.Text = "Book Name";
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByLabel.Location = new System.Drawing.Point(12, 61);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(70, 21);
            this.SearchByLabel.TabIndex = 0;
            this.SearchByLabel.Text = "Search by";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(256, 63);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.ReadOnly = true;
            this.SearchTextBox.Size = new System.Drawing.Size(281, 22);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // subjectsComboBox
            // 
            this.subjectsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsComboBox.FormattingEnabled = true;
            this.subjectsComboBox.Items.AddRange(new object[] {
            "Children\'s",
            "Cookbooks",
            "Diaries",
            "Encyclopedias",
            "Guide",
            "Health",
            "History",
            "Horror",
            "Journals",
            "Math",
            "Mystery",
            "Poetry",
            "Prayer books",
            "Romance",
            "Science ",
            "Self help",
            "Series",
            "Travel"});
            this.subjectsComboBox.Location = new System.Drawing.Point(254, 88);
            this.subjectsComboBox.Name = "subjectsComboBox";
            this.subjectsComboBox.Size = new System.Drawing.Size(284, 24);
            this.subjectsComboBox.TabIndex = 46;
            this.subjectsComboBox.Visible = false;
            this.subjectsComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectsComboBox_SelectedIndexChanged);
            // 
            // AllBooksButton
            // 
            this.AllBooksButton.Location = new System.Drawing.Point(595, 85);
            this.AllBooksButton.Name = "AllBooksButton";
            this.AllBooksButton.Size = new System.Drawing.Size(75, 21);
            this.AllBooksButton.TabIndex = 47;
            this.AllBooksButton.Text = "...";
            this.AllBooksButtonToolTip.SetToolTip(this.AllBooksButton, "Click here to Display All Books");
            this.AllBooksButton.UseVisualStyleBackColor = true;
            this.AllBooksButton.Click += new System.EventHandler(this.AllBooksButton_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 423);
            this.Controls.Add(this.AllBooksButton);
            this.Controls.Add(this.subjectsComboBox);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchBycomboBox);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label);
            this.Name = "FormSearch";
            this.Text = "Search Book";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.ComboBox SearchBycomboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NumBorrowedTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox NumAvaTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label NumAvaLabel;
        private System.Windows.Forms.Label NumBorrowedLabel;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TextBox BookIDTextBox;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.ComboBox subjectBooksComboBox;
        private System.Windows.Forms.Label subjectBooksLabel;
        private System.Windows.Forms.ComboBox subjectsComboBox;
        private System.Windows.Forms.Button AllBooksButton;
        private System.Windows.Forms.ToolTip AllBooksButtonToolTip;
        private System.Windows.Forms.ToolTip SearchByToolTip;
    }
}

