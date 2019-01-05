namespace SA47_Team11a_library
{
    partial class BorrowReceiptForm
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
            this.BorrowReceiptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // BorrowReceiptViewer
            // 
            this.BorrowReceiptViewer.ActiveViewIndex = -1;
            this.BorrowReceiptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorrowReceiptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.BorrowReceiptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorrowReceiptViewer.Location = new System.Drawing.Point(0, 0);
            this.BorrowReceiptViewer.Name = "BorrowReceiptViewer";
            this.BorrowReceiptViewer.Size = new System.Drawing.Size(800, 450);
            this.BorrowReceiptViewer.TabIndex = 0;
            // 
            // BorrowReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BorrowReceiptViewer);
            this.Name = "BorrowReceiptForm";
            this.Text = "BorrowReceiptForm";
            this.Load += new System.EventHandler(this.BorrowReceiptForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer BorrowReceiptViewer;
    }
}