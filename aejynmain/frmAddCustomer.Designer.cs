namespace aejynmain
{
    partial class frmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtContactNum = new TextBox();
            cmbGender = new ComboBox();
            label6 = new Label();
            txtEmailAddress = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            dtpLicenseExpiry = new DateTimePicker();
            dtpBirthDate = new DateTimePicker();
            dtpDateRegistered = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtLicenseNumber = new TextBox();
            label12 = new Label();
            btnSaveCustomerDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(-14, 86);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(875, 1);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.Location = new Point(12, 12);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(69, 62);
            kryptonPictureBox1.TabIndex = 4;
            kryptonPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 28);
            label1.Name = "label1";
            label1.Size = new Size(210, 35);
            label1.TabIndex = 5;
            label1.Text = "Customer Details";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(12, 131);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(165, 34);
            txtFirstName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 108);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 9;
            label3.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(212, 131);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(165, 34);
            txtLastName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 208);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 11;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 108);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 13;
            label5.Text = "Contact Number";
            // 
            // txtContactNum
            // 
            txtContactNum.BorderStyle = BorderStyle.FixedSingle;
            txtContactNum.Location = new Point(409, 131);
            txtContactNum.Multiline = true;
            txtContactNum.Name = "txtContactNum";
            txtContactNum.Size = new Size(165, 34);
            txtContactNum.TabIndex = 12;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(406, 231);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(165, 28);
            cmbGender.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 108);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 16;
            label6.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BorderStyle = BorderStyle.FixedSingle;
            txtEmailAddress.Location = new Point(611, 131);
            txtEmailAddress.Multiline = true;
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(165, 34);
            txtEmailAddress.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 208);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 18;
            label7.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(12, 231);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(365, 36);
            txtAddress.TabIndex = 17;
            // 
            // dtpLicenseExpiry
            // 
            dtpLicenseExpiry.Location = new Point(10, 337);
            dtpLicenseExpiry.Name = "dtpLicenseExpiry";
            dtpLicenseExpiry.Size = new Size(239, 27);
            dtpLicenseExpiry.TabIndex = 19;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(286, 337);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(239, 27);
            dtpBirthDate.TabIndex = 20;
            // 
            // dtpDateRegistered
            // 
            dtpDateRegistered.Location = new Point(563, 337);
            dtpDateRegistered.Name = "dtpDateRegistered";
            dtpDateRegistered.Size = new Size(239, 27);
            dtpDateRegistered.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 314);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 22;
            label8.Text = "License Expiry Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(286, 314);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(563, 314);
            label10.Name = "label10";
            label10.Size = new Size(116, 20);
            label10.TabIndex = 24;
            label10.Text = "Date Registered";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(286, 314);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 25;
            label11.Text = "Birth of Date";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.BorderStyle = BorderStyle.FixedSingle;
            txtLicenseNumber.Location = new Point(611, 225);
            txtLicenseNumber.Multiline = true;
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(165, 34);
            txtLicenseNumber.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(611, 202);
            label12.Name = "label12";
            label12.Size = new Size(115, 20);
            label12.TabIndex = 27;
            label12.Text = "License Number";
            // 
            // btnSaveCustomerDetails
            // 
            btnSaveCustomerDetails.BackColor = Color.FromArgb(58, 124, 165);
            btnSaveCustomerDetails.FlatAppearance.BorderSize = 0;
            btnSaveCustomerDetails.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnSaveCustomerDetails.FlatStyle = FlatStyle.Flat;
            btnSaveCustomerDetails.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveCustomerDetails.ForeColor = Color.White;
            btnSaveCustomerDetails.Location = new Point(309, 401);
            btnSaveCustomerDetails.Name = "btnSaveCustomerDetails";
            btnSaveCustomerDetails.Size = new Size(190, 40);
            btnSaveCustomerDetails.TabIndex = 28;
            btnSaveCustomerDetails.Text = "Save";
            btnSaveCustomerDetails.UseVisualStyleBackColor = false;
            btnSaveCustomerDetails.Click += btnSaveCustomerDetails_Click;
            // 
            // frmAddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(818, 469);
            Controls.Add(btnSaveCustomerDetails);
            Controls.Add(label12);
            Controls.Add(txtLicenseNumber);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtpDateRegistered);
            Controls.Add(dtpBirthDate);
            Controls.Add(dtpLicenseExpiry);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtEmailAddress);
            Controls.Add(cmbGender);
            Controls.Add(label5);
            Controls.Add(txtContactNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(kryptonBorderEdge1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddCustomer";
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private Label label5;
        private TextBox txtContactNum;
        private ComboBox cmbGender;
        private Label label6;
        private TextBox txtEmailAddress;
        private Label label7;
        private TextBox txtAddress;
        private DateTimePicker dtpLicenseExpiry;
        private DateTimePicker dtpBirthDate;
        private DateTimePicker dtpDateRegistered;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtLicenseNumber;
        private Label label12;
        private Button btnSaveCustomerDetails;
        private ComboBox comboBox2;
    }
}