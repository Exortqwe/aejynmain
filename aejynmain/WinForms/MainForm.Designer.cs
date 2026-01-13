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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            btnUserManagement = new Button();
            btnMaintenance = new Button();
            btnReservation = new Button();
            btnVehicleFleet = new Button();
            btnReturns = new Button();
            btnDashboard = new Button();
            btnLogOut = new Button();
            btnReports = new Button();
            btnCustomers = new Button();
            btnReservations = new Button();
            panelMain = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            btnUserManagement.Location = new Point(3, 645);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Padding = new Padding(20, 0, 0, 0);
            btnUserManagement.Size = new Size(244, 64);
            btnUserManagement.TabIndex = 16;
            btnUserManagement.Text = "            User Management";
            btnUserManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.VisibleChanged += MainForm_Load;
            btnUserManagement.Click += btnUserManagement_Click;
            // 
            // btnMaintenance
            // 
            btnMaintenance.BackColor = Color.FromArgb(28, 73, 102);
            btnMaintenance.FlatAppearance.BorderSize = 0;
            btnMaintenance.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Image = (Image)resources.GetObject("btnMaintenance.Image");
            btnMaintenance.ImageAlign = ContentAlignment.MiddleLeft;
            btnMaintenance.Location = new Point(3, 575);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Padding = new Padding(20, 0, 0, 0);
            btnMaintenance.Size = new Size(244, 64);
            btnMaintenance.TabIndex = 15;
            btnMaintenance.Text = "            Maintenance";
            btnMaintenance.TextAlign = ContentAlignment.MiddleLeft;
            btnMaintenance.UseVisualStyleBackColor = false;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.FromArgb(28, 73, 102);
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnReservation.ForeColor = Color.White;
            btnReservation.Image = (Image)resources.GetObject("btnReservation.Image");
            btnReservation.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservation.Location = new Point(3, 435);
            btnReservation.Name = "btnReservation";
            btnReservation.Padding = new Padding(20, 0, 0, 0);
            btnReservation.Size = new Size(247, 64);
            btnReservation.TabIndex = 14;
            btnReservation.Text = "            Reservations";
            btnReservation.TextAlign = ContentAlignment.MiddleLeft;
            btnReservation.UseVisualStyleBackColor = false;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnVehicleFleet
            // 
            btnVehicleFleet.BackColor = Color.FromArgb(28, 73, 102);
            btnVehicleFleet.FlatAppearance.BorderSize = 0;
            btnVehicleFleet.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnVehicleFleet.FlatStyle = FlatStyle.Flat;
            btnVehicleFleet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnVehicleFleet.ForeColor = Color.White;
            btnVehicleFleet.Image = (Image)resources.GetObject("btnVehicleFleet.Image");
            btnVehicleFleet.ImageAlign = ContentAlignment.MiddleLeft;
            btnVehicleFleet.Location = new Point(3, 295);
            btnVehicleFleet.Name = "btnVehicleFleet";
            btnVehicleFleet.Padding = new Padding(20, 0, 0, 0);
            btnVehicleFleet.Size = new Size(244, 64);
            btnVehicleFleet.TabIndex = 7;
            btnVehicleFleet.Text = "            Vehicle Fleet";
            btnVehicleFleet.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicleFleet.UseVisualStyleBackColor = false;
            btnVehicleFleet.Click += btnFleetManagement_Click;
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
            btnReturns.Location = new Point(3, 505);
            btnReturns.Name = "btnReturns";
            btnReturns.Padding = new Padding(20, 0, 0, 0);
            btnReturns.Size = new Size(244, 64);
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
            btnDashboard.Location = new Point(3, 155);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(20, 0, 0, 0);
            btnDashboard.Size = new Size(247, 64);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "            Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.VisibleChanged += MainForm_Load;
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
            btnLogOut.Location = new Point(3, 785);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(20, 0, 0, 0);
            btnLogOut.Size = new Size(247, 64);
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
            btnReports.Location = new Point(3, 715);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(20, 0, 0, 0);
            btnReports.Size = new Size(249, 64);
            btnReports.TabIndex = 11;
            btnReports.Text = "            Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.VisibleChanged += MainForm_Load;
            btnReports.Click += btnReports_Click;
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
            btnCustomers.Location = new Point(3, 225);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(20, 0, 0, 0);
            btnCustomers.Size = new Size(244, 64);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "            Customers";
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
            btnReservations.Location = new Point(3, 365);
            btnReservations.Name = "btnReservations";
            btnReservations.Padding = new Padding(20, 0, 0, 0);
            btnReservations.Size = new Size(247, 64);
            btnReservations.TabIndex = 4;
            btnReservations.Text = "            Rentals ";
            btnReservations.TextAlign = ContentAlignment.MiddleLeft;
            btnReservations.UseVisualStyleBackColor = false;
            btnReservations.Click += btnReservations_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 247, 250);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(252, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1672, 1055);
            panelMain.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(28, 73, 102);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnCustomers);
            flowLayoutPanel1.Controls.Add(btnVehicleFleet);
            flowLayoutPanel1.Controls.Add(btnReservations);
            flowLayoutPanel1.Controls.Add(btnReservation);
            flowLayoutPanel1.Controls.Add(btnReturns);
            flowLayoutPanel1.Controls.Add(btnMaintenance);
            flowLayoutPanel1.Controls.Add(btnUserManagement);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Controls.Add(btnLogOut);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(252, 1055);
            flowLayoutPanel1.TabIndex = 3;
            flowLayoutPanel1.WrapContents = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panelMain);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnDashboard;
        private Button btnReservations;
        private Button btnCustomers;
        private Button btnReports;
        private Button btnLogOut;
        private Panel panelMain;
        private Button btnVehicleFleet;
        private Button btnReturns;
        private Button btnReservation;
        private Button btnMaintenance;
        private Button btnUserManagement;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel UCHeader;
        private Label lblRole;
        private PictureBox pictureBox2;
        private Label lblUserName;
    }
}