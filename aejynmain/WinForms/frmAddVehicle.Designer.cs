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
            label16 = new Label();
            txtHourlyRate = new TextBox();
            label17 = new Label();
            txtFeatures = new TextBox();
            pbCarImage = new PictureBox();
            label18 = new Label();
            btnSelectImage = new Button();
            label19 = new Label();
            cmbFuelLevel = new ComboBox();
            label21 = new Label();
            txtInitialCondition = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCarImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 73, 102);
            panel1.Controls.Add(label35);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1391, 80);
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
            label1.Location = new Point(19, 101);
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
            cmbCategoryName.Location = new Point(19, 127);
            cmbCategoryName.Name = "cmbCategoryName";
            cmbCategoryName.Size = new Size(176, 36);
            cmbCategoryName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 101);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 4;
            label2.Text = "Make";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(442, 101);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 5;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(660, 101);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 6;
            label4.Text = "License Plate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(886, 101);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 7;
            label5.Text = "Mileage";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(660, 195);
            label6.Name = "label6";
            label6.Size = new Size(107, 23);
            label6.TabIndex = 8;
            label6.Text = "Transmission";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(442, 195);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 9;
            label7.Text = "Color";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(445, 288);
            label8.Name = "label8";
            label8.Size = new Size(106, 23);
            label8.TabIndex = 10;
            label8.Text = "Weekly Rate";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1098, 195);
            label9.Name = "label9";
            label9.Size = new Size(138, 23);
            label9.TabIndex = 11;
            label9.Text = "Seating Capacity";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(19, 195);
            label10.Name = "label10";
            label10.Size = new Size(42, 23);
            label10.TabIndex = 12;
            label10.Text = "Year";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(883, 195);
            label11.Name = "label11";
            label11.Size = new Size(83, 23);
            label11.TabIndex = 13;
            label11.Text = "Fuel Type";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(663, 288);
            label12.Name = "label12";
            label12.Size = new Size(115, 23);
            label12.TabIndex = 14;
            label12.Text = "Monthly Rate";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(228, 195);
            label13.Name = "label13";
            label13.Size = new Size(39, 23);
            label13.TabIndex = 15;
            label13.Text = "VIN";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(883, 288);
            label14.Name = "label14";
            label14.Size = new Size(57, 23);
            label14.TabIndex = 16;
            label14.Text = "Status";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(231, 288);
            label15.Name = "label15";
            label15.Size = new Size(88, 23);
            label15.TabIndex = 17;
            label15.Text = "Daily Rate";
            // 
            // txtMake
            // 
            txtMake.BorderStyle = BorderStyle.FixedSingle;
            txtMake.Location = new Point(228, 127);
            txtMake.Multiline = true;
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(176, 36);
            txtMake.TabIndex = 18;
            // 
            // txtModel
            // 
            txtModel.BorderStyle = BorderStyle.FixedSingle;
            txtModel.Location = new Point(442, 127);
            txtModel.Multiline = true;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(176, 36);
            txtModel.TabIndex = 19;
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.BorderStyle = BorderStyle.FixedSingle;
            txtLicensePlate.Location = new Point(660, 127);
            txtLicensePlate.Multiline = true;
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(176, 36);
            txtLicensePlate.TabIndex = 20;
            // 
            // txtMileage
            // 
            txtMileage.BorderStyle = BorderStyle.FixedSingle;
            txtMileage.Location = new Point(883, 127);
            txtMileage.Multiline = true;
            txtMileage.Name = "txtMileage";
            txtMileage.Size = new Size(176, 36);
            txtMileage.TabIndex = 21;
            // 
            // txtYear
            // 
            txtYear.BorderStyle = BorderStyle.FixedSingle;
            txtYear.Location = new Point(19, 221);
            txtYear.Multiline = true;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(176, 36);
            txtYear.TabIndex = 22;
            // 
            // txtVIN
            // 
            txtVIN.BorderStyle = BorderStyle.FixedSingle;
            txtVIN.Location = new Point(228, 221);
            txtVIN.Multiline = true;
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(176, 36);
            txtVIN.TabIndex = 23;
            // 
            // txtColor
            // 
            txtColor.BorderStyle = BorderStyle.FixedSingle;
            txtColor.Location = new Point(442, 221);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(176, 36);
            txtColor.TabIndex = 24;
            // 
            // txtSeatingCapacity
            // 
            txtSeatingCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtSeatingCapacity.Location = new Point(1098, 221);
            txtSeatingCapacity.Multiline = true;
            txtSeatingCapacity.Name = "txtSeatingCapacity";
            txtSeatingCapacity.Size = new Size(176, 36);
            txtSeatingCapacity.TabIndex = 27;
            // 
            // txtDailyRate
            // 
            txtDailyRate.BorderStyle = BorderStyle.FixedSingle;
            txtDailyRate.Location = new Point(231, 314);
            txtDailyRate.Multiline = true;
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(176, 36);
            txtDailyRate.TabIndex = 28;
            // 
            // txtWeeklyRate
            // 
            txtWeeklyRate.BorderStyle = BorderStyle.FixedSingle;
            txtWeeklyRate.Location = new Point(445, 314);
            txtWeeklyRate.Multiline = true;
            txtWeeklyRate.Name = "txtWeeklyRate";
            txtWeeklyRate.Size = new Size(176, 36);
            txtWeeklyRate.TabIndex = 29;
            // 
            // txtMonthlyRate
            // 
            txtMonthlyRate.BorderStyle = BorderStyle.FixedSingle;
            txtMonthlyRate.Location = new Point(663, 314);
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
            cmbTransmission.Location = new Point(660, 221);
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
            btnSave.Location = new Point(445, 443);
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
            cmbFuelType.Location = new Point(883, 221);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(176, 36);
            cmbFuelType.TabIndex = 33;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Segoe UI", 12F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Rented", "Reserved", "Maintenance", "Out of service", "Retired/Sold" });
            cmbStatus.Location = new Point(883, 314);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(179, 36);
            cmbStatus.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(22, 288);
            label16.Name = "label16";
            label16.Size = new Size(102, 23);
            label16.TabIndex = 36;
            label16.Text = "Hourly Rate";
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.BorderStyle = BorderStyle.FixedSingle;
            txtHourlyRate.Location = new Point(22, 314);
            txtHourlyRate.Multiline = true;
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(176, 36);
            txtHourlyRate.TabIndex = 37;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(1098, 101);
            label17.Name = "label17";
            label17.Size = new Size(75, 23);
            label17.TabIndex = 38;
            label17.Text = "Features";
            // 
            // txtFeatures
            // 
            txtFeatures.BorderStyle = BorderStyle.FixedSingle;
            txtFeatures.Location = new Point(1098, 127);
            txtFeatures.Multiline = true;
            txtFeatures.Name = "txtFeatures";
            txtFeatures.Size = new Size(176, 36);
            txtFeatures.TabIndex = 39;
            // 
            // pbCarImage
            // 
            pbCarImage.BackColor = Color.White;
            pbCarImage.Location = new Point(1098, 300);
            pbCarImage.Name = "pbCarImage";
            pbCarImage.Size = new Size(281, 186);
            pbCarImage.TabIndex = 40;
            pbCarImage.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(1098, 274);
            label18.Name = "label18";
            label18.Size = new Size(58, 23);
            label18.TabIndex = 41;
            label18.Text = "Image";
            // 
            // btnSelectImage
            // 
            btnSelectImage.BackColor = Color.FromArgb(58, 124, 165);
            btnSelectImage.FlatAppearance.BorderSize = 0;
            btnSelectImage.FlatStyle = FlatStyle.Flat;
            btnSelectImage.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSelectImage.ForeColor = Color.White;
            btnSelectImage.Location = new Point(1164, 492);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(176, 31);
            btnSelectImage.TabIndex = 42;
            btnSelectImage.Text = "Select";
            btnSelectImage.UseVisualStyleBackColor = false;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(22, 377);
            label19.Name = "label19";
            label19.Size = new Size(86, 23);
            label19.TabIndex = 43;
            label19.Text = "Fuel Level";
            // 
            // cmbFuelLevel
            // 
            cmbFuelLevel.Font = new Font("Segoe UI", 12F);
            cmbFuelLevel.FormattingEnabled = true;
            cmbFuelLevel.Items.AddRange(new object[] { "Full", "Half" });
            cmbFuelLevel.Location = new Point(22, 413);
            cmbFuelLevel.Name = "cmbFuelLevel";
            cmbFuelLevel.Size = new Size(179, 36);
            cmbFuelLevel.TabIndex = 44;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(242, 377);
            label21.Name = "label21";
            label21.Size = new Size(132, 23);
            label21.TabIndex = 46;
            label21.Text = "Initial Condition";
            // 
            // txtInitialCondition
            // 
            txtInitialCondition.BorderStyle = BorderStyle.FixedSingle;
            txtInitialCondition.Location = new Point(231, 413);
            txtInitialCondition.Multiline = true;
            txtInitialCondition.Name = "txtInitialCondition";
            txtInitialCondition.Size = new Size(176, 36);
            txtInitialCondition.TabIndex = 47;
            txtInitialCondition.TextChanged += lblInitialCondition_TextChanged;
            // 
            // frmAddVehicle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 546);
            Controls.Add(txtInitialCondition);
            Controls.Add(label21);
            Controls.Add(cmbFuelLevel);
            Controls.Add(label19);
            Controls.Add(btnSelectImage);
            Controls.Add(label18);
            Controls.Add(pbCarImage);
            Controls.Add(txtFeatures);
            Controls.Add(label17);
            Controls.Add(txtHourlyRate);
            Controls.Add(label16);
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
            ((System.ComponentModel.ISupportInitialize)pbCarImage).EndInit();
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
        private Label label16;
        private TextBox txtHourlyRate;
        private Label label17;
        private TextBox txtFeatures;
        private PictureBox pbCarImage;
        private Label label18;
        private Button btnSelectImage;
        private Label label19;
        private ComboBox cmbFuelLevel;
        private Label label21;
        private TextBox txtInitialCondition;
    }
}