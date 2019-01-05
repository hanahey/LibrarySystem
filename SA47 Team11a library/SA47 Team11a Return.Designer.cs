namespace SA47_Team11a_library
{
    partial class SA47_Team11a_Return
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateActualReturn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.txtPublishingDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAvailableToBorrow = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtIdentificationNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedtxtMemberID = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(279, 69);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 33;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(279, 117);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 32;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "BookID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "MemberID";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(134, 117);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 21);
            this.txtBookID.TabIndex = 25;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            this.txtBookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookID_KeyPress);
            // 
            // dateTimePickerDateActualReturn
            // 
            this.dateTimePickerDateActualReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateActualReturn.Location = new System.Drawing.Point(134, 166);
            this.dateTimePickerDateActualReturn.Name = "dateTimePickerDateActualReturn";
            this.dateTimePickerDateActualReturn.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerDateActualReturn.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "DateActualReturn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(134, 200);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(200, 75);
            this.txtRemarks.TabIndex = 37;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(183, 307);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 38;
            this.btnConfirm.Text = "Confirm\r\n";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 48;
            this.label9.Text = "TotalStock";
            // 
            // txtTotalStock
            // 
            this.txtTotalStock.Location = new System.Drawing.Point(127, 123);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.ReadOnly = true;
            this.txtTotalStock.Size = new System.Drawing.Size(100, 21);
            this.txtTotalStock.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 46;
            this.label7.Text = "PublishingDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 45;
            this.label8.Text = "PublisherName";
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(127, 69);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.ReadOnly = true;
            this.txtPublisherName.Size = new System.Drawing.Size(100, 21);
            this.txtPublisherName.TabIndex = 44;
            // 
            // txtPublishingDate
            // 
            this.txtPublishingDate.Location = new System.Drawing.Point(127, 96);
            this.txtPublishingDate.Name = "txtPublishingDate";
            this.txtPublishingDate.ReadOnly = true;
            this.txtPublishingDate.Size = new System.Drawing.Size(100, 21);
            this.txtPublishingDate.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 42;
            this.label10.Text = "Author";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 41;
            this.label11.Text = "BookName";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(127, 15);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(100, 21);
            this.txtBookName.TabIndex = 40;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(127, 42);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(100, 21);
            this.txtAuthor.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 12);
            this.label12.TabIndex = 58;
            this.label12.Text = "AvailableToBorrow";
            // 
            // txtAvailableToBorrow
            // 
            this.txtAvailableToBorrow.Location = new System.Drawing.Point(130, 116);
            this.txtAvailableToBorrow.Name = "txtAvailableToBorrow";
            this.txtAvailableToBorrow.ReadOnly = true;
            this.txtAvailableToBorrow.Size = new System.Drawing.Size(100, 21);
            this.txtAvailableToBorrow.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 56;
            this.label13.Text = "Occupation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 12);
            this.label14.TabIndex = 55;
            this.label14.Text = "PhoneNumber";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(130, 62);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 21);
            this.txtPhoneNumber.TabIndex = 54;
            // 
            // txtOccupation
            // 
            this.txtOccupation.Location = new System.Drawing.Point(130, 89);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.ReadOnly = true;
            this.txtOccupation.Size = new System.Drawing.Size(100, 21);
            this.txtOccupation.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 12);
            this.label15.TabIndex = 52;
            this.label15.Text = "IdentificationNum";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 51;
            this.label16.Text = "MemberName";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(130, 8);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(100, 21);
            this.txtMemberName.TabIndex = 50;
            // 
            // txtIdentificationNum
            // 
            this.txtIdentificationNum.Location = new System.Drawing.Point(130, 35);
            this.txtIdentificationNum.Name = "txtIdentificationNum";
            this.txtIdentificationNum.ReadOnly = true;
            this.txtIdentificationNum.Size = new System.Drawing.Size(100, 21);
            this.txtIdentificationNum.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtAvailableToBorrow);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtOccupation);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.txtIdentificationNum);
            this.groupBox1.Location = new System.Drawing.Point(493, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 159);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTotalStock);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPublisherName);
            this.groupBox2.Controls.Add(this.txtPublishingDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBookName);
            this.groupBox2.Controls.Add(this.txtAuthor);
            this.groupBox2.Location = new System.Drawing.Point(496, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 157);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book";
            // 
            // maskedtxtMemberID
            // 
            this.maskedtxtMemberID.Location = new System.Drawing.Point(134, 81);
            this.maskedtxtMemberID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.maskedtxtMemberID.Mask = "99999";
            this.maskedtxtMemberID.Name = "maskedtxtMemberID";
            this.maskedtxtMemberID.Size = new System.Drawing.Size(52, 21);
            this.maskedtxtMemberID.TabIndex = 61;
            // 
            // SA47_Team11a_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.maskedtxtMemberID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerDateActualReturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookID);
            this.Name = "SA47_Team11a_Return";
            this.Text = "SA47_Team11a_Return";
            this.Load += new System.EventHandler(this.SA47_Team11a_Return_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateActualReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtPublishingDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAvailableToBorrow;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtIdentificationNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedtxtMemberID;
    }
}