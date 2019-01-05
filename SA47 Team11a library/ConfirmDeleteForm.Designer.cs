namespace SA47_Team11a_library
{
    partial class ConfirmDeleteForm
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
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.QuestionPictureBox = new System.Windows.Forms.PictureBox();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextBox.Location = new System.Drawing.Point(83, 34);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(339, 35);
            this.QuestionTextBox.TabIndex = 0;
            this.QuestionTextBox.Text = "Are you sure you want to delete?";
            // 
            // QuestionPictureBox
            // 
            this.QuestionPictureBox.Image = global::SA47_Team11a_library.Properties.Resources.QuestionIcon;
            this.QuestionPictureBox.Location = new System.Drawing.Point(37, 34);
            this.QuestionPictureBox.Name = "QuestionPictureBox";
            this.QuestionPictureBox.Size = new System.Drawing.Size(40, 30);
            this.QuestionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuestionPictureBox.TabIndex = 1;
            this.QuestionPictureBox.TabStop = false;
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(114, 79);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 2;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(273, 79);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 3;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 114);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.QuestionPictureBox);
            this.Controls.Add(this.QuestionTextBox);
            this.Name = "ConfirmDelete";
            this.Text = "Confirm Delete";
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.PictureBox QuestionPictureBox;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
    }
}