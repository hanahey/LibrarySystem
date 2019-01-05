namespace SA47_Team11a_library
{
    partial class ComfirmAddForm
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
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.QuestionPictureBox = new System.Windows.Forms.PictureBox();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(283, 83);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 7;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(124, 83);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 6;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // QuestionPictureBox
            // 
            this.QuestionPictureBox.Image = global::SA47_Team11a_library.Properties.Resources.QuestionIcon;
            this.QuestionPictureBox.Location = new System.Drawing.Point(47, 38);
            this.QuestionPictureBox.Name = "QuestionPictureBox";
            this.QuestionPictureBox.Size = new System.Drawing.Size(40, 30);
            this.QuestionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuestionPictureBox.TabIndex = 5;
            this.QuestionPictureBox.TabStop = false;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextBox.Location = new System.Drawing.Point(93, 38);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(339, 35);
            this.QuestionTextBox.TabIndex = 4;
            this.QuestionTextBox.Text = "Are you sure you want to add?";
            // 
            // ComfirmAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 144);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.QuestionPictureBox);
            this.Controls.Add(this.QuestionTextBox);
            this.Name = "ComfirmAddForm";
            this.Text = "Comfirm Add";
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.PictureBox QuestionPictureBox;
        private System.Windows.Forms.TextBox QuestionTextBox;
    }
}