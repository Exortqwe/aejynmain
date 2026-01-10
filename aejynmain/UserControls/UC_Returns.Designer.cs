namespace aejynmain.UserControls
{
    partial class UC_Returns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Returns));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel9 = new Panel();
            lblRole = new Label();
            lblUsername = new Label();
            pictureBox7 = new PictureBox();
            label35 = new Label();
            label41 = new Label();
            panel3 = new Panel();
            txtReturnMileage = new TextBox();
            dtpActualReturnDate = new DateTimePicker();
            cmbCondition = new ComboBox();
            label13 = new Label();
            cmbFuelLevel = new ComboBox();
            lblRentalDuration = new Label();
            lblLicensePlate = new Label();
            lblVehicleInspection = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label14 = new Label();
            label15 = new Label();
            gbDamageAssessment = new GroupBox();
            cbPaintDamage = new CheckBox();
            cbScratches = new CheckBox();
            cbTireDamage = new CheckBox();
            cbDents = new CheckBox();
            cbInteriorStains = new CheckBox();
            cbBrokenGlass = new CheckBox();
            label16 = new Label();
            panel2 = new Panel();
            lblOverdueFee = new Label();
            label19 = new Label();
            lblFuelCharges = new Label();
            label11 = new Label();
            lblDepositPaid = new Label();
            label10 = new Label();
            lblBalanceDue = new Label();
            lblDamagesCharges = new Label();
            label18 = new Label();
            label17 = new Label();
            label23 = new Label();
            panel4 = new Panel();
            label12 = new Label();
            label9 = new Label();
            cmbPaymentType = new ComboBox();
            cmbPaymentStatus = new ComboBox();
            label25 = new Label();
            txtAmount = new TextBox();
            cmbPaymentMethod = new ComboBox();
            label24 = new Label();
            btnReturnVehicle = new Button();
            label8 = new Label();
            dgRentedVehicles = new DataGridView();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            gbDamageAssessment.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgRentedVehicles).BeginInit();
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
            panel1.TabIndex = 0;
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
            panel9.TabIndex = 76;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(1494, 69);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(0, 23);
            lblRole.TabIndex = 56;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(1494, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 23);
            lblUsername.TabIndex = 55;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1591, 29);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(69, 68);
            pictureBox7.TabIndex = 54;
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
            label41.Size = new Size(180, 32);
            label41.TabIndex = 44;
            label41.Text = "Return Vehicles";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtReturnMileage);
            panel3.Controls.Add(dtpActualReturnDate);
            panel3.Controls.Add(cmbCondition);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cmbFuelLevel);
            panel3.Controls.Add(lblRentalDuration);
            panel3.Controls.Add(lblLicensePlate);
            panel3.Controls.Add(lblVehicleInspection);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(22, 202);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 212);
            panel3.TabIndex = 2;
            // 
            // txtReturnMileage
            // 
            txtReturnMileage.BorderStyle = BorderStyle.FixedSingle;
            txtReturnMileage.Location = new Point(374, 27);
            txtReturnMileage.Name = "txtReturnMileage";
            txtReturnMileage.Size = new Size(157, 27);
            txtReturnMileage.TabIndex = 16;
            // 
            // dtpActualReturnDate
            // 
            dtpActualReturnDate.CustomFormat = "MM-dd-yyyy hh:mm:tt";
            dtpActualReturnDate.Format = DateTimePickerFormat.Custom;
            dtpActualReturnDate.Location = new Point(175, 95);
            dtpActualReturnDate.Name = "dtpActualReturnDate";
            dtpActualReturnDate.ShowUpDown = true;
            dtpActualReturnDate.Size = new Size(168, 27);
            dtpActualReturnDate.TabIndex = 15;
            // 
            // cmbCondition
            // 
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Items.AddRange(new object[] { "Good", "Excellent", "With Damage", "Needs Inspection" });
            cmbCondition.Location = new Point(4, 160);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(162, 28);
            cmbCondition.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(4, 126);
            label13.Name = "label13";
            label13.Size = new Size(157, 25);
            label13.TabIndex = 12;
            label13.Text = "Return Condition";
            // 
            // cmbFuelLevel
            // 
            cmbFuelLevel.FormattingEnabled = true;
            cmbFuelLevel.Items.AddRange(new object[] { "Full", "3/4", "1/2", "1/4", "Empty" });
            cmbFuelLevel.Location = new Point(375, 95);
            cmbFuelLevel.Name = "cmbFuelLevel";
            cmbFuelLevel.Size = new Size(162, 28);
            cmbFuelLevel.TabIndex = 11;
            cmbFuelLevel.SelectedIndexChanged += cmbFuelLevel_SelectedIndexChanged;
            // 
            // lblRentalDuration
            // 
            lblRentalDuration.AutoSize = true;
            lblRentalDuration.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalDuration.Location = new Point(16, 95);
            lblRentalDuration.Name = "lblRentalDuration";
            lblRentalDuration.Size = new Size(0, 23);
            lblRentalDuration.TabIndex = 9;
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.AutoSize = true;
            lblLicensePlate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicensePlate.Location = new Point(184, 27);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(0, 23);
            lblLicensePlate.TabIndex = 7;
            // 
            // lblVehicleInspection
            // 
            lblVehicleInspection.AutoSize = true;
            lblVehicleInspection.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleInspection.Location = new Point(16, 30);
            lblVehicleInspection.Name = "lblVehicleInspection";
            lblVehicleInspection.Size = new Size(0, 23);
            lblVehicleInspection.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(374, 61);
            label7.Name = "label7";
            label7.Size = new Size(157, 25);
            label7.TabIndex = 5;
            label7.Text = "Return Fuel Level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(374, -1);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 4;
            label6.Text = "Return Mileage";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(173, 61);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 3;
            label5.Text = "Actual Return Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(175, -1);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 2;
            label4.Text = "License Plate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(-1, 61);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 1;
            label3.Text = "Rental Duration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Inspection";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 152);
            label2.Name = "label2";
            label2.Size = new Size(217, 35);
            label2.TabIndex = 1;
            label2.Text = "Return Inspection";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(588, 154);
            label14.Name = "label14";
            label14.Size = new Size(249, 35);
            label14.TabIndex = 3;
            label14.Text = "Damage Assessment";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.GrayText;
            label15.Location = new Point(588, 189);
            label15.Name = "label15";
            label15.Size = new Size(284, 20);
            label15.TabIndex = 5;
            label15.Text = "Document any new damage since pickup ";
            // 
            // gbDamageAssessment
            // 
            gbDamageAssessment.Controls.Add(cbPaintDamage);
            gbDamageAssessment.Controls.Add(cbScratches);
            gbDamageAssessment.Controls.Add(cbTireDamage);
            gbDamageAssessment.Controls.Add(cbDents);
            gbDamageAssessment.Controls.Add(cbInteriorStains);
            gbDamageAssessment.Controls.Add(cbBrokenGlass);
            gbDamageAssessment.Location = new Point(588, 222);
            gbDamageAssessment.Name = "gbDamageAssessment";
            gbDamageAssessment.Size = new Size(369, 192);
            gbDamageAssessment.TabIndex = 6;
            gbDamageAssessment.TabStop = false;
            gbDamageAssessment.Text = "Damages";
            // 
            // cbPaintDamage
            // 
            cbPaintDamage.AutoSize = true;
            cbPaintDamage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbPaintDamage.Location = new Point(203, 135);
            cbPaintDamage.Name = "cbPaintDamage";
            cbPaintDamage.Size = new Size(160, 32);
            cbPaintDamage.TabIndex = 20;
            cbPaintDamage.Text = "Paint Damage";
            cbPaintDamage.UseVisualStyleBackColor = true;
            cbPaintDamage.CheckedChanged += Damage_CheckedChanged;
            // 
            // cbScratches
            // 
            cbScratches.AutoSize = true;
            cbScratches.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbScratches.Location = new Point(15, 31);
            cbScratches.Name = "cbScratches";
            cbScratches.Size = new Size(119, 32);
            cbScratches.TabIndex = 15;
            cbScratches.Text = "Scratches";
            cbScratches.UseVisualStyleBackColor = true;
            cbScratches.CheckedChanged += Damage_CheckedChanged;
            // 
            // cbTireDamage
            // 
            cbTireDamage.AutoSize = true;
            cbTireDamage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTireDamage.Location = new Point(203, 83);
            cbTireDamage.Name = "cbTireDamage";
            cbTireDamage.Size = new Size(149, 32);
            cbTireDamage.TabIndex = 19;
            cbTireDamage.Text = "Tire Damage";
            cbTireDamage.UseVisualStyleBackColor = true;
            cbTireDamage.CheckedChanged += Damage_CheckedChanged;
            // 
            // cbDents
            // 
            cbDents.AutoSize = true;
            cbDents.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbDents.Location = new Point(15, 83);
            cbDents.Name = "cbDents";
            cbDents.Size = new Size(87, 32);
            cbDents.TabIndex = 16;
            cbDents.Text = "Dents";
            cbDents.UseVisualStyleBackColor = true;
            cbDents.CheckedChanged += Damage_CheckedChanged;
            // 
            // cbInteriorStains
            // 
            cbInteriorStains.AutoSize = true;
            cbInteriorStains.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbInteriorStains.Location = new Point(203, 35);
            cbInteriorStains.Name = "cbInteriorStains";
            cbInteriorStains.Size = new Size(160, 32);
            cbInteriorStains.TabIndex = 18;
            cbInteriorStains.Text = "Interior Stains";
            cbInteriorStains.UseVisualStyleBackColor = true;
            cbInteriorStains.CheckedChanged += Damage_CheckedChanged;
            // 
            // cbBrokenGlass
            // 
            cbBrokenGlass.AutoSize = true;
            cbBrokenGlass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbBrokenGlass.Location = new Point(15, 136);
            cbBrokenGlass.Name = "cbBrokenGlass";
            cbBrokenGlass.Size = new Size(152, 32);
            cbBrokenGlass.TabIndex = 17;
            cbBrokenGlass.Text = "Broken Glass";
            cbBrokenGlass.UseVisualStyleBackColor = true;
            cbBrokenGlass.CheckedChanged += Damage_CheckedChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(1293, 154);
            label16.Name = "label16";
            label16.Size = new Size(204, 35);
            label16.TabIndex = 7;
            label16.Text = "Billing Summary";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblOverdueFee);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(lblFuelCharges);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lblDepositPaid);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblBalanceDue);
            panel2.Controls.Add(lblDamagesCharges);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label17);
            panel2.Location = new Point(1293, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 212);
            panel2.TabIndex = 8;
            // 
            // lblOverdueFee
            // 
            lblOverdueFee.AutoSize = true;
            lblOverdueFee.Location = new Point(134, 18);
            lblOverdueFee.Name = "lblOverdueFee";
            lblOverdueFee.Size = new Size(0, 20);
            lblOverdueFee.TabIndex = 25;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(6, 14);
            label19.Name = "label19";
            label19.Size = new Size(127, 25);
            label19.TabIndex = 24;
            label19.Text = "Overdue Fee :";
            // 
            // lblFuelCharges
            // 
            lblFuelCharges.AutoSize = true;
            lblFuelCharges.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuelCharges.Location = new Point(133, 95);
            lblFuelCharges.Name = "lblFuelCharges";
            lblFuelCharges.Size = new Size(0, 23);
            lblFuelCharges.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 93);
            label11.Name = "label11";
            label11.Size = new Size(127, 25);
            label11.TabIndex = 22;
            label11.Text = "Fuel Charges :";
            // 
            // lblDepositPaid
            // 
            lblDepositPaid.AutoSize = true;
            lblDepositPaid.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepositPaid.Location = new Point(139, 133);
            lblDepositPaid.Name = "lblDepositPaid";
            lblDepositPaid.Size = new Size(0, 23);
            lblDepositPaid.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(7, 131);
            label10.Name = "label10";
            label10.Size = new Size(126, 25);
            label10.TabIndex = 20;
            label10.Text = "Deposit Paid :";
            // 
            // lblBalanceDue
            // 
            lblBalanceDue.AutoSize = true;
            lblBalanceDue.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalanceDue.Location = new Point(133, 180);
            lblBalanceDue.Name = "lblBalanceDue";
            lblBalanceDue.Size = new Size(0, 23);
            lblBalanceDue.TabIndex = 19;
            // 
            // lblDamagesCharges
            // 
            lblDamagesCharges.AutoSize = true;
            lblDamagesCharges.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDamagesCharges.Location = new Point(166, 51);
            lblDamagesCharges.Name = "lblDamagesCharges";
            lblDamagesCharges.Size = new Size(0, 23);
            lblDamagesCharges.TabIndex = 18;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(6, 49);
            label18.Name = "label18";
            label18.Size = new Size(160, 25);
            label18.TabIndex = 16;
            label18.Text = "Damage Charges :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(6, 177);
            label17.Name = "label17";
            label17.Size = new Size(123, 25);
            label17.TabIndex = 15;
            label17.Text = "Balance Due :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(977, 154);
            label23.Name = "label23";
            label23.Size = new Size(114, 35);
            label23.TabIndex = 9;
            label23.Text = "Payment";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(cmbPaymentType);
            panel4.Controls.Add(cmbPaymentStatus);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(txtAmount);
            panel4.Controls.Add(cmbPaymentMethod);
            panel4.Controls.Add(label24);
            panel4.Location = new Point(977, 203);
            panel4.Name = "panel4";
            panel4.Size = new Size(282, 211);
            panel4.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 0);
            label12.Name = "label12";
            label12.Size = new Size(105, 20);
            label12.TabIndex = 27;
            label12.Text = "Payment Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 155);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 26;
            label9.Text = "Payment Status";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Items.AddRange(new object[] { "Fullpayment" });
            cmbPaymentType.Location = new Point(12, 21);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(238, 28);
            cmbPaymentType.TabIndex = 25;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Items.AddRange(new object[] { "Paid", "Completed" });
            cmbPaymentStatus.Location = new Point(12, 178);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(238, 28);
            cmbPaymentStatus.TabIndex = 24;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(12, 53);
            label25.Name = "label25";
            label25.Size = new Size(64, 20);
            label25.TabIndex = 23;
            label25.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(12, 74);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(238, 27);
            txtAmount.TabIndex = 22;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Bank Transfer", "Cash\t", "Credit Card", "Gcash", "Paypal" });
            cmbPaymentMethod.Location = new Point(12, 127);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(238, 28);
            cmbPaymentMethod.TabIndex = 21;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(12, 104);
            label24.Name = "label24";
            label24.Size = new Size(127, 20);
            label24.TabIndex = 20;
            label24.Text = "Payment Method";
            // 
            // btnReturnVehicle
            // 
            btnReturnVehicle.BackColor = Color.FromArgb(58, 124, 165);
            btnReturnVehicle.FlatAppearance.BorderSize = 0;
            btnReturnVehicle.FlatStyle = FlatStyle.Flat;
            btnReturnVehicle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnVehicle.ForeColor = Color.White;
            btnReturnVehicle.Location = new Point(695, 928);
            btnReturnVehicle.Name = "btnReturnVehicle";
            btnReturnVehicle.Size = new Size(245, 57);
            btnReturnVehicle.TabIndex = 11;
            btnReturnVehicle.Text = "Return";
            btnReturnVehicle.UseVisualStyleBackColor = false;
            btnReturnVehicle.Click += btnReturnVehicle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(220, 429);
            label8.Name = "label8";
            label8.Size = new Size(194, 35);
            label8.TabIndex = 13;
            label8.Text = "Rented Vehicles";
            // 
            // dgRentedVehicles
            // 
            dgRentedVehicles.BackgroundColor = Color.White;
            dgRentedVehicles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgRentedVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgRentedVehicles.ColumnHeadersHeight = 29;
            dgRentedVehicles.EnableHeadersVisualStyles = false;
            dgRentedVehicles.GridColor = SystemColors.GrayText;
            dgRentedVehicles.Location = new Point(220, 467);
            dgRentedVehicles.Name = "dgRentedVehicles";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgRentedVehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgRentedVehicles.RowHeadersVisible = false;
            dgRentedVehicles.RowHeadersWidth = 51;
            dgRentedVehicles.Size = new Size(1128, 455);
            dgRentedVehicles.TabIndex = 14;
            dgRentedVehicles.CellClick += dgRentedVehicles_CellClick;
            // 
            // UC_Returns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(dgRentedVehicles);
            Controls.Add(label8);
            Controls.Add(btnReturnVehicle);
            Controls.Add(panel4);
            Controls.Add(label23);
            Controls.Add(panel2);
            Controls.Add(label16);
            Controls.Add(gbDamageAssessment);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "UC_Returns";
            Size = new Size(1685, 1219);
            Load += UC_Returns_Load;
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gbDamageAssessment.ResumeLayout(false);
            gbDamageAssessment.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgRentedVehicles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private ComboBox cmbFuelLevel;
        private Label lblRentalDuration;
        private Label lblReturnMileage;
        private Label lblLicensePlate;
        private Label lblVehicleInspection;
        private Label label7;
        private Label label6;
        private ComboBox cmbCondition;
        private Label label13;
        private Label label14;
        private Label label15;
        private GroupBox gbDamageAssessment;
        private Label label16;
        private Panel panel2;
        private Label lblBalanceDue;
        private Label lblDamagesCharges;
        private Label label18;
        private Label label17;
        private Label label23;
        private Panel panel4;
        private Label label24;
        private Label label25;
        private TextBox txtAmount;
        private ComboBox cmbPaymentMethod;
        private Button btnReturnVehicle;
        private Label label8;
        private DateTimePicker dtpActualReturnDate;
        private DataGridView dgRentedVehicles;
        private TextBox txtReturnMileage;
        private CheckBox cbPaintDamage;
        private CheckBox cbScratches;
        private CheckBox cbTireDamage;
        private CheckBox cbDents;
        private CheckBox cbInteriorStains;
        private CheckBox cbBrokenGlass;
        private Label label10;
        private Label lblDepositPaid;
        private Label label11;
        private Label lblFuelCharges;
        private ComboBox cmbPaymentType;
        private ComboBox cmbPaymentStatus;
        private Label label12;
        private Label label9;
        private Label lblOverdueFee;
        private Label label19;
        private Panel panel9;
        private Label label35;
        private Label label41;
        private Label lblRole;
        private Label lblUsername;
        private PictureBox pictureBox7;
    }
}
