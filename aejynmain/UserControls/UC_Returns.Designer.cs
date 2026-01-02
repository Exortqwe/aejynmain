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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label35 = new Label();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            gbCleanliness = new GroupBox();
            rbAllAccessoriesReturned = new RadioButton();
            rbInteriorClean = new RadioButton();
            rbNoSmokingViolations = new RadioButton();
            cmbCondition = new ComboBox();
            label13 = new Label();
            cmbFuelLevel = new ComboBox();
            lblRentalDuration = new Label();
            lblMileageReading = new Label();
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
            rbPaintDamage = new RadioButton();
            rbTireDamage = new RadioButton();
            rbInteriorStains = new RadioButton();
            rbBrokenGlass = new RadioButton();
            rbDents = new RadioButton();
            rbScratches = new RadioButton();
            label16 = new Label();
            panel2 = new Panel();
            lblTotalBilling = new Label();
            lblDamagesCharges = new Label();
            lblRentalDays = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label23 = new Label();
            panel4 = new Panel();
            label25 = new Label();
            txtAmount = new TextBox();
            cmbPaymentMethod = new ComboBox();
            label24 = new Label();
            btnConfirm = new Button();
            label8 = new Label();
            dgRentedVehicles = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            gbCleanliness.SuspendLayout();
            gbDamageAssessment.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgRentedVehicles).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 124, 165);
            panel1.Controls.Add(label35);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1509, 75);
            panel1.TabIndex = 0;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label35.ForeColor = Color.White;
            label35.Location = new Point(22, 15);
            label35.Name = "label35";
            label35.Size = new Size(242, 46);
            label35.TabIndex = 2;
            label35.Text = "Vehicle Return";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(gbCleanliness);
            panel3.Controls.Add(cmbCondition);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cmbFuelLevel);
            panel3.Controls.Add(lblRentalDuration);
            panel3.Controls.Add(lblMileageReading);
            panel3.Controls.Add(lblLicensePlate);
            panel3.Controls.Add(lblVehicleInspection);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(22, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 212);
            panel3.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Location = new Point(167, 101);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // gbCleanliness
            // 
            gbCleanliness.Controls.Add(rbAllAccessoriesReturned);
            gbCleanliness.Controls.Add(rbInteriorClean);
            gbCleanliness.Controls.Add(rbNoSmokingViolations);
            gbCleanliness.Location = new Point(341, 56);
            gbCleanliness.Name = "gbCleanliness";
            gbCleanliness.Size = new Size(206, 155);
            gbCleanliness.TabIndex = 14;
            gbCleanliness.TabStop = false;
            // 
            // rbAllAccessoriesReturned
            // 
            rbAllAccessoriesReturned.AutoSize = true;
            rbAllAccessoriesReturned.Location = new Point(6, 125);
            rbAllAccessoriesReturned.Name = "rbAllAccessoriesReturned";
            rbAllAccessoriesReturned.Size = new Size(192, 24);
            rbAllAccessoriesReturned.TabIndex = 16;
            rbAllAccessoriesReturned.TabStop = true;
            rbAllAccessoriesReturned.Text = "All Accessories Returned";
            rbAllAccessoriesReturned.UseVisualStyleBackColor = true;
            // 
            // rbInteriorClean
            // 
            rbInteriorClean.AutoSize = true;
            rbInteriorClean.Location = new Point(6, 33);
            rbInteriorClean.Name = "rbInteriorClean";
            rbInteriorClean.Size = new Size(131, 24);
            rbInteriorClean.TabIndex = 14;
            rbInteriorClean.TabStop = true;
            rbInteriorClean.Text = "Interior is clean";
            rbInteriorClean.UseVisualStyleBackColor = true;
            // 
            // rbNoSmokingViolations
            // 
            rbNoSmokingViolations.AutoSize = true;
            rbNoSmokingViolations.Location = new Point(6, 79);
            rbNoSmokingViolations.Name = "rbNoSmokingViolations";
            rbNoSmokingViolations.Size = new Size(182, 24);
            rbNoSmokingViolations.TabIndex = 15;
            rbNoSmokingViolations.TabStop = true;
            rbNoSmokingViolations.Text = "No Smoking Violations";
            rbNoSmokingViolations.UseVisualStyleBackColor = true;
            // 
            // cmbCondition
            // 
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Items.AddRange(new object[] { "Empty\t", "Half", "Full" });
            cmbCondition.Location = new Point(173, 169);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(162, 28);
            cmbCondition.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(173, 135);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 12;
            label13.Text = "Condition";
            // 
            // cmbFuelLevel
            // 
            cmbFuelLevel.FormattingEnabled = true;
            cmbFuelLevel.Items.AddRange(new object[] { "Empty\t", "Half", "Full" });
            cmbFuelLevel.Location = new Point(4, 169);
            cmbFuelLevel.Name = "cmbFuelLevel";
            cmbFuelLevel.Size = new Size(162, 28);
            cmbFuelLevel.TabIndex = 11;
            // 
            // lblRentalDuration
            // 
            lblRentalDuration.AutoSize = true;
            lblRentalDuration.Location = new Point(3, 98);
            lblRentalDuration.Name = "lblRentalDuration";
            lblRentalDuration.Size = new Size(58, 20);
            lblRentalDuration.TabIndex = 9;
            lblRentalDuration.Text = "label11";
            // 
            // lblMileageReading
            // 
            lblMileageReading.AutoSize = true;
            lblMileageReading.Location = new Point(328, 37);
            lblMileageReading.Name = "lblMileageReading";
            lblMileageReading.Size = new Size(58, 20);
            lblMileageReading.TabIndex = 8;
            lblMileageReading.Text = "label10";
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.AutoSize = true;
            lblLicensePlate.Location = new Point(173, 36);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(50, 20);
            lblLicensePlate.TabIndex = 7;
            lblLicensePlate.Text = "label9";
            // 
            // lblVehicleInspection
            // 
            lblVehicleInspection.AutoSize = true;
            lblVehicleInspection.Location = new Point(3, 37);
            lblVehicleInspection.Name = "lblVehicleInspection";
            lblVehicleInspection.Size = new Size(50, 20);
            lblVehicleInspection.TabIndex = 6;
            lblVehicleInspection.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 135);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 5;
            label7.Text = "Fuel Level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(319, 0);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 4;
            label6.Text = "Mileage Reading";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(173, 61);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 3;
            label5.Text = "Return Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(173, -1);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 2;
            label4.Text = "License Plate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 61);
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
            label2.Location = new Point(22, 86);
            label2.Name = "label2";
            label2.Size = new Size(217, 35);
            label2.TabIndex = 1;
            label2.Text = "Return Inspection";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(588, 88);
            label14.Name = "label14";
            label14.Size = new Size(249, 35);
            label14.TabIndex = 3;
            label14.Text = "Damage Assessment";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.GrayText;
            label15.Location = new Point(588, 123);
            label15.Name = "label15";
            label15.Size = new Size(284, 20);
            label15.TabIndex = 5;
            label15.Text = "Document any new damage since pickup ";
            // 
            // gbDamageAssessment
            // 
            gbDamageAssessment.Controls.Add(rbPaintDamage);
            gbDamageAssessment.Controls.Add(rbTireDamage);
            gbDamageAssessment.Controls.Add(rbInteriorStains);
            gbDamageAssessment.Controls.Add(rbBrokenGlass);
            gbDamageAssessment.Controls.Add(rbDents);
            gbDamageAssessment.Controls.Add(rbScratches);
            gbDamageAssessment.Location = new Point(588, 156);
            gbDamageAssessment.Name = "gbDamageAssessment";
            gbDamageAssessment.Size = new Size(369, 192);
            gbDamageAssessment.TabIndex = 6;
            gbDamageAssessment.TabStop = false;
            gbDamageAssessment.Text = "Damages";
            // 
            // rbPaintDamage
            // 
            rbPaintDamage.AutoSize = true;
            rbPaintDamage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbPaintDamage.Location = new Point(205, 136);
            rbPaintDamage.Name = "rbPaintDamage";
            rbPaintDamage.Size = new Size(159, 32);
            rbPaintDamage.TabIndex = 5;
            rbPaintDamage.TabStop = true;
            rbPaintDamage.Text = "Paint Damage";
            rbPaintDamage.UseVisualStyleBackColor = true;
            // 
            // rbTireDamage
            // 
            rbTireDamage.AutoSize = true;
            rbTireDamage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbTireDamage.Location = new Point(205, 85);
            rbTireDamage.Name = "rbTireDamage";
            rbTireDamage.Size = new Size(148, 32);
            rbTireDamage.TabIndex = 4;
            rbTireDamage.TabStop = true;
            rbTireDamage.Text = "Tire Damage";
            rbTireDamage.UseVisualStyleBackColor = true;
            // 
            // rbInteriorStains
            // 
            rbInteriorStains.AutoSize = true;
            rbInteriorStains.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbInteriorStains.Location = new Point(205, 30);
            rbInteriorStains.Name = "rbInteriorStains";
            rbInteriorStains.Size = new Size(159, 32);
            rbInteriorStains.TabIndex = 3;
            rbInteriorStains.TabStop = true;
            rbInteriorStains.Text = "Interior Stains";
            rbInteriorStains.UseVisualStyleBackColor = true;
            // 
            // rbBrokenGlass
            // 
            rbBrokenGlass.AutoSize = true;
            rbBrokenGlass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbBrokenGlass.Location = new Point(15, 136);
            rbBrokenGlass.Name = "rbBrokenGlass";
            rbBrokenGlass.Size = new Size(151, 32);
            rbBrokenGlass.TabIndex = 2;
            rbBrokenGlass.TabStop = true;
            rbBrokenGlass.Text = "Broken Glass";
            rbBrokenGlass.UseVisualStyleBackColor = true;
            // 
            // rbDents
            // 
            rbDents.AutoSize = true;
            rbDents.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbDents.Location = new Point(15, 85);
            rbDents.Name = "rbDents";
            rbDents.Size = new Size(86, 32);
            rbDents.TabIndex = 1;
            rbDents.TabStop = true;
            rbDents.Text = "Dents";
            rbDents.UseVisualStyleBackColor = true;
            // 
            // rbScratches
            // 
            rbScratches.AutoSize = true;
            rbScratches.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rbScratches.Location = new Point(15, 30);
            rbScratches.Name = "rbScratches";
            rbScratches.Size = new Size(118, 32);
            rbScratches.TabIndex = 0;
            rbScratches.TabStop = true;
            rbScratches.Text = "Scratches";
            rbScratches.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(1200, 88);
            label16.Name = "label16";
            label16.Size = new Size(204, 35);
            label16.TabIndex = 7;
            label16.Text = "Billing Summary";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTotalBilling);
            panel2.Controls.Add(lblDamagesCharges);
            panel2.Controls.Add(lblRentalDays);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label17);
            panel2.Location = new Point(1200, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 192);
            panel2.TabIndex = 8;
            // 
            // lblTotalBilling
            // 
            lblTotalBilling.AutoSize = true;
            lblTotalBilling.Location = new Point(128, 146);
            lblTotalBilling.Name = "lblTotalBilling";
            lblTotalBilling.Size = new Size(58, 20);
            lblTotalBilling.TabIndex = 19;
            lblTotalBilling.Text = "label22";
            // 
            // lblDamagesCharges
            // 
            lblDamagesCharges.AutoSize = true;
            lblDamagesCharges.Location = new Point(169, 88);
            lblDamagesCharges.Name = "lblDamagesCharges";
            lblDamagesCharges.Size = new Size(58, 20);
            lblDamagesCharges.TabIndex = 18;
            lblDamagesCharges.Text = "label21";
            // 
            // lblRentalDays
            // 
            lblRentalDays.AutoSize = true;
            lblRentalDays.Location = new Point(127, 22);
            lblRentalDays.Name = "lblRentalDays";
            lblRentalDays.Size = new Size(58, 20);
            lblRentalDays.TabIndex = 15;
            lblRentalDays.Text = "label20";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(3, 18);
            label19.Name = "label19";
            label19.Size = new Size(118, 25);
            label19.TabIndex = 17;
            label19.Text = "Rental Days :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(3, 84);
            label18.Name = "label18";
            label18.Size = new Size(160, 25);
            label18.TabIndex = 16;
            label18.Text = "Damage Charges :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(3, 142);
            label17.Name = "label17";
            label17.Size = new Size(123, 25);
            label17.TabIndex = 15;
            label17.Text = "Balance Due :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(990, 88);
            label23.Name = "label23";
            label23.Size = new Size(114, 35);
            label23.TabIndex = 9;
            label23.Text = "Payment";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label25);
            panel4.Controls.Add(txtAmount);
            panel4.Controls.Add(cmbPaymentMethod);
            panel4.Controls.Add(label24);
            panel4.Location = new Point(977, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 192);
            panel4.TabIndex = 10;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(12, 19);
            label25.Name = "label25";
            label25.Size = new Size(80, 25);
            label25.TabIndex = 23;
            label25.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.FixedSingle;
            txtAmount.Location = new Point(12, 53);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(174, 27);
            txtAmount.TabIndex = 22;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Bank Transfer", "Cash\t", "Credit Card", "Gcash", "Paypal" });
            cmbPaymentMethod.Location = new Point(12, 140);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(174, 28);
            cmbPaymentMethod.TabIndex = 21;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(12, 108);
            label24.Name = "label24";
            label24.Size = new Size(155, 25);
            label24.TabIndex = 20;
            label24.Text = "Payment Method";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(58, 124, 165);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(617, 860);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(245, 57);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 361);
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
            dgRentedVehicles.Location = new Point(22, 399);
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
            dgRentedVehicles.Size = new Size(1471, 455);
            dgRentedVehicles.TabIndex = 14;
            // 
            // UC_Returns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(dgRentedVehicles);
            Controls.Add(label8);
            Controls.Add(btnConfirm);
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
            Size = new Size(1509, 1219);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gbCleanliness.ResumeLayout(false);
            gbCleanliness.PerformLayout();
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
        private Label label35;
        private Panel panel3;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private ComboBox cmbFuelLevel;
        private Label lblRentalDuration;
        private Label lblMileageReading;
        private Label lblLicensePlate;
        private Label lblVehicleInspection;
        private Label label7;
        private Label label6;
        private ComboBox cmbCondition;
        private Label label13;
        private GroupBox gbCleanliness;
        private RadioButton rbInteriorClean;
        private RadioButton rbNoSmokingViolations;
        private RadioButton rbAllAccessoriesReturned;
        private Label label14;
        private Label label15;
        private GroupBox gbDamageAssessment;
        private RadioButton rbPaintDamage;
        private RadioButton rbTireDamage;
        private RadioButton rbInteriorStains;
        private RadioButton rbBrokenGlass;
        private RadioButton rbDents;
        private RadioButton rbScratches;
        private Label label16;
        private Panel panel2;
        private Label lblTotalBilling;
        private Label lblDamagesCharges;
        private Label lblRentalDays;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label23;
        private Panel panel4;
        private Label label24;
        private Label label25;
        private TextBox txtAmount;
        private ComboBox cmbPaymentMethod;
        private Button btnConfirm;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgRentedVehicles;
    }
}
