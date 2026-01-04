namespace aejynmain.StaffWinforms
{
    partial class StaffMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMainForm));
            panel1 = new Panel();
            btnMaintenance = new Button();
            label1 = new Label();
            btnReservation = new Button();
            btnVehicleFleet = new Button();
            btnReturns = new Button();
            btnLogOut = new Button();
            btnCustomers = new Button();
            btnRentals = new Button();
            pictureBox1 = new PictureBox();
            staffpanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 73, 102);
            panel1.Controls.Add(btnMaintenance);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnReservation);
            panel1.Controls.Add(btnVehicleFleet);
            panel1.Controls.Add(btnReturns);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnCustomers);
            panel1.Controls.Add(btnRentals);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 898);
            panel1.TabIndex = 2;
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
            btnMaintenance.Location = new Point(3, 502);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Padding = new Padding(20, 0, 0, 0);
            btnMaintenance.Size = new Size(247, 64);
            btnMaintenance.TabIndex = 15;
            btnMaintenance.Text = "            Maintenance";
            btnMaintenance.TextAlign = ContentAlignment.MiddleLeft;
            btnMaintenance.UseVisualStyleBackColor = false;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 123);
            label1.Name = "label1";
            label1.Size = new Size(232, 23);
            label1.TabIndex = 0;
            label1.Text = "Welcome back! Rental Agent";
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
            btnReservation.Location = new Point(0, 362);
            btnReservation.Name = "btnReservation";
            btnReservation.Padding = new Padding(20, 0, 0, 0);
            btnReservation.Size = new Size(250, 64);
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
            btnVehicleFleet.Location = new Point(0, 222);
            btnVehicleFleet.Name = "btnVehicleFleet";
            btnVehicleFleet.Padding = new Padding(20, 0, 0, 0);
            btnVehicleFleet.Size = new Size(250, 64);
            btnVehicleFleet.TabIndex = 7;
            btnVehicleFleet.Text = "            Vehicle Fleet";
            btnVehicleFleet.TextAlign = ContentAlignment.MiddleLeft;
            btnVehicleFleet.UseVisualStyleBackColor = false;
            btnVehicleFleet.Click += btnVehicleFleet_Click;
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
            btnReturns.Location = new Point(0, 432);
            btnReturns.Name = "btnReturns";
            btnReturns.Padding = new Padding(20, 0, 0, 0);
            btnReturns.Size = new Size(250, 64);
            btnReturns.TabIndex = 13;
            btnReturns.Text = "            Returns";
            btnReturns.TextAlign = ContentAlignment.MiddleLeft;
            btnReturns.UseVisualStyleBackColor = false;
            btnReturns.Click += btnReturns_Click;
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
            btnLogOut.Location = new Point(0, 572);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(20, 0, 0, 0);
            btnLogOut.Size = new Size(250, 64);
            btnLogOut.TabIndex = 12;
            btnLogOut.Text = "            Log Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = false;
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
            btnCustomers.Location = new Point(0, 152);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(20, 0, 0, 0);
            btnCustomers.Size = new Size(250, 64);
            btnCustomers.TabIndex = 6;
            btnCustomers.Text = "             Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnRentals
            // 
            btnRentals.BackColor = Color.FromArgb(28, 73, 102);
            btnRentals.FlatAppearance.BorderSize = 0;
            btnRentals.FlatAppearance.MouseOverBackColor = Color.FromArgb(23, 58, 82);
            btnRentals.FlatStyle = FlatStyle.Flat;
            btnRentals.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnRentals.ForeColor = Color.White;
            btnRentals.Image = (Image)resources.GetObject("btnRentals.Image");
            btnRentals.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentals.Location = new Point(3, 292);
            btnRentals.Name = "btnRentals";
            btnRentals.Padding = new Padding(20, 0, 0, 0);
            btnRentals.Size = new Size(247, 64);
            btnRentals.TabIndex = 4;
            btnRentals.Text = "            Rentals ";
            btnRentals.TextAlign = ContentAlignment.MiddleLeft;
            btnRentals.UseVisualStyleBackColor = false;
            btnRentals.Click += btnRentals_Click;
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
            // staffpanel
            // 
            staffpanel.Dock = DockStyle.Fill;
            staffpanel.Location = new Point(250, 0);
            staffpanel.Name = "staffpanel";
            staffpanel.Size = new Size(1058, 898);
            staffpanel.TabIndex = 3;
            // 
            // StaffMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 898);
            Controls.Add(staffpanel);
            Controls.Add(panel1);
            Name = "StaffMainForm";
            Text = "StaffMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMaintenance;
        private Label label1;
        private Button btnReservation;
        private Button btnVehicleFleet;
        private Button btnReturns;
        private Button btnLogOut;
        private Button btnCustomers;
        private Button btnRentals;
        private PictureBox pictureBox1;
        private Panel staffpanel;
    }
}