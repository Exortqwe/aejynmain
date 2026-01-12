namespace aejynmain.UserControls
{
    partial class UC_Reservations
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Reservations));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel9 = new Panel();
            lblRole = new Label();
            lblUsername = new Label();
            pictureBox7 = new PictureBox();
            label35 = new Label();
            label41 = new Label();
            panel5 = new Panel();
            lblTotalPrice = new Label();
            lblRate = new Label();
            lblDays = new Label();
            lblDates = new Label();
            lblVehicle = new Label();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            panel4 = new Panel();
            dtpReturnTime = new DateTimePicker();
            dtpPickupTime = new DateTimePicker();
            dtpReturnDate = new DateTimePicker();
            dtpPickUpDate = new DateTimePicker();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            groupBox2 = new GroupBox();
            lblAddress = new Label();
            lblContactNumber = new Label();
            lblLicenseNumber = new Label();
            lblFullName = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            label20 = new Label();
            label34 = new Label();
            dgAvailableVehicles = new DataGridView();
            btnConfirmReservation = new Button();
            label36 = new Label();
            panel7 = new Panel();
            label40 = new Label();
            cmbPaymentStatus = new ComboBox();
            txtAmount = new TextBox();
            label39 = new Label();
            label38 = new Label();
            label37 = new Label();
            cmbPaymentMethod = new ComboBox();
            cmbPaymentType = new ComboBox();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAvailableVehicles).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 73, 102);
            panel1.Controls.Add(panel9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 112);
            panel1.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(28, 73, 102);
            panel9.Controls.Add(lblRole);
            panel9.Controls.Add(lblUsername);
            panel9.Controls.Add(pictureBox7);
            panel9.Controls.Add(label35);
            panel9.Controls.Add(label41);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1685, 112);
            panel9.TabIndex = 75;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(1494, 69);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(0, 23);
            lblRole.TabIndex = 59;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(1494, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 23);
            lblUsername.TabIndex = 58;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1591, 29);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(69, 68);
            pictureBox7.TabIndex = 57;
            pictureBox7.TabStop = false;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label35.ForeColor = Color.White;
            label35.Location = new Point(3, 0);
            label35.Name = "label35";
            label35.Size = new Size(569, 46);
            label35.TabIndex = 45;
            label35.Text = "Vehicle Rental Management System";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label41.ForeColor = SystemColors.ControlLight;
            label41.Location = new Point(3, 60);
            label41.Name = "label41";
            label41.Size = new Size(159, 32);
            label41.TabIndex = 44;
            label41.Text = "Reservations ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblTotalPrice);
            panel5.Controls.Add(lblRate);
            panel5.Controls.Add(lblDays);
            panel5.Controls.Add(lblDates);
            panel5.Controls.Add(lblVehicle);
            panel5.Controls.Add(label33);
            panel5.Controls.Add(label32);
            panel5.Controls.Add(label31);
            panel5.Controls.Add(label30);
            panel5.Controls.Add(label29);
            panel5.Location = new Point(1269, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(394, 217);
            panel5.TabIndex = 25;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(107, 182);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(0, 20);
            lblTotalPrice.TabIndex = 9;
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(75, 140);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(0, 20);
            lblRate.TabIndex = 8;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(73, 102);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(0, 20);
            lblDays.TabIndex = 7;
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Location = new Point(88, 61);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(0, 20);
            lblDates.TabIndex = 6;
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Location = new Point(94, 16);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(0, 20);
            lblVehicle.TabIndex = 5;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(10, 180);
            label33.Name = "label33";
            label33.Size = new Size(102, 23);
            label33.TabIndex = 4;
            label33.Text = "Total Price : ";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(10, 140);
            label32.Name = "label32";
            label32.Size = new Size(59, 23);
            label32.TabIndex = 3;
            label32.Text = "Rate : ";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.Location = new Point(10, 99);
            label31.Name = "label31";
            label31.Size = new Size(61, 23);
            label31.TabIndex = 2;
            label31.Text = "Days : ";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(10, 58);
            label30.Name = "label30";
            label30.Size = new Size(67, 23);
            label30.TabIndex = 1;
            label30.Text = "Dates : ";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(10, 13);
            label29.Name = "label29";
            label29.Size = new Size(78, 23);
            label29.TabIndex = 0;
            label29.Text = "Vehicle : ";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(1269, 161);
            label28.Name = "label28";
            label28.Size = new Size(196, 35);
            label28.TabIndex = 26;
            label28.Text = "Order Summary";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dtpReturnTime);
            panel4.Controls.Add(dtpPickupTime);
            panel4.Controls.Add(dtpReturnDate);
            panel4.Controls.Add(dtpPickUpDate);
            panel4.Controls.Add(label27);
            panel4.Controls.Add(label26);
            panel4.Location = new Point(572, 205);
            panel4.Name = "panel4";
            panel4.Size = new Size(310, 217);
            panel4.TabIndex = 24;
            // 
            // dtpReturnTime
            // 
            dtpReturnTime.Format = DateTimePickerFormat.Time;
            dtpReturnTime.Location = new Point(159, 136);
            dtpReturnTime.Name = "dtpReturnTime";
            dtpReturnTime.ShowUpDown = true;
            dtpReturnTime.Size = new Size(135, 27);
            dtpReturnTime.TabIndex = 5;
            dtpReturnTime.ValueChanged += dtpReturnTime_ValueChanged;
            // 
            // dtpPickupTime
            // 
            dtpPickupTime.Format = DateTimePickerFormat.Time;
            dtpPickupTime.Location = new Point(159, 57);
            dtpPickupTime.Name = "dtpPickupTime";
            dtpPickupTime.ShowUpDown = true;
            dtpPickupTime.Size = new Size(135, 27);
            dtpPickupTime.TabIndex = 4;
            dtpPickupTime.ValueChanged += dtpPickupTime_ValueChanged;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.CustomFormat = "MM-dd-yyyy";
            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.Location = new Point(21, 136);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(121, 27);
            dtpReturnDate.TabIndex = 3;
            dtpReturnDate.ValueChanged += dtpReturnDate_ValueChanged;
            // 
            // dtpPickUpDate
            // 
            dtpPickUpDate.CustomFormat = "MM-dd-yyyy";
            dtpPickUpDate.Format = DateTimePickerFormat.Custom;
            dtpPickUpDate.Location = new Point(21, 57);
            dtpPickUpDate.Name = "dtpPickUpDate";
            dtpPickUpDate.Size = new Size(121, 27);
            dtpPickUpDate.TabIndex = 2;
            dtpPickUpDate.ValueChanged += dtpPickUpDate_ValueChanged;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(13, 113);
            label27.Name = "label27";
            label27.Size = new Size(154, 20);
            label27.TabIndex = 1;
            label27.Text = "Return Date and Time";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(13, 32);
            label26.Name = "label26";
            label26.Size = new Size(160, 20);
            label26.TabIndex = 0;
            label26.Text = "Pick-up Date and Time";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(572, 161);
            label25.Name = "label25";
            label25.Size = new Size(143, 35);
            label25.TabIndex = 23;
            label25.Text = "Select Date";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(lblAddress);
            groupBox2.Controls.Add(lblContactNumber);
            groupBox2.Controls.Add(lblLicenseNumber);
            groupBox2.Controls.Add(lblFullName);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label21);
            groupBox2.Location = new Point(33, 235);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(502, 187);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Customer Info";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(95, 160);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(0, 20);
            lblAddress.TabIndex = 7;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Location = new Point(163, 127);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(0, 20);
            lblContactNumber.TabIndex = 6;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Location = new Point(158, 87);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(0, 20);
            lblLicenseNumber.TabIndex = 5;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(160, 44);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(0, 20);
            lblFullName.TabIndex = 4;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label24.Location = new Point(10, 158);
            label24.Name = "label24";
            label24.Size = new Size(79, 23);
            label24.TabIndex = 3;
            label24.Text = "Address :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label23.Location = new Point(10, 124);
            label23.Name = "label23";
            label23.Size = new Size(147, 23);
            label23.TabIndex = 2;
            label23.Text = "Contact Number :";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label22.Location = new Point(10, 84);
            label22.Name = "label22";
            label22.Size = new Size(142, 23);
            label22.TabIndex = 1;
            label22.Text = "License Number :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label21.Location = new Point(10, 41);
            label21.Name = "label21";
            label21.Size = new Size(144, 23);
            label21.TabIndex = 0;
            label21.Text = "Customer Name :";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(58, 124, 165);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 32;
            btnRefresh.Location = new Point(490, 205);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(45, 27);
            btnRefresh.TabIndex = 21;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(33, 205);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(407, 27);
            txtSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(58, 124, 165);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 32;
            btnSearch.Location = new Point(439, 205);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(45, 27);
            btnSearch.TabIndex = 19;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(33, 161);
            label20.Name = "label20";
            label20.Size = new Size(208, 35);
            label20.TabIndex = 18;
            label20.Text = "Search Customer";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.Location = new Point(33, 425);
            label34.Name = "label34";
            label34.Size = new Size(218, 35);
            label34.TabIndex = 29;
            label34.Text = "Available Vehicles";
            // 
            // dgAvailableVehicles
            // 
            dgAvailableVehicles.BackgroundColor = Color.White;
            dgAvailableVehicles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgAvailableVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgAvailableVehicles.ColumnHeadersHeight = 29;
            dgAvailableVehicles.EnableHeadersVisualStyles = false;
            dgAvailableVehicles.GridColor = SystemColors.GrayText;
            dgAvailableVehicles.Location = new Point(33, 462);
            dgAvailableVehicles.Name = "dgAvailableVehicles";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgAvailableVehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgAvailableVehicles.RowHeadersVisible = false;
            dgAvailableVehicles.RowHeadersWidth = 51;
            dgAvailableVehicles.Size = new Size(1630, 455);
            dgAvailableVehicles.TabIndex = 30;
            dgAvailableVehicles.CellClick += dgAvailableVehicles_CellClick;
            dgAvailableVehicles.CellContentClick += dgAvailableVehicles_CellContentClick;
            // 
            // btnConfirmReservation
            // 
            btnConfirmReservation.BackColor = Color.FromArgb(58, 124, 165);
            btnConfirmReservation.FlatAppearance.BorderSize = 0;
            btnConfirmReservation.FlatStyle = FlatStyle.Flat;
            btnConfirmReservation.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmReservation.ForeColor = Color.White;
            btnConfirmReservation.Location = new Point(688, 923);
            btnConfirmReservation.Name = "btnConfirmReservation";
            btnConfirmReservation.Size = new Size(296, 52);
            btnConfirmReservation.TabIndex = 32;
            btnConfirmReservation.Text = "Confirm Reservation";
            btnConfirmReservation.UseVisualStyleBackColor = false;
            btnConfirmReservation.Click += btnConfirmReservation_Click;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(921, 161);
            label36.Name = "label36";
            label36.Size = new Size(189, 35);
            label36.TabIndex = 34;
            label36.Text = "Select Payment";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label40);
            panel7.Controls.Add(cmbPaymentStatus);
            panel7.Controls.Add(txtAmount);
            panel7.Controls.Add(label39);
            panel7.Controls.Add(label38);
            panel7.Controls.Add(label37);
            panel7.Controls.Add(cmbPaymentMethod);
            panel7.Controls.Add(cmbPaymentType);
            panel7.Location = new Point(921, 205);
            panel7.Name = "panel7";
            panel7.Size = new Size(312, 217);
            panel7.TabIndex = 33;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(15, 160);
            label40.Name = "label40";
            label40.Size = new Size(109, 20);
            label40.TabIndex = 9;
            label40.Text = "Payment Status";
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Items.AddRange(new object[] { "Complete", "Incomplete" });
            cmbPaymentStatus.Location = new Point(15, 183);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(267, 28);
            cmbPaymentStatus.TabIndex = 8;
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(15, 78);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(267, 27);
            txtAmount.TabIndex = 7;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(15, 55);
            label39.Name = "label39";
            label39.Size = new Size(62, 20);
            label39.TabIndex = 6;
            label39.Text = "Amount";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(15, 0);
            label38.Name = "label38";
            label38.Size = new Size(100, 20);
            label38.TabIndex = 5;
            label38.Text = "Payment Type";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(15, 108);
            label37.Name = "label37";
            label37.Size = new Size(121, 20);
            label37.TabIndex = 4;
            label37.Text = "Payment Method";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash ", "Gcash" });
            cmbPaymentMethod.Location = new Point(15, 131);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(267, 28);
            cmbPaymentMethod.TabIndex = 1;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Items.AddRange(new object[] { "Deposit", "Partial", "Full" });
            cmbPaymentType.Location = new Point(15, 24);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(267, 28);
            cmbPaymentType.TabIndex = 0;
            // 
            // UC_Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(label36);
            Controls.Add(panel7);
            Controls.Add(btnConfirmReservation);
            Controls.Add(dgAvailableVehicles);
            Controls.Add(label34);
            Controls.Add(panel5);
            Controls.Add(label28);
            Controls.Add(panel4);
            Controls.Add(label25);
            Controls.Add(groupBox2);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(label20);
            Controls.Add(panel1);
            Name = "UC_Reservations";
            Size = new Size(1685, 1219);
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgAvailableVehicles).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Label lblTotalPrice;
        private Label lblRate;
        private Label lblDays;
        private Label lblDates;
        private Label lblVehicle;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Panel panel4;
        private DateTimePicker dtpReturnDate;
        private DateTimePicker dtpPickUpDate;
        private Label label27;
        private Label label26;
        private Label label25;
        private GroupBox groupBox2;
        private Label lblAddress;
        private Label lblContactNumber;
        private Label lblLicenseNumber;
        private Label lblFullName;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Label label20;
        private Label label34;
        private DataGridView dgAvailableVehicles;
        private Button btnConfirmReservation;
        private Label label36;
        private Panel panel7;
        private Label label40;
        private ComboBox cmbPaymentStatus;
        private TextBox txtAmount;
        private Label label39;
        private Label label38;
        private Label label37;
        private ComboBox cmbPaymentMethod;
        private ComboBox cmbPaymentType;
        private DateTimePicker dtpPickupTime;
        private DateTimePicker dtpReturnTime;
        private Panel panel9;
        private Label label35;
        private Label label41;
        private Label lblRole;
        private Label lblUsername;
        private PictureBox pictureBox7;
    }
}
