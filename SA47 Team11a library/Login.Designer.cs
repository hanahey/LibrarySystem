namespace SA47_Team11a_library
{
    partial class LoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.employeeIDlabel = new System.Windows.Forms.Label();
            this.employeeIDtextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loginButton.Location = new System.Drawing.Point(265, 250);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(142, 72);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // employeeIDlabel
            // 
            this.employeeIDlabel.AutoSize = true;
            this.employeeIDlabel.Location = new System.Drawing.Point(107, 73);
            this.employeeIDlabel.Name = "employeeIDlabel";
            this.employeeIDlabel.Size = new System.Drawing.Size(73, 17);
            this.employeeIDlabel.TabIndex = 1;
            this.employeeIDlabel.Text = "Username";
            // 
            // employeeIDtextbox
            // 
            this.employeeIDtextbox.Location = new System.Drawing.Point(319, 73);
            this.employeeIDtextbox.Name = "employeeIDtextbox";
            this.employeeIDtextbox.Size = new System.Drawing.Size(222, 23);
            this.employeeIDtextbox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(107, 124);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(319, 124);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(222, 23);
            this.passwordTextbox.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 436);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.employeeIDtextbox);
            this.Controls.Add(this.employeeIDlabel);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label employeeIDlabel;
        private System.Windows.Forms.TextBox employeeIDtextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
    }
}