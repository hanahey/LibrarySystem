namespace SA47_Team11a_library
{
    partial class ConfirmEditForm
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
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.QuestionPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(267, 85);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 7;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(108, 85);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 6;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextBox.Location = new System.Drawing.Point(77, 40);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(339, 35);
            this.QuestionTextBox.TabIndex = 4;
            this.QuestionTextBox.Text = "Are you sure you want to edit?";
            // 
            // QuestionPictureBox
            // 
            this.QuestionPictureBox.Image = global::SA47_Team11a_library.Properties.Resources.QuestionIcon;
            this.QuestionPictureBox.Location = new System.Drawing.Point(31, 40);
            this.QuestionPictureBox.Name = "QuestionPictureBox";
            this.QuestionPictureBox.Size = new System.Drawing.Size(40, 30);
            this.QuestionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuestionPictureBox.TabIndex = 5;
            this.QuestionPictureBox.TabStop = false;
            // 
            // ConfirmEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 149);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.QuestionPictureBox);
            this.Controls.Add(this.QuestionTextBox);
            this.Name = "ConfirmEditForm";
            this.Text = "Confirm Edit";
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