namespace SA47_Team11a_library
{
    partial class MaintainBooksInfoForm
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
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PriorButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.Lastbutton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.AuthorGroupBox = new System.Windows.Forms.GroupBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.EdiNumberTextBox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.BookCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NumBorrowedTextBox = new System.Windows.Forms.TextBox();
            this.TotalStockTextBox = new System.Windows.Forms.TextBox();
            this.PubYearTextBox = new System.Windows.Forms.TextBox();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.BookNameTextBox = new System.Windows.Forms.TextBox();
            this.BookIDTextBox = new System.Windows.Forms.TextBox();
            this.NumBorrowedLabel = new System.Windows.Forms.Label();
            this.TotalStockLabel = new System.Windows.Forms.Label();
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.BookCategoryLabel = new System.Windows.Forms.Label();
            this.EdiNumberLabel = new System.Windows.Forms.Label();
            this.PubDateLabel = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.FindToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FindToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AuthorGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(238, 49);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(100, 21);
            this.FindTextBox.TabIndex = 1;
            this.FindToolTip.SetToolTip(this.FindTextBox, "Input Book ID to find.");
            this.FindTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FindTextBox_KeyPress);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(388, 46);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 21);
            this.FindButton.TabIndex = 12;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(713, 171);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 21);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(713, 230);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 21);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(713, 296);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 21);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PriorButton
            // 
            this.PriorButton.Location = new System.Drawing.Point(238, 350);
            this.PriorButton.Name = "PriorButton";
            this.PriorButton.Size = new System.Drawing.Size(75, 21);
            this.PriorButton.TabIndex = 37;
            this.PriorButton.Text = "Prior";
            this.PriorButton.UseVisualStyleBackColor = true;
            this.PriorButton.Click += new System.EventHandler(this.PriorButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(432, 350);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 21);
            this.NextButton.TabIndex = 38;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Lastbutton
            // 
            this.Lastbutton.Location = new System.Drawing.Point(619, 350);
            this.Lastbutton.Name = "Lastbutton";
            this.Lastbutton.Size = new System.Drawing.Size(75, 21);
            this.Lastbutton.TabIndex = 39;
            this.Lastbutton.Text = "Last";
            this.Lastbutton.UseVisualStyleBackColor = true;
            this.Lastbutton.Click += new System.EventHandler(this.Lastbutton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(51, 350);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(75, 21);
            this.FirstButton.TabIndex = 40;
            this.FirstButton.Text = "First ";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // AuthorGroupBox
            // 
            this.AuthorGroupBox.Controls.Add(this.LocationTextBox);
            this.AuthorGroupBox.Controls.Add(this.EdiNumberTextBox);
            this.AuthorGroupBox.Controls.Add(this.LocationLabel);
            this.AuthorGroupBox.Controls.Add(this.BookCategoryComboBox);
            this.AuthorGroupBox.Controls.Add(this.NumBorrowedTextBox);
            this.AuthorGroupBox.Controls.Add(this.TotalStockTextBox);
            this.AuthorGroupBox.Controls.Add(this.PubYearTextBox);
            this.AuthorGroupBox.Controls.Add(this.PublisherTextBox);
            this.AuthorGroupBox.Controls.Add(this.AuthorTextBox);
            this.AuthorGroupBox.Controls.Add(this.BookNameTextBox);
            this.AuthorGroupBox.Controls.Add(this.BookIDTextBox);
            this.AuthorGroupBox.Controls.Add(this.NumBorrowedLabel);
            this.AuthorGroupBox.Controls.Add(this.TotalStockLabel);
            this.AuthorGroupBox.Controls.Add(this.BookNameLabel);
            this.AuthorGroupBox.Controls.Add(this.AuthorLabel);
            this.AuthorGroupBox.Controls.Add(this.PublisherLabel);
            this.AuthorGroupBox.Controls.Add(this.BookCategoryLabel);
            this.AuthorGroupBox.Controls.Add(this.EdiNumberLabel);
            this.AuthorGroupBox.Controls.Add(this.PubDateLabel);
            this.AuthorGroupBox.Controls.Add(this.BookIDLabel);
            this.AuthorGroupBox.Location = new System.Drawing.Point(15, 86);
            this.AuthorGroupBox.Name = "AuthorGroupBox";
            this.AuthorGroupBox.Size = new System.Drawing.Size(657, 232);
            this.AuthorGroupBox.TabIndex = 41;
            this.AuthorGroupBox.TabStop = false;
            this.AuthorGroupBox.Text = "Book Info Details";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(433, 187);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(100, 21);
            this.LocationTextBox.TabIndex = 78;
            // 
            // EdiNumberTextBox
            // 
            this.EdiNumberTextBox.Location = new System.Drawing.Point(573, 90);
            this.EdiNumberTextBox.Name = "EdiNumberTextBox";
            this.EdiNumberTextBox.Size = new System.Drawing.Size(66, 21);
            this.EdiNumberTextBox.TabIndex = 76;
            this.EdiNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdiNumberTextBox_KeyPress);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(320, 190);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(53, 12);
            this.LocationLabel.TabIndex = 77;
            this.LocationLabel.Text = "Location";
            // 
            // BookCategoryComboBox
            // 
            this.BookCategoryComboBox.FormattingEnabled = true;
            this.BookCategoryComboBox.Items.AddRange(new object[] {
            "SCI",
            "ROM",
            "MYS",
            "HOR",
            "SEL",
            "HEA",
            "GUI",
            "TRA",
            "CHI",
            "HIS",
            "MAT",
            "POE",
            "ENC",
            "COO",
            "DIA",
            "JOU",
            "PRA",
            "SER",
            ""});
            this.BookCategoryComboBox.Location = new System.Drawing.Point(122, 186);
            this.BookCategoryComboBox.Name = "BookCategoryComboBox";
            this.BookCategoryComboBox.Size = new System.Drawing.Size(130, 20);
            this.BookCategoryComboBox.TabIndex = 75;
            this.BookCategoryComboBox.Text = "Choose the CategoryID";
            this.BookCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.BookCategoryComboBox_SelectedIndexChanged);
            // 
            // NumBorrowedTextBox
            // 
            this.NumBorrowedTextBox.Location = new System.Drawing.Point(426, 135);
            this.NumBorrowedTextBox.Name = "NumBorrowedTextBox";
            this.NumBorrowedTextBox.Size = new System.Drawing.Size(66, 21);
            this.NumBorrowedTextBox.TabIndex = 74;
            this.NumBorrowedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumBorrowedTextBox_KeyPress);
            // 
            // TotalStockTextBox
            // 
            this.TotalStockTextBox.Location = new System.Drawing.Point(114, 135);
            this.TotalStockTextBox.Name = "TotalStockTextBox";
            this.TotalStockTextBox.Size = new System.Drawing.Size(100, 21);
            this.TotalStockTextBox.TabIndex = 73;
            this.TotalStockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TotalStockTextBox_KeyPress);
            // 
            // PubYearTextBox
            // 
            this.PubYearTextBox.Location = new System.Drawing.Point(315, 88);
            this.PubYearTextBox.Name = "PubYearTextBox";
            this.PubYearTextBox.Size = new System.Drawing.Size(100, 21);
            this.PubYearTextBox.TabIndex = 71;
            this.PubYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PubYearTextBox_KeyPress);
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(81, 88);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(100, 21);
            this.PublisherTextBox.TabIndex = 70;
            this.PublisherTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PublisherTextBox_KeyPress);
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(543, 33);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(96, 21);
            this.AuthorTextBox.TabIndex = 69;
            this.AuthorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AuthorTextBox_KeyPress);
            // 
            // BookNameTextBox
            // 
            this.BookNameTextBox.Location = new System.Drawing.Point(315, 34);
            this.BookNameTextBox.Name = "BookNameTextBox";
            this.BookNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.BookNameTextBox.TabIndex = 68;
            this.BookNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookNameTextBox_KeyPress);
            // 
            // BookIDTextBox
            // 
            this.BookIDTextBox.Location = new System.Drawing.Point(81, 30);
            this.BookIDTextBox.Name = "BookIDTextBox";
            this.BookIDTextBox.Size = new System.Drawing.Size(100, 21);
            this.BookIDTextBox.TabIndex = 67;
            this.BookIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookIDTextBox_KeyPress);
            // 
            // NumBorrowedLabel
            // 
            this.NumBorrowedLabel.AutoSize = true;
            this.NumBorrowedLabel.Location = new System.Drawing.Point(307, 141);
            this.NumBorrowedLabel.Name = "NumBorrowedLabel";
            this.NumBorrowedLabel.Size = new System.Drawing.Size(95, 12);
            this.NumBorrowedLabel.TabIndex = 65;
            this.NumBorrowedLabel.Text = "Number Borrowed";
            // 
            // TotalStockLabel
            // 
            this.TotalStockLabel.AutoSize = true;
            this.TotalStockLabel.Location = new System.Drawing.Point(2, 141);
            this.TotalStockLabel.Name = "TotalStockLabel";
            this.TotalStockLabel.Size = new System.Drawing.Size(71, 12);
            this.TotalStockLabel.TabIndex = 64;
            this.TotalStockLabel.Text = "Total Stock";
            // 
            // BookNameLabel
            // 
            this.BookNameLabel.AutoSize = true;
            this.BookNameLabel.Location = new System.Drawing.Point(203, 33);
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Size = new System.Drawing.Size(59, 12);
            this.BookNameLabel.TabIndex = 63;
            this.BookNameLabel.Text = "Book Name";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(454, 37);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 12);
            this.AuthorLabel.TabIndex = 62;
            this.AuthorLabel.Text = "Author";
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Location = new System.Drawing.Point(4, 90);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(59, 12);
            this.PublisherLabel.TabIndex = 61;
            this.PublisherLabel.Text = "Publisher";
            // 
            // BookCategoryLabel
            // 
            this.BookCategoryLabel.AutoSize = true;
            this.BookCategoryLabel.Location = new System.Drawing.Point(4, 189);
            this.BookCategoryLabel.Name = "BookCategoryLabel";
            this.BookCategoryLabel.Size = new System.Drawing.Size(95, 12);
            this.BookCategoryLabel.TabIndex = 60;
            this.BookCategoryLabel.Text = "Book CategoryID";
            // 
            // EdiNumberLabel
            // 
            this.EdiNumberLabel.AutoSize = true;
            this.EdiNumberLabel.Location = new System.Drawing.Point(454, 90);
            this.EdiNumberLabel.Name = "EdiNumberLabel";
            this.EdiNumberLabel.Size = new System.Drawing.Size(89, 12);
            this.EdiNumberLabel.TabIndex = 59;
            this.EdiNumberLabel.Text = "Edition Number";
            // 
            // PubDateLabel
            // 
            this.PubDateLabel.AutoSize = true;
            this.PubDateLabel.Location = new System.Drawing.Point(203, 90);
            this.PubDateLabel.Name = "PubDateLabel";
            this.PubDateLabel.Size = new System.Drawing.Size(95, 12);
            this.PubDateLabel.TabIndex = 58;
            this.PubDateLabel.Text = "Publishing Year";
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.Location = new System.Drawing.Point(4, 33);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(47, 12);
            this.BookIDLabel.TabIndex = 57;
            this.BookIDLabel.Text = "Book ID";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(713, 117);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 21);
            this.LoadButton.TabIndex = 42;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindToolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(820, 22);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FindToolStripStatusLabel
            // 
            this.FindToolStripStatusLabel.Name = "FindToolStripStatusLabel";
            this.FindToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FindToolTip
            // 
            this.FindToolTip.AutoPopDelay = 1000;
            this.FindToolTip.InitialDelay = 500;
            this.FindToolTip.ReshowDelay = 100;
            this.FindToolTip.ToolTipTitle = "Test Tooltip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "BookID";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // MaintainBooksInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.AuthorGroupBox);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.Lastbutton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PriorButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FindTextBox);
            this.Name = "MaintainBooksInfoForm";
            this.Text = "Maintain Books Info";
            this.Load += new System.EventHandler(this.MaintainBooksInfoForm_Load);
            this.AuthorGroupBox.ResumeLayout(false);
            this.AuthorGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button PriorButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button Lastbutton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.GroupBox AuthorGroupBox;
        private System.Windows.Forms.TextBox EdiNumberTextBox;
        private System.Windows.Forms.ComboBox BookCategoryComboBox;
        private System.Windows.Forms.TextBox NumBorrowedTextBox;
        private System.Windows.Forms.TextBox TotalStockTextBox;
        private System.Windows.Forms.TextBox PubYearTextBox;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox BookNameTextBox;
        private System.Windows.Forms.TextBox BookIDTextBox;
        private System.Windows.Forms.Label NumBorrowedLabel;
        private System.Windows.Forms.Label TotalStockLabel;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label PublisherLabel;
        private System.Windows.Forms.Label BookCategoryLabel;
        private System.Windows.Forms.Label EdiNumberLabel;
        private System.Windows.Forms.Label PubDateLabel;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel FindToolStripStatusLabel;
        private System.Windows.Forms.ToolTip FindToolTip;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}