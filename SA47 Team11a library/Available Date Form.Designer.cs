namespace SA47_Team11a_library
{
    partial class AvaDateForm
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BookIDRadioButton = new System.Windows.Forms.RadioButton();
            this.BookNameRadioButton = new System.Windows.Forms.RadioButton();
            this.AvaDateLabel = new System.Windows.Forms.Label();
            this.AvaDateDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AvaDateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(946, 24);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(828, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hello ";
            this.label1.Visible = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(217, 47);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.ReadOnly = true;
            this.SearchTextBox.Size = new System.Drawing.Size(131, 21);
            this.SearchTextBox.TabIndex = 10;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(407, 45);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 21);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BookIDRadioButton
            // 
            this.BookIDRadioButton.AutoSize = true;
            this.BookIDRadioButton.Location = new System.Drawing.Point(12, 47);
            this.BookIDRadioButton.Name = "BookIDRadioButton";
            this.BookIDRadioButton.Size = new System.Drawing.Size(65, 16);
            this.BookIDRadioButton.TabIndex = 13;
            this.BookIDRadioButton.TabStop = true;
            this.BookIDRadioButton.Text = "Book ID";
            this.BookIDRadioButton.UseVisualStyleBackColor = true;
            this.BookIDRadioButton.CheckedChanged += new System.EventHandler(this.BookIDRadioButton_CheckedChanged);
            // 
            // BookNameRadioButton
            // 
            this.BookNameRadioButton.AutoSize = true;
            this.BookNameRadioButton.Location = new System.Drawing.Point(103, 47);
            this.BookNameRadioButton.Name = "BookNameRadioButton";
            this.BookNameRadioButton.Size = new System.Drawing.Size(77, 16);
            this.BookNameRadioButton.TabIndex = 14;
            this.BookNameRadioButton.TabStop = true;
            this.BookNameRadioButton.Text = "Book Name";
            this.BookNameRadioButton.UseVisualStyleBackColor = true;
            this.BookNameRadioButton.CheckedChanged += new System.EventHandler(this.BookNameRadioButton_CheckedChanged);
            // 
            // AvaDateLabel
            // 
            this.AvaDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaDateLabel.Location = new System.Drawing.Point(159, 108);
            this.AvaDateLabel.Name = "AvaDateLabel";
            this.AvaDateLabel.Size = new System.Drawing.Size(323, 21);
            this.AvaDateLabel.TabIndex = 15;
            this.AvaDateLabel.Text = "Availability Date for Books On Loan";
            // 
            // AvaDateDataGridView
            // 
            this.AvaDateDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AvaDateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvaDateDataGridView.Location = new System.Drawing.Point(12, 132);
            this.AvaDateDataGridView.Name = "AvaDateDataGridView";
            this.AvaDateDataGridView.Size = new System.Drawing.Size(591, 466);
            this.AvaDateDataGridView.TabIndex = 16;
            // 
            // AvaDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 423);
            this.Controls.Add(this.AvaDateDataGridView);
            this.Controls.Add(this.AvaDateLabel);
            this.Controls.Add(this.BookNameRadioButton);
            this.Controls.Add(this.BookIDRadioButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.label1);
            this.Name = "AvaDateForm";
            this.Text = "Search Availability Date";
            this.Load += new System.EventHandler(this.AvaDateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvaDateDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton BookIDRadioButton;
        private System.Windows.Forms.RadioButton BookNameRadioButton;
        private System.Windows.Forms.Label AvaDateLabel;
        private System.Windows.Forms.DataGridView AvaDateDataGridView;
    }
}