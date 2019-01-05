namespace SA47_Team11a_library
{
    partial class AllBooksForm
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
            this.AllBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.selectBookButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBooksDataGridView
            // 
            this.AllBooksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBooksDataGridView.Location = new System.Drawing.Point(255, 12);
            this.AllBooksDataGridView.Name = "AllBooksDataGridView";
            this.AllBooksDataGridView.ReadOnly = true;
            this.AllBooksDataGridView.RowTemplate.Height = 33;
            this.AllBooksDataGridView.Size = new System.Drawing.Size(715, 608);
            this.AllBooksDataGridView.TabIndex = 0;
            this.AllBooksDataGridView.DoubleClick += new System.EventHandler(this.AllBooksDataGridView_DoubleClick);
            // 
            // selectBookButton
            // 
            this.selectBookButton.Location = new System.Drawing.Point(451, 680);
            this.selectBookButton.Name = "selectBookButton";
            this.selectBookButton.Size = new System.Drawing.Size(310, 45);
            this.selectBookButton.TabIndex = 1;
            this.selectBookButton.Text = "Select Book";
            this.selectBookButton.UseVisualStyleBackColor = true;
            this.selectBookButton.Click += new System.EventHandler(this.selectBookButton_Click);
            // 
            // AllBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 848);
            this.Controls.Add(this.selectBookButton);
            this.Controls.Add(this.AllBooksDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllBooksForm";
            this.Text = "AllBooksForm";
            this.Load += new System.EventHandler(this.AllBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AllBooksDataGridView;
        private System.Windows.Forms.Button selectBookButton;
    }
}