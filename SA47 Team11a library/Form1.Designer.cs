namespace SA47_Team11a_library
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAvailabilityDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBorrowingRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossToTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.memberToolStripMenuItem,
            this.trasactionToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchBookToolStripMenuItem,
            this.searchAvailabilityDateToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // searchAvailabilityDateToolStripMenuItem
            // 
            this.searchAvailabilityDateToolStripMenuItem.Name = "searchAvailabilityDateToolStripMenuItem";
            this.searchAvailabilityDateToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.searchAvailabilityDateToolStripMenuItem.Text = "Search Availability Date";
            this.searchAvailabilityDateToolStripMenuItem.Click += new System.EventHandler(this.searchAvailabilityDateToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.editToolStripMenuItem.Text = "Maintain Books Info";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.viewBorrowingRecordToolStripMenuItem});
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(259, 22);
            this.newToolStripMenuItem1.Text = "Maintain Member Info";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // viewBorrowingRecordToolStripMenuItem
            // 
            this.viewBorrowingRecordToolStripMenuItem.Name = "viewBorrowingRecordToolStripMenuItem";
            this.viewBorrowingRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.viewBorrowingRecordToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.viewBorrowingRecordToolStripMenuItem.Text = "View Borrowing Record";
            this.viewBorrowingRecordToolStripMenuItem.Click += new System.EventHandler(this.viewBorrowingRecordToolStripMenuItem_Click);
            // 
            // trasactionToolStripMenuItem
            // 
            this.trasactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.reserveToolStripMenuItem});
            this.trasactionToolStripMenuItem.Name = "trasactionToolStripMenuItem";
            this.trasactionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.trasactionToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.trasactionToolStripMenuItem.Text = "Transaction";
            // 
            // borrowToolStripMenuItem
            // 
            this.borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            this.borrowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.borrowToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.borrowToolStripMenuItem.Text = "Borrow";
            this.borrowToolStripMenuItem.Click += new System.EventHandler(this.borrowToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // reserveToolStripMenuItem
            // 
            this.reserveToolStripMenuItem.Name = "reserveToolStripMenuItem";
            this.reserveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.reserveToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.reserveToolStripMenuItem.Text = "Reserve";
            this.reserveToolStripMenuItem.Click += new System.EventHandler(this.reserveToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowReceiptToolStripMenuItem,
            this.listOfBooksToolStripMenuItem,
            this.listOfMembersToolStripMenuItem,
            this.crossToTabToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // borrowReceiptToolStripMenuItem
            // 
            this.borrowReceiptToolStripMenuItem.Name = "borrowReceiptToolStripMenuItem";
            this.borrowReceiptToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.borrowReceiptToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.borrowReceiptToolStripMenuItem.Text = "Print Latest Borrow Receipt";
            this.borrowReceiptToolStripMenuItem.Click += new System.EventHandler(this.borrowReceiptToolStripMenuItem_Click);
            // 
            // listOfBooksToolStripMenuItem
            // 
            this.listOfBooksToolStripMenuItem.Name = "listOfBooksToolStripMenuItem";
            this.listOfBooksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.listOfBooksToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.listOfBooksToolStripMenuItem.Text = "List of Books";
            this.listOfBooksToolStripMenuItem.Click += new System.EventHandler(this.listOfBooksToolStripMenuItem_Click);
            // 
            // listOfMembersToolStripMenuItem
            // 
            this.listOfMembersToolStripMenuItem.Name = "listOfMembersToolStripMenuItem";
            this.listOfMembersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.listOfMembersToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.listOfMembersToolStripMenuItem.Text = "List of Members";
            this.listOfMembersToolStripMenuItem.Click += new System.EventHandler(this.listOfMembersToolStripMenuItem_Click);
            // 
            // crossToTabToolStripMenuItem
            // 
            this.crossToTabToolStripMenuItem.Name = "crossToTabToolStripMenuItem";
            this.crossToTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.crossToTabToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.crossToTabToolStripMenuItem.Text = "Cross To Tab";
            this.crossToTabToolStripMenuItem.Click += new System.EventHandler(this.crossToTabToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hello ";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 72);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SA47 Team11a Library Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewBorrowingRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem borrowReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossToTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAvailabilityDateToolStripMenuItem;
    }
}

