namespace aejynmain
{
    partial class frmCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateAccount));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFname = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnCreateAcc = new Button();
            label9 = new Label();
            linkLabel1 = new LinkLabel();
            txtLName = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label10 = new Label();
            txtUsername1 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtPassword = new TextBox();
            label15 = new Label();
            label16 = new Label();
            dateTimeBOD = new DateTimePicker();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            panel1 = new Panel();
            dateTimeDateCreated = new DateTimePicker();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(191, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 46, 46);
            label1.Location = new Point(193, 145);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 2;
            label1.Text = "Create your account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(46, 46, 46);
            label2.Location = new Point(82, 206);
            label2.Name = "label2";
            label2.Size = new Size(170, 23);
            label2.TabIndex = 3;
            label2.Text = "Personal Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(46, 46, 46);
            label3.Location = new Point(82, 244);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "First Name";
            // 
            // txtFname
            // 
            txtFname.BorderStyle = BorderStyle.FixedSingle;
            txtFname.Location = new Point(82, 267);
            txtFname.Multiline = true;
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(164, 32);
            txtFname.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(46, 46, 46);
            label4.Location = new Point(300, 244);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 6;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(46, 46, 46);
            label5.Location = new Point(82, 520);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 8;
            label5.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(46, 46, 46);
            label6.Location = new Point(300, 361);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 10;
            label6.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(46, 46, 46);
            label7.Location = new Point(300, 520);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 12;
            label7.Text = "Address";
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.BackColor = Color.FromArgb(58, 124, 165);
            btnCreateAcc.FlatAppearance.BorderSize = 0;
            btnCreateAcc.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnCreateAcc.FlatStyle = FlatStyle.Flat;
            btnCreateAcc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAcc.ForeColor = Color.White;
            btnCreateAcc.Location = new Point(82, 673);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.Size = new Size(387, 45);
            btnCreateAcc.TabIndex = 16;
            btnCreateAcc.Text = "Create Account";
            btnCreateAcc.UseVisualStyleBackColor = false;
            btnCreateAcc.Click += btnCreateAcc_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(123, 733);
            label9.Name = "label9";
            label9.Size = new Size(178, 20);
            label9.TabIndex = 17;
            label9.Text = "Already have an account?";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(58, 124, 165);
            linkLabel1.Location = new Point(301, 733);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 20);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log in here";
            linkLabel1.VisitedLinkColor = Color.FromArgb(51, 106, 140);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtLName
            // 
            txtLName.BorderStyle = BorderStyle.FixedSingle;
            txtLName.Location = new Point(300, 267);
            txtLName.Multiline = true;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(164, 32);
            txtLName.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(82, 543);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 32);
            txtEmail.TabIndex = 20;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(300, 543);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(164, 32);
            txtAddress.TabIndex = 22;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(300, 384);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 32);
            txtPhone.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.ForeColor = SystemColors.GrayText;
            label10.Location = new Point(193, 173);
            label10.Name = "label10";
            label10.Size = new Size(198, 20);
            label10.TabIndex = 24;
            label10.Text = " Vehicle Rental Management";
            // 
            // txtUsername1
            // 
            txtUsername1.BorderStyle = BorderStyle.FixedSingle;
            txtUsername1.Location = new Point(82, 384);
            txtUsername1.Multiline = true;
            txtUsername1.Name = "txtUsername1";
            txtUsername1.Size = new Size(164, 32);
            txtUsername1.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(46, 46, 46);
            label11.Location = new Point(82, 361);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 25;
            label11.Text = "Username";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(46, 46, 46);
            label12.Location = new Point(300, 429);
            label12.Name = "label12";
            label12.Size = new Size(39, 20);
            label12.TabIndex = 27;
            label12.Text = "Role";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(46, 46, 46);
            label13.Location = new Point(82, 429);
            label13.Name = "label13";
            label13.Size = new Size(59, 20);
            label13.TabIndex = 29;
            label13.Text = "Gender";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(46, 46, 46);
            label14.Location = new Point(231, 305);
            label14.Name = "label14";
            label14.Size = new Size(96, 20);
            label14.TabIndex = 31;
            label14.Text = "Birth of Date";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(82, 624);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(164, 32);
            txtPassword.TabIndex = 34;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(46, 46, 46);
            label15.Location = new Point(82, 601);
            label15.Name = "label15";
            label15.Size = new Size(73, 20);
            label15.TabIndex = 33;
            label15.Text = "Password";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(46, 46, 46);
            label16.Location = new Point(300, 601);
            label16.Name = "label16";
            label16.Size = new Size(98, 20);
            label16.TabIndex = 35;
            label16.Text = "Date Created";
            // 
            // dateTimeBOD
            // 
            dateTimeBOD.Location = new Point(152, 328);
            dateTimeBOD.Name = "dateTimeBOD";
            dateTimeBOD.Size = new Size(246, 27);
            dateTimeBOD.TabIndex = 37;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(11, 10);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 39;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(80, 10);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 40;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(rbFemale);
            panel1.Controls.Add(rbMale);
            panel1.Location = new Point(81, 452);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 41);
            panel1.TabIndex = 41;
            // 
            // dateTimeDateCreated
            // 
            dateTimeDateCreated.Location = new Point(300, 629);
            dateTimeDateCreated.Name = "dateTimeDateCreated";
            dateTimeDateCreated.Size = new Size(243, 27);
            dateTimeDateCreated.TabIndex = 43;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "Manager", "Rental Agent", "Staff Counter" });
            comboBox1.Location = new Point(300, 452);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 39);
            comboBox1.TabIndex = 44;
            // 
            // frmCreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(612, 833);
            Controls.Add(comboBox1);
            Controls.Add(dateTimeDateCreated);
            Controls.Add(panel1);
            Controls.Add(dateTimeBOD);
            Controls.Add(label16);
            Controls.Add(txtPassword);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtUsername1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtLName);
            Controls.Add(linkLabel1);
            Controls.Add(label9);
            Controls.Add(btnCreateAcc);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFname;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnCreateAcc;
        private Label label9;
        private LinkLabel linkLabel1;
        private TextBox txtLName;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label label10;
        private TextBox txtUsername1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtPassword;
        private Label label15;
        private Label label16;
        private DateTimePicker dateTimeBOD;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Panel panel1;
        private DateTimePicker dateTimeDateCreated;
        private ComboBox comboBox1;
    }
}