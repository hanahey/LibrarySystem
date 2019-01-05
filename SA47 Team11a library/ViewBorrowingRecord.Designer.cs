namespace SA47_Team11a_library
{
    partial class ViewBorrowingRecord
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
            this.SearchMemberByIDTextBox = new System.Windows.Forms.TextBox();
            this.SearchByMemberIDButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LoadAllMembersButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchMemberByIDTextBox
            // 
            this.SearchMemberByIDTextBox.Location = new System.Drawing.Point(156, 45);
            this.SearchMemberByIDTextBox.Name = "SearchMemberByIDTextBox";
            this.SearchMemberByIDTextBox.Size = new System.Drawing.Size(100, 21);
            this.SearchMemberByIDTextBox.TabIndex = 3;
            // 
            // SearchByMemberIDButton
            // 
            this.SearchByMemberIDButton.Location = new System.Drawing.Point(265, 43);
            this.SearchByMemberIDButton.Name = "SearchByMemberIDButton";
            this.SearchByMemberIDButton.Size = new System.Drawing.Size(94, 21);
            this.SearchByMemberIDButton.TabIndex = 2;
            this.SearchByMemberIDButton.Text = "Search";
            this.toolTip1.SetToolTip(this.SearchByMemberIDButton, "Search by MemberID");
            this.SearchByMemberIDButton.UseVisualStyleBackColor = true;
            this.SearchByMemberIDButton.Click += new System.EventHandler(this.SearchByMemberIDButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 279);
            this.dataGridView1.TabIndex = 4;
            // 
            // LoadAllMembersButton
            // 
            this.LoadAllMembersButton.Location = new System.Drawing.Point(367, 43);
            this.LoadAllMembersButton.Name = "LoadAllMembersButton";
            this.LoadAllMembersButton.Size = new System.Drawing.Size(122, 21);
            this.LoadAllMembersButton.TabIndex = 6;
            this.LoadAllMembersButton.Text = "Load all Members";
            this.LoadAllMembersButton.UseVisualStyleBackColor = true;
            this.LoadAllMembersButton.Click += new System.EventHandler(this.LoadAllMembersButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(241, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "View Borrowing Record for all members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "MemberID";
            // 
            // ViewBorrowingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoadAllMembersButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchMemberByIDTextBox);
            this.Controls.Add(this.SearchByMemberIDButton);
            this.Name = "ViewBorrowingRecord";
            this.Text = "ViewBorrowingRecord";
            this.Load += new System.EventHandler(this.ViewBorrowingRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchMemberByIDTextBox;
        private System.Windows.Forms.Button SearchByMemberIDButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button LoadAllMembersButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}