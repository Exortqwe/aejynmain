namespace aejynmain
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            btnReturns = new Button();
            btnDashboard = new Button();
            btnLogOut = new Button();
            btnReports = new Button();
            btnDamageClaims = new Button();
            btnUserManagement = new Button();
            btnFleetManagement = new Button();
            btnCustomers = new Button();
            btnReservations = new Button();
            pictureBox1 = new PictureBox();
            panelMain = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 73, 102);
            panel1.Controls.Add(btnReturns);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnDamageClaims);
            panel1.Controls.Add(btnUserManagement);
            panel1.Controls.Add(btnFleetManagement);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnReservations);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 861);
            panel1.TabIndex = 1;
            // 
            // btnReturns
            // 
            btnReturns.BackColor = Color.FromArgb(28, 73, 102);
            btnReturns.FlatAppearance.BorderSize = 0;
            btnReturns.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnReturns.FlatStyle = FlatStyle.Flat;
            btnReturns.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnReturns.ForeColor = Color.White;
            btnReturns.Image = (Image)resources.GetObject("btnReturns.Image");
            btnReturns.ImageAlign = ContentAlignment.MiddleLeft;
            btnReturns.Location = new Point(0, 502);
            btnReturns.Name = "btnReturns";
            btnReturns.Padding = new Padding(20, 0, 0, 0);
            btnReturns.Size = new Size(250, 64);
            btnReturns.TabIndex = 13;
            btnReturns.Text = "            Returns";
            btnReturns.TextAlign = ContentAlignment.MiddleLeft;
            btnReturns.UseVisualStyleBackColor = false;
            btnReturns.Click += btnReturns_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 152);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.Size = new Size(250, 64);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "             Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(28, 73, 102);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 712);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(20, 0, 0, 0);
            btnLogOut.Size = new Size(250, 64);
            btnLogOut.TabIndex = 12;
            btnLogOut.Text = "            Log Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(28, 73, 102);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnReports.ForeColor = Color.White;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 642);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(20, 0, 0, 0);
            btnReports.Size = new Size(250, 64);
            btnReports.TabIndex = 11;
            btnReports.Text = "            Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnDamageClaims
            // 
            btnDamageClaims.BackColor = Color.FromArgb(28, 73, 102);
            btnDamageClaims.FlatAppearance.BorderSize = 0;
            btnDamageClaims.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnDamageClaims.FlatStyle = FlatStyle.Flat;
            btnDamageClaims.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDamageClaims.ForeColor = Color.White;
            btnDamageClaims.Image = (Image)resources.GetObject("btnDamageClaims.Image");
            btnDamageClaims.ImageAlign = ContentAlignment.MiddleLeft;
            btnDamageClaims.Location = new Point(0, 572);
            btnDamageClaims.Name = "btnDamageClaims";
            btnDamageClaims.Padding = new Padding(20, 0, 0, 0);
            btnDamageClaims.Size = new Size(247, 64);
            btnDamageClaims.TabIndex = 10;
            btnDamageClaims.Text = "            Damage Claims";
            btnDamageClaims.TextAlign = ContentAlignment.MiddleLeft;
            btnDamageClaims.UseVisualStyleBackColor = false;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.FromArgb(28, 73, 102);
            btnUserManagement.FlatAppearance.BorderSize = 0;
            btnUserManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnUserManagement.FlatStyle = FlatStyle.Flat;
            btnUserManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnUserManagement.ForeColor = Color.White;
            btnUserManagement.Image = (Image)resources.GetObject("btnUserManagement.Image");
            btnUserManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.Location = new Point(3, 432);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Padding = new Padding(20, 0, 0, 0);
            btnUserManagement.Size = new Size(247, 64);
            btnUserManagement.TabIndex = 8;
            btnUserManagement.Text = "            User Management";
            btnUserManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.UseVisualStyleBackColor = false;
            // 
            // btnFleetManagement
            // 
            btnFleetManagement.BackColor = Color.FromArgb(28, 73, 102);
            btnFleetManagement.FlatAppearance.BorderSize = 0;
            btnFleetManagement.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnFleetManagement.FlatStyle = FlatStyle.Flat;
            btnFleetManagement.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnFleetManagement.ForeColor = Color.White;
            btnFleetManagement.Image = (Image)resources.GetObject("btnFleetManagement.Image");
            btnFleetManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnFleetManagement.Location = new Point(3, 362);
            btnFleetManagement.Name = "btnFleetManagement";
            btnFleetManagement.Padding = new Padding(20, 0, 0, 0);
            btnFleetManagement.Size = new Size(247, 64);
            btnFleetManagement.TabIndex = 7;
            btnFleetManagement.Text = "            Vehicle Fleet";
            btnFleetManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnFleetManagement.UseVisualStyleBackColor = false;
            btnFleetManagement.Click += btnFleetManagement_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.FromArgb(28, 73, 102);
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomers.Location = new Point(0, 292);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(20, 0, 0, 0);
            btnCustomers.Size = new Size(250, 64);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "             Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnReservations
            // 
            btnReservations.BackColor = Color.FromArgb(28, 73, 102);
            btnReservations.FlatAppearance.BorderSize = 0;
            btnReservations.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnReservations.FlatStyle = FlatStyle.Flat;
            btnReservations.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnReservations.ForeColor = Color.White;
            btnReservations.Image = (Image)resources.GetObject("btnReservations.Image");
            btnReservations.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservations.Location = new Point(3, 222);
            btnReservations.Name = "btnReservations";
            btnReservations.Padding = new Padding(20, 0, 0, 0);
            btnReservations.Size = new Size(247, 64);
            btnReservations.TabIndex = 4;
            btnReservations.Text = "            Rentals ";
            btnReservations.TextAlign = ContentAlignment.MiddleLeft;
            btnReservations.UseVisualStyleBackColor = false;
            btnReservations.Click += btnReservations_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 247, 250);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1058, 861);
            panelMain.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1308, 861);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnReservations;
        private Button btnCustomers;
        private Button btnDamageClaims;
        private Button btnReports;
        private Button btnLogOut;
        private Panel panelMain;
        private System.Windows.Forms.Timer timer1;
        private Button btnUserManagement;
        private Button btnFleetManagement;
        private Button btnReturns;
    }
}