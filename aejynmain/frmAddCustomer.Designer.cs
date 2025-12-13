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
            txtFname1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLname1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtContactNum1 = new TextBox();
            cbGender1 = new ComboBox();
            label6 = new Label();
            txtEmail1 = new TextBox();
            label7 = new Label();
            txtAddress1 = new TextBox();
            dtLicenseExpiry = new DateTimePicker();
            dtBoDate = new DateTimePicker();
            dtDateRegistered = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtLicenseNumber = new TextBox();
            label12 = new Label();
            btnSaveCustomerDetails = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
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
            // txtFname1
            // 
            txtFname1.BorderStyle = BorderStyle.FixedSingle;
            txtFname1.Location = new Point(12, 131);
            txtFname1.Multiline = true;
            txtFname1.Name = "txtFname1";
            txtFname1.Size = new Size(165, 34);
            txtFname1.TabIndex = 6;
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
            // txtLname1
            // 
            txtLname1.BorderStyle = BorderStyle.FixedSingle;
            txtLname1.Location = new Point(212, 131);
            txtLname1.Multiline = true;
            txtLname1.Name = "txtLname1";
            txtLname1.Size = new Size(165, 34);
            txtLname1.TabIndex = 8;
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
            // txtContactNum1
            // 
            txtContactNum1.BorderStyle = BorderStyle.FixedSingle;
            txtContactNum1.Location = new Point(409, 131);
            txtContactNum1.Multiline = true;
            txtContactNum1.Name = "txtContactNum1";
            txtContactNum1.Size = new Size(165, 34);
            txtContactNum1.TabIndex = 12;
            // 
            // cbGender1
            // 
            cbGender1.FormattingEnabled = true;
            cbGender1.Items.AddRange(new object[] { "Male", "Female" });
            cbGender1.Location = new Point(406, 231);
            cbGender1.Name = "cbGender1";
            cbGender1.Size = new Size(165, 28);
            cbGender1.TabIndex = 14;
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
            // txtEmail1
            // 
            txtEmail1.BorderStyle = BorderStyle.FixedSingle;
            txtEmail1.Location = new Point(611, 131);
            txtEmail1.Multiline = true;
            txtEmail1.Name = "txtEmail1";
            txtEmail1.Size = new Size(165, 34);
            txtEmail1.TabIndex = 15;
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
            // txtAddress1
            // 
            txtAddress1.BorderStyle = BorderStyle.FixedSingle;
            txtAddress1.Location = new Point(12, 231);
            txtAddress1.Multiline = true;
            txtAddress1.Name = "txtAddress1";
            txtAddress1.Size = new Size(365, 36);
            txtAddress1.TabIndex = 17;
            // 
            // dtLicenseExpiry
            // 
            dtLicenseExpiry.Location = new Point(10, 337);
            dtLicenseExpiry.Name = "dtLicenseExpiry";
            dtLicenseExpiry.Size = new Size(239, 27);
            dtLicenseExpiry.TabIndex = 19;
            // 
            // dtBoDate
            // 
            dtBoDate.Location = new Point(286, 337);
            dtBoDate.Name = "dtBoDate";
            dtBoDate.Size = new Size(239, 27);
            dtBoDate.TabIndex = 20;
            // 
            // dtDateRegistered
            // 
            dtDateRegistered.Location = new Point(563, 337);
            dtDateRegistered.Name = "dtDateRegistered";
            dtDateRegistered.Size = new Size(239, 27);
            dtDateRegistered.TabIndex = 21;
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
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(201, 74, 74);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 63, 63);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(750, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(56, 33);
            iconButton1.TabIndex = 29;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // frmAddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(818, 469);
            Controls.Add(iconButton1);
            Controls.Add(btnSaveCustomerDetails);
            Controls.Add(label12);
            Controls.Add(txtLicenseNumber);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dtDateRegistered);
            Controls.Add(dtBoDate);
            Controls.Add(dtLicenseExpiry);
            Controls.Add(label7);
            Controls.Add(txtAddress1);
            Controls.Add(label6);
            Controls.Add(txtEmail1);
            Controls.Add(cbGender1);
            Controls.Add(label5);
            Controls.Add(txtContactNum1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLname1);
            Controls.Add(label2);
            Controls.Add(txtFname1);
            Controls.Add(label1);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(kryptonBorderEdge1);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox txtFname1;
        private Label label2;
        private Label label3;
        private TextBox txtLname1;
        private Label label4;
        private Label label5;
        private TextBox txtContactNum1;
        private ComboBox cbGender1;
        private Label label6;
        private TextBox txtEmail1;
        private Label label7;
        private TextBox txtAddress1;
        private DateTimePicker dtLicenseExpiry;
        private DateTimePicker dtBoDate;
        private DateTimePicker dtDateRegistered;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtLicenseNumber;
        private Label label12;
        private Button btnSaveCustomerDetails;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ComboBox comboBox2;
    }
}