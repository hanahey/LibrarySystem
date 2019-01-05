namespace SA47_Team11a_library
{
    partial class AuthorSearchForm
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
            this.selectBookButton = new System.Windows.Forms.Button();
            this.AuthorBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.AuthorNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectBookButton
            // 
            this.selectBookButton.Location = new System.Drawing.Point(396, 357);
            this.selectBookButton.Name = "selectBookButton";
            this.selectBookButton.Size = new System.Drawing.Size(310, 45);
            this.selectBookButton.TabIndex = 3;
            this.selectBookButton.Text = "Select Book";
            this.selectBookButton.UseVisualStyleBackColor = true;
            this.selectBookButton.Click += new System.EventHandler(this.selectBookButton_Click);
            // 
            // AuthorBooksDataGridView
            // 
            this.AuthorBooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AuthorBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorBooksDataGridView.Location = new System.Drawing.Point(212, 12);
            this.AuthorBooksDataGridView.Name = "AuthorBooksDataGridView";
            this.AuthorBooksDataGridView.ReadOnly = true;
            this.AuthorBooksDataGridView.RowTemplate.Height = 33;
            this.AuthorBooksDataGridView.Size = new System.Drawing.Size(691, 316);
            this.AuthorBooksDataGridView.TabIndex = 2;
            // 
            // AuthorNameLabel
            // 
            this.AuthorNameLabel.AutoSize = true;
            this.AuthorNameLabel.Location = new System.Drawing.Point(126, 357);
            this.AuthorNameLabel.Name = "AuthorNameLabel";
            this.AuthorNameLabel.Size = new System.Drawing.Size(232, 31);
            this.AuthorNameLabel.TabIndex = 4;
            this.AuthorNameLabel.Text = "AuthorNameLabel";
            this.AuthorNameLabel.Visible = false;
            this.AuthorNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AuthorSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 437);
            this.Controls.Add(this.AuthorNameLabel);
            this.Controls.Add(this.selectBookButton);
            this.Controls.Add(this.AuthorBooksDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorSearchForm";
            this.Text = "AuthorSearchForm";
            this.Load += new System.EventHandler(this.AuthorSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorBooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectBookButton;
        private System.Windows.Forms.DataGridView AuthorBooksDataGridView;
        private System.Windows.Forms.Label AuthorNameLabel;
    }
}