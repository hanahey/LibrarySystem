namespace SA47_Team11a_library
{
    partial class CrossTabReportForm
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
            this.CrossTabCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrossTabCrystalReport1 = new SA47_Team11a_library.CrossTabCrystalReport();
            this.SuspendLayout();
            // 
            // CrossTabCrystalReportViewer
            // 
            this.CrossTabCrystalReportViewer.ActiveViewIndex = -1;
            this.CrossTabCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrossTabCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrossTabCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrossTabCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CrossTabCrystalReportViewer.Name = "CrossTabCrystalReportViewer";
            this.CrossTabCrystalReportViewer.Size = new System.Drawing.Size(1285, 799);
            this.CrossTabCrystalReportViewer.TabIndex = 0;
            // 
            // CrossTabReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 799);
            this.Controls.Add(this.CrossTabCrystalReportViewer);
            this.Name = "CrossTabReportForm";
            this.Text = "CrossTabReportForm";
            this.Load += new System.EventHandler(this.CrossTabReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrossTabCrystalReportViewer;
        private CrossTabCrystalReport CrossTabCrystalReport1;
    }
}