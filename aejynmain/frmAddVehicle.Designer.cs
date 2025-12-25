namespace aejynmain
{
    partial class frmAddVehicle
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
            panel1 = new Panel();
            label35 = new Label();
            label1 = new Label();
            cmbCategoryName = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtLicensePlate = new TextBox();
            txtMileage = new TextBox();
            txtYear = new TextBox();
            txtVIN = new TextBox();
            txtColor = new TextBox();
            txtSeatingCapacity = new TextBox();
            txtDailyRate = new TextBox();
            txtWeeklyRate = new TextBox();
            txtMonthlyRate = new TextBox();
            cmbTransmission = new ComboBox();
            btnSave = new Button();
            cmbFuelType = new ComboBox();
            cmbStatus = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 124, 165);
            panel1.Controls.Add(label35);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 80);
            panel1.TabIndex = 0;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label35.ForeColor = Color.White;
            label35.Location = new Point(22, 15);
            label35.Name = "label35";
            label35.Size = new Size(202, 46);
            label35.TabIndex = 8;
            label35.Text = "Add Vehicle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 139);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 1;
            label1.Text = "Category Name";
            // 
            // cmbCategoryName
            // 
            cmbCategoryName.Font = new Font("Segoe UI", 12F);
            cmbCategoryName.FormattingEnabled = true;
            cmbCategoryName.Items.AddRange(new object[] { "Sedan", "Hatchback", "SUV", "Truck\t", "Minivan", "Van" });
            cmbCategoryName.Location = new Point(22, 165);
            cmbCategoryName.Name = "cmbCategoryName";
            cmbCategoryName.Size = new Size(176, 36);
            cmbCategoryName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(231, 139);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 4;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(445, 139);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 5;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(663, 139);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 6;
            label4.Text = "License Plate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(889, 139);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 7;
            label5.Text = "Mileage";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(663, 255);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 8;
            label6.Text = "Transmission";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(445, 255);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 9;
            label7.Text = "Color";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(445, 376);
            label8.Name = "label8";
            label8.Size = new Size(106, 23);
            label8.TabIndex = 10;
            label8.Text = "Weekly Rate";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 376);
            label9.Name = "label9";
            label9.Size = new Size(138, 23);
            label9.TabIndex = 11;
            label9.Text = "Seating Capacity";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(22, 255);
            label10.Name = "label10";
            label10.Size = new Size(42, 23);
            label10.TabIndex = 12;
            label10.Text = "Year";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(886, 255);
            label11.Name = "label11";
            label11.Size = new Size(83, 23);
            label11.TabIndex = 13;
            label11.Text = "Fuel Type";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(663, 376);
            label12.Name = "label12";
            label12.Size = new Size(115, 23);
            label12.TabIndex = 14;
            label12.Text = "Monthly Rate";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(231, 255);
            label13.Name = "label13";
            label13.Size = new Size(39, 23);
            label13.TabIndex = 15;
            label13.Text = "VIN";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(889, 376);
            label14.Name = "label14";
            label14.Size = new Size(57, 23);
            label14.TabIndex = 16;
            label14.Text = "Status";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(231, 376);
            label15.Name = "label15";
            label15.Size = new Size(88, 23);
            label15.TabIndex = 17;
            label15.Text = "Daily Rate";
            // 
            // txtMake
            // 
            txtMake.BorderStyle = BorderStyle.FixedSingle;
            txtMake.Location = new Point(231, 165);
            txtMake.Multiline = true;
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(176, 36);
            txtMake.TabIndex = 18;
            // 
            // txtModel
            // 
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Location = new Point(445, 165);
            txtModel.Multiline = true;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(176, 36);
            txtModel.TabIndex = 19;
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.BorderStyle = BorderStyle.FixedSingle;
            txtLicensePlate.Location = new Point(663, 165);
            txtLicensePlate.Multiline = true;
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(176, 36);
            txtLicensePlate.TabIndex = 20;
            // 
            // txtMileage
            // 
            txtMileage.BorderStyle = BorderStyle.FixedSingle;
            txtMileage.Location = new Point(886, 165);
            txtMileage.Multiline = true;
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(176, 36);
            txtMileage.TabIndex = 21;
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Location = new Point(22, 281);
            txtYear.Multiline = true;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(176, 36);
            txtYear.TabIndex = 22;
            // 
            // txtVIN
            // 
            txtVIN.BorderStyle = BorderStyle.FixedSingle;
            txtVIN.Location = new Point(231, 281);
            txtVIN.Multiline = true;
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(176, 36);
            txtVIN.TabIndex = 23;
            // 
            // txtColor
            // 
            txtColor.BorderStyle = BorderStyle.FixedSingle;
            txtColor.Location = new Point(445, 281);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(176, 36);
            txtColor.TabIndex = 24;
            // 
            // txtSeatingCapacity
            // 
            txtSeatingCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtSeatingCapacity.Location = new Point(22, 402);
            txtSeatingCapacity.Multiline = true;
            txtSeatingCapacity.Name = "txtSeatingCapacity";
            txtSeatingCapacity.Size = new Size(176, 36);
            txtSeatingCapacity.TabIndex = 27;
            // 
            // txtDailyRate
            // 
            txtDailyRate.BorderStyle = BorderStyle.FixedSingle;
            txtDailyRate.Location = new Point(231, 402);
            txtDailyRate.Multiline = true;
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(176, 36);
            txtDailyRate.TabIndex = 28;
            // 
            // txtWeeklyRate
            // 
            txtWeeklyRate.BorderStyle = BorderStyle.FixedSingle;
            txtWeeklyRate.Location = new Point(445, 402);
            txtWeeklyRate.Multiline = true;
            txtWeeklyRate.Name = "txtWeeklyRate";
            txtWeeklyRate.Size = new Size(176, 36);
            txtWeeklyRate.TabIndex = 29;
            // 
            // txtMonthlyRate
            // 
            txtMonthlyRate.BorderStyle = BorderStyle.FixedSingle;
            txtMonthlyRate.Location = new Point(663, 402);
            txtMonthlyRate.Multiline = true;
            txtMonthlyRate.Name = "txtMonthlyRate";
            txtMonthlyRate.Size = new Size(176, 36);
            txtMonthlyRate.TabIndex = 30;
            // 
            // cmbTransmission
            // 
            cmbTransmission.Font = new Font("Segoe UI", 12F);
            cmbTransmission.FormattingEnabled = true;
            cmbTransmission.Items.AddRange(new object[] { "Manual ", "Automatic" });
            cmbTransmission.Location = new Point(663, 281);
            cmbTransmission.Name = "cmbTransmission";
            cmbTransmission.Size = new Size(176, 36);
            cmbTransmission.TabIndex = 31;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(58, 124, 165);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(415, 486);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(234, 43);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbFuelType
            // 
            cmbFuelType.Font = new Font("Segoe UI", 12F);
            cmbFuelType.FormattingEnabled = true;
            cmbFuelType.Items.AddRange(new object[] { "Gasoline", "Diesel", "Electric", "Hybrid" });
            cmbFuelType.Location = new Point(886, 281);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(176, 36);
            cmbFuelType.TabIndex = 33;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 12F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Rented", "Reserved", "Maintenance", "Out of service", "Retired/Sold" });
            cmbStatus.Location = new Point(886, 402);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(176, 36);
            cmbStatus.TabIndex = 34;
            // 
            // frmAddVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 570);
            Controls.Add(cmbStatus);
            Controls.Add(cmbFuelType);
            Controls.Add(btnSave);
            Controls.Add(cmbTransmission);
            Controls.Add(txtMonthlyRate);
            Controls.Add(txtWeeklyRate);
            Controls.Add(txtDailyRate);
            Controls.Add(txtSeatingCapacity);
            Controls.Add(txtColor);
            Controls.Add(txtVIN);
            Controls.Add(txtYear);
            Controls.Add(txtMileage);
            Controls.Add(txtLicensePlate);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbCategoryName);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmAddVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddVehicle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label35;
        private Label label1;
        private ComboBox cmbCategoryName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtLicensePlate;
        private TextBox txtMileage;
        private TextBox txtYear;
        private TextBox txtVIN;
        private TextBox txtColor;
        private ComboBox cmbTransmission;
        private TextBox txtFuelType;
        private TextBox txtSeatingCapacity;
        private TextBox txtDailyRate;
        private TextBox txtWeeklyRate;
        private TextBox txtMonthlyRate;
        private ComboBox cmbStatus;
        private Button btnSave;
        private ComboBox cmbFuelType;
    }
}