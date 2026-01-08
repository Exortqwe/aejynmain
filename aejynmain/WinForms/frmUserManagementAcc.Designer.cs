namespace aejynmain.WinForms
{
    partial class frmUserManagementAcc
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
            btnCreateAcc = new Button();
            dtpDateCreated = new DateTimePicker();
            dtpBirthDate = new DateTimePicker();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            cmbRole = new ComboBox();
            txtPhone = new TextBox();
            txtUsername = new TextBox();
            txtLastName = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateAcc
            // 
            btnCreateAcc.BackColor = Color.FromArgb(58, 124, 165);
            btnCreateAcc.FlatAppearance.BorderSize = 0;
            btnCreateAcc.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnCreateAcc.FlatStyle = FlatStyle.Flat;
            btnCreateAcc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAcc.ForeColor = Color.White;
            btnCreateAcc.Location = new Point(193, 378);
            btnCreateAcc.Name = "btnCreateAcc";
            btnCreateAcc.Size = new Size(387, 45);
            btnCreateAcc.TabIndex = 79;
            btnCreateAcc.Text = "Create Account";
            btnCreateAcc.UseVisualStyleBackColor = false;
            // 
            // dtpDateCreated
            // 
            dtpDateCreated.Location = new Point(439, 330);
            dtpDateCreated.Name = "dtpDateCreated";
            dtpDateCreated.Size = new Size(246, 27);
            dtpDateCreated.TabIndex = 78;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(116, 330);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(246, 27);
            dtpBirthDate.TabIndex = 77;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(522, 253);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(164, 32);
            txtPassword.TabIndex = 76;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(319, 253);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 32);
            txtEmail.TabIndex = 75;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(116, 253);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(187, 32);
            txtAddress.TabIndex = 74;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 11F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(522, 180);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(164, 33);
            cmbGender.TabIndex = 73;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 11F);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Rental Agent" });
            cmbRole.Location = new Point(319, 180);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(164, 33);
            cmbRole.TabIndex = 72;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(116, 181);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(164, 32);
            txtPhone.TabIndex = 71;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(521, 104);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(164, 32);
            txtUsername.TabIndex = 70;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(319, 104);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(164, 32);
            txtLastName.TabIndex = 69;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label16.ForeColor = Color.FromArgb(46, 46, 46);
            label16.Location = new Point(439, 307);
            label16.Name = "label16";
            label16.Size = new Size(98, 20);
            label16.TabIndex = 68;
            label16.Text = "Date Created";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(46, 46, 46);
            label15.Location = new Point(522, 230);
            label15.Name = "label15";
            label15.Size = new Size(73, 20);
            label15.TabIndex = 67;
            label15.Text = "Password";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(46, 46, 46);
            label14.Location = new Point(116, 307);
            label14.Name = "label14";
            label14.Size = new Size(96, 20);
            label14.TabIndex = 66;
            label14.Text = "Birth of Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(46, 46, 46);
            label13.Location = new Point(521, 157);
            label13.Name = "label13";
            label13.Size = new Size(59, 20);
            label13.TabIndex = 65;
            label13.Text = "Gender";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(46, 46, 46);
            label12.Location = new Point(319, 157);
            label12.Name = "label12";
            label12.Size = new Size(39, 20);
            label12.TabIndex = 64;
            label12.Text = "Role";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(46, 46, 46);
            label11.Location = new Point(521, 81);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 63;
            label11.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(46, 46, 46);
            label7.Location = new Point(116, 230);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 62;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(46, 46, 46);
            label6.Location = new Point(116, 157);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 61;
            label6.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(46, 46, 46);
            label5.Location = new Point(319, 230);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 60;
            label5.Text = "Email Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(46, 46, 46);
            label4.Location = new Point(319, 81);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 59;
            label4.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(116, 104);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(164, 32);
            txtFirstName.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(46, 46, 46);
            label3.Location = new Point(116, 81);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 57;
            label3.Text = "First Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 73, 102);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 75);
            panel1.TabIndex = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(131, 35);
            label1.TabIndex = 5;
            label1.Text = "Add Users";
            // 
            // frmUserManagementAcc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 478);
            Controls.Add(panel1);
            Controls.Add(btnCreateAcc);
            Controls.Add(dtpDateCreated);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(cmbGender);
            Controls.Add(cmbRole);
            Controls.Add(txtPhone);
            Controls.Add(txtUsername);
            Controls.Add(txtLastName);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Name = "frmUserManagementAcc";
            Text = "frmUserManagementAcc";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateAcc;
        private DateTimePicker dtpDateCreated;
        private DateTimePicker dtpBirthDate;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private ComboBox cmbGender;
        private ComboBox cmbRole;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private TextBox txtLastName;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtFirstName;
        private Label label3;
        private Panel panel1;
        private Label label1;
    }
}