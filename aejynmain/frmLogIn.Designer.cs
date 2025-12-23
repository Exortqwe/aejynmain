namespace aejynmain
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            linkLabel2 = new LinkLabel();
            label6 = new Label();
            btnLogIn = new Button();
            label2 = new Label();
            checkBox1 = new CheckBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.White;
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.FromArgb(58, 124, 165);
            linkLabel2.Location = new Point(297, 489);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(81, 20);
            linkLabel2.TabIndex = 21;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create one";
            linkLabel2.VisitedLinkColor = Color.FromArgb(51, 106, 140);
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.GrayText;
            label6.Location = new Point(135, 489);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 20;
            label6.Text = "Don't have an account?";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(58, 124, 165);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(109, 424);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(315, 41);
            btnLogIn.TabIndex = 19;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(168, 186);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 13;
            label2.Text = " Vehicle Rental Management";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.GrayText;
            checkBox1.Location = new Point(110, 378);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(46, 46, 46);
            label1.Location = new Point(139, 155);
            label1.Name = "label1";
            label1.Size = new Size(248, 31);
            label1.TabIndex = 12;
            label1.Text = "Log in to your account";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(58, 124, 165);
            linkLabel1.Location = new Point(297, 379);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 20);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password?";
            linkLabel1.VisitedLinkColor = Color.FromArgb(51, 106, 140);
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(109, 332);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(315, 34);
            txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(70, 46, 46);
            label3.Location = new Point(109, 227);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 11;
            label3.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(70, 46, 46);
            label5.Location = new Point(109, 306);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 15;
            label5.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(109, 253);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(315, 34);
            txtUsername.TabIndex = 14;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(540, 527);
            Controls.Add(linkLabel2);
            Controls.Add(label6);
            Controls.Add(btnLogIn);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += frmLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel2;
        private Label label6;
        private Button btnLogIn;
        private Label label2;
        private CheckBox checkBox1;
        private Label label1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private Label label3;
        private Label label5;
        private TextBox txtUsername;
    }
}