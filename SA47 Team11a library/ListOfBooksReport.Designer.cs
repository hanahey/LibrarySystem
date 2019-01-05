namespace SA47_Team11a_library
{
    partial class ListOfBooksReport
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
            this.listOfBooksReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // listOfBooksReportViewer
            // 
            this.listOfBooksReportViewer.ActiveViewIndex = -1;
            this.listOfBooksReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listOfBooksReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.listOfBooksReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfBooksReportViewer.Location = new System.Drawing.Point(0, 0);
            this.listOfBooksReportViewer.Name = "listOfBooksReportViewer";
            this.listOfBooksReportViewer.Size = new System.Drawing.Size(800, 450);
            this.listOfBooksReportViewer.TabIndex = 0;
            // 
            // ListOfBooksReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listOfBooksReportViewer);
            this.Name = "ListOfBooksReport";
            this.Text = "ListOfBooksReport";
            this.Load += new System.EventHandler(this.ListOfBooksReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer listOfBooksReportViewer;
    }
}