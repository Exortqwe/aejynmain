namespace aejynmain.UserControls
{
    partial class UC_Reports
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label12 = new Label();
            panel9 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            lblFleetRate = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            lblRevenuePerVehicle = new Label();
            label6 = new Label();
            panel3 = new Panel();
            lblAverageRentalRate = new Label();
            label9 = new Label();
            panel4 = new Panel();
            lblCustomerRetentionRate = new Label();
            label13 = new Label();
            panel5 = new Panel();
            dgFleetAvailabilityStatus = new DataGridView();
            label14 = new Label();
            panel6 = new Panel();
            lblVehiclePercentage3 = new Label();
            lblVehiclePercentage2 = new Label();
            lblVehiclePercentage1 = new Label();
            lblVehicle3 = new Label();
            lblVehicle2 = new Label();
            lblVehicle1 = new Label();
            label15 = new Label();
            panel7 = new Panel();
            label11 = new Label();
            lblAverageDelay = new Label();
            label5 = new Label();
            lblLateReturn = new Label();
            label16 = new Label();
            panel8 = new Panel();
            dgRentalScheduleAndDurationAnalysis = new DataGridView();
            label2 = new Label();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgFleetAvailabilityStatus).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgRentalScheduleAndDurationAnalysis).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(15, 12);
            label12.Name = "label12";
            label12.Size = new Size(139, 46);
            label12.TabIndex = 36;
            label12.Text = "Reports";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(58, 124, 165);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1509, 75);
            panel9.TabIndex = 74;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 124, 165);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblFleetRate);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(90, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 125);
            panel1.TabIndex = 75;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(337, 20);
            label3.TabIndex = 2;
            label3.Text = "(Total Rental Days / Total Available Days) × 100%";
            // 
            // lblFleetRate
            // 
            lblFleetRate.AutoSize = true;
            lblFleetRate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFleetRate.Location = new Point(0, 54);
            lblFleetRate.Name = "lblFleetRate";
            lblFleetRate.Size = new Size(67, 28);
            lblFleetRate.TabIndex = 1;
            lblFleetRate.Text = "78.5%";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 31);
            label1.TabIndex = 0;
            label1.Text = "Fleet Utilization Rate ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(58, 124, 165);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblRevenuePerVehicle);
            panel2.Controls.Add(label6);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(462, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 125);
            panel2.TabIndex = 76;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 96);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 2;
            label4.Text = "Monthly average per unit";
            // 
            // lblRevenuePerVehicle
            // 
            lblRevenuePerVehicle.AutoSize = true;
            lblRevenuePerVehicle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenuePerVehicle.Location = new Point(0, 54);
            lblRevenuePerVehicle.Name = "lblRevenuePerVehicle";
            lblRevenuePerVehicle.Size = new Size(87, 28);
            lblRevenuePerVehicle.TabIndex = 1;
            lblRevenuePerVehicle.Text = "₱ 12,000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(222, 31);
            label6.TabIndex = 0;
            label6.Text = "Revenue per Vehicle";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(58, 124, 165);
            panel3.Controls.Add(lblAverageRentalRate);
            panel3.Controls.Add(label9);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(834, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 125);
            panel3.TabIndex = 77;
            // 
            // lblAverageRentalRate
            // 
            lblAverageRentalRate.AutoSize = true;
            lblAverageRentalRate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageRentalRate.Location = new Point(0, 54);
            lblAverageRentalRate.Name = "lblAverageRentalRate";
            lblAverageRentalRate.Size = new Size(67, 28);
            lblAverageRentalRate.TabIndex = 1;
            lblAverageRentalRate.Text = "78.5%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(228, 31);
            label9.TabIndex = 0;
            label9.Text = "Average Rental Rate ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(58, 124, 165);
            panel4.Controls.Add(lblCustomerRetentionRate);
            panel4.Controls.Add(label13);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(1202, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(345, 125);
            panel4.TabIndex = 78;
            // 
            // lblCustomerRetentionRate
            // 
            lblCustomerRetentionRate.AutoSize = true;
            lblCustomerRetentionRate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerRetentionRate.Location = new Point(0, 54);
            lblCustomerRetentionRate.Name = "lblCustomerRetentionRate";
            lblCustomerRetentionRate.Size = new Size(67, 28);
            lblCustomerRetentionRate.TabIndex = 1;
            lblCustomerRetentionRate.Text = "78.5%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(277, 31);
            label13.TabIndex = 0;
            label13.Text = "Customer Retention Rate ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(58, 124, 165);
            panel5.Controls.Add(dgFleetAvailabilityStatus);
            panel5.Controls.Add(label14);
            panel5.Location = new Point(90, 234);
            panel5.Name = "panel5";
            panel5.Size = new Size(720, 336);
            panel5.TabIndex = 79;
            // 
            // dgFleetAvailabilityStatus
            // 
            dgFleetAvailabilityStatus.AllowUserToResizeColumns = false;
            dgFleetAvailabilityStatus.AllowUserToResizeRows = false;
            dgFleetAvailabilityStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgFleetAvailabilityStatus.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgFleetAvailabilityStatus.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgFleetAvailabilityStatus.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgFleetAvailabilityStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgFleetAvailabilityStatus.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgFleetAvailabilityStatus.DefaultCellStyle = dataGridViewCellStyle8;
            dgFleetAvailabilityStatus.EnableHeadersVisualStyles = false;
            dgFleetAvailabilityStatus.GridColor = SystemColors.GrayText;
            dgFleetAvailabilityStatus.Location = new Point(13, 51);
            dgFleetAvailabilityStatus.Name = "dgFleetAvailabilityStatus";
            dgFleetAvailabilityStatus.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgFleetAvailabilityStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgFleetAvailabilityStatus.RowHeadersVisible = false;
            dgFleetAvailabilityStatus.RowHeadersWidth = 51;
            dgFleetAvailabilityStatus.Size = new Size(691, 268);
            dgFleetAvailabilityStatus.TabIndex = 73;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 0);
            label14.Name = "label14";
            label14.Size = new Size(307, 37);
            label14.TabIndex = 3;
            label14.Text = "Fleet Availability Status ";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(58, 124, 165);
            panel6.Controls.Add(lblVehiclePercentage3);
            panel6.Controls.Add(lblVehiclePercentage2);
            panel6.Controls.Add(lblVehiclePercentage1);
            panel6.Controls.Add(lblVehicle3);
            panel6.Controls.Add(lblVehicle2);
            panel6.Controls.Add(lblVehicle1);
            panel6.Controls.Add(label15);
            panel6.Location = new Point(834, 234);
            panel6.Name = "panel6";
            panel6.Size = new Size(720, 179);
            panel6.TabIndex = 80;
            // 
            // lblVehiclePercentage3
            // 
            lblVehiclePercentage3.AutoSize = true;
            lblVehiclePercentage3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehiclePercentage3.ForeColor = Color.White;
            lblVehiclePercentage3.Location = new Point(562, 138);
            lblVehiclePercentage3.Name = "lblVehiclePercentage3";
            lblVehiclePercentage3.Size = new Size(90, 31);
            lblVehiclePercentage3.TabIndex = 9;
            lblVehiclePercentage3.Text = "label22";
            // 
            // lblVehiclePercentage2
            // 
            lblVehiclePercentage2.AutoSize = true;
            lblVehiclePercentage2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehiclePercentage2.ForeColor = Color.White;
            lblVehiclePercentage2.Location = new Point(562, 96);
            lblVehiclePercentage2.Name = "lblVehiclePercentage2";
            lblVehiclePercentage2.Size = new Size(86, 31);
            lblVehiclePercentage2.TabIndex = 8;
            lblVehiclePercentage2.Text = "label21";
            // 
            // lblVehiclePercentage1
            // 
            lblVehiclePercentage1.AutoSize = true;
            lblVehiclePercentage1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehiclePercentage1.ForeColor = Color.White;
            lblVehiclePercentage1.Location = new Point(562, 51);
            lblVehiclePercentage1.Name = "lblVehiclePercentage1";
            lblVehiclePercentage1.Size = new Size(90, 31);
            lblVehiclePercentage1.TabIndex = 7;
            lblVehiclePercentage1.Text = "label20";
            // 
            // lblVehicle3
            // 
            lblVehicle3.AutoSize = true;
            lblVehicle3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblVehicle3.ForeColor = Color.White;
            lblVehicle3.Location = new Point(15, 138);
            lblVehicle3.Name = "lblVehicle3";
            lblVehicle3.Size = new Size(86, 31);
            lblVehicle3.TabIndex = 6;
            lblVehicle3.Text = "label19";
            // 
            // lblVehicle2
            // 
            lblVehicle2.AutoSize = true;
            lblVehicle2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblVehicle2.ForeColor = Color.White;
            lblVehicle2.Location = new Point(15, 96);
            lblVehicle2.Name = "lblVehicle2";
            lblVehicle2.Size = new Size(86, 31);
            lblVehicle2.TabIndex = 5;
            lblVehicle2.Text = "label18";
            // 
            // lblVehicle1
            // 
            lblVehicle1.AutoSize = true;
            lblVehicle1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblVehicle1.ForeColor = Color.White;
            lblVehicle1.Location = new Point(15, 51);
            lblVehicle1.Name = "lblVehicle1";
            lblVehicle1.Size = new Size(85, 31);
            lblVehicle1.TabIndex = 4;
            lblVehicle1.Text = "label17";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(13, 0);
            label15.Name = "label15";
            label15.Size = new Size(268, 37);
            label15.TabIndex = 3;
            label15.Text = "Top popular Vehicles";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(58, 124, 165);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(lblAverageDelay);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(lblLateReturn);
            panel7.Controls.Add(label16);
            panel7.Location = new Point(834, 419);
            panel7.Name = "panel7";
            panel7.Size = new Size(720, 151);
            panel7.TabIndex = 81;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(537, 103);
            label11.Name = "label11";
            label11.Size = new Size(165, 31);
            label11.TabIndex = 13;
            label11.Text = "Average Delay";
            // 
            // lblAverageDelay
            // 
            lblAverageDelay.AutoSize = true;
            lblAverageDelay.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblAverageDelay.ForeColor = Color.White;
            lblAverageDelay.Location = new Point(558, 54);
            lblAverageDelay.Name = "lblAverageDelay";
            lblAverageDelay.Size = new Size(86, 31);
            lblAverageDelay.TabIndex = 12;
            lblAverageDelay.Text = "label19";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 103);
            label5.Name = "label5";
            label5.Size = new Size(141, 31);
            label5.TabIndex = 11;
            label5.Text = "Current Late";
            // 
            // lblLateReturn
            // 
            lblLateReturn.AutoSize = true;
            lblLateReturn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblLateReturn.ForeColor = Color.White;
            lblLateReturn.Location = new Point(47, 54);
            lblLateReturn.Name = "lblLateReturn";
            lblLateReturn.Size = new Size(86, 31);
            lblLateReturn.TabIndex = 10;
            lblLateReturn.Text = "label19";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.White;
            label16.Location = new Point(13, 0);
            label16.Name = "label16";
            label16.Size = new Size(264, 37);
            label16.TabIndex = 3;
            label16.Text = "Late Return Analysis";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(58, 124, 165);
            panel8.Controls.Add(dgRentalScheduleAndDurationAnalysis);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(90, 592);
            panel8.Name = "panel8";
            panel8.Size = new Size(1454, 407);
            panel8.TabIndex = 82;
            // 
            // dgRentalScheduleAndDurationAnalysis
            // 
            dgRentalScheduleAndDurationAnalysis.AllowUserToResizeColumns = false;
            dgRentalScheduleAndDurationAnalysis.AllowUserToResizeRows = false;
            dgRentalScheduleAndDurationAnalysis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgRentalScheduleAndDurationAnalysis.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgRentalScheduleAndDurationAnalysis.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgRentalScheduleAndDurationAnalysis.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgRentalScheduleAndDurationAnalysis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgRentalScheduleAndDurationAnalysis.ColumnHeadersHeight = 30;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgRentalScheduleAndDurationAnalysis.DefaultCellStyle = dataGridViewCellStyle11;
            dgRentalScheduleAndDurationAnalysis.EnableHeadersVisualStyles = false;
            dgRentalScheduleAndDurationAnalysis.GridColor = SystemColors.GrayText;
            dgRentalScheduleAndDurationAnalysis.Location = new Point(26, 65);
            dgRentalScheduleAndDurationAnalysis.Name = "dgRentalScheduleAndDurationAnalysis";
            dgRentalScheduleAndDurationAnalysis.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgRentalScheduleAndDurationAnalysis.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgRentalScheduleAndDurationAnalysis.RowHeadersVisible = false;
            dgRentalScheduleAndDurationAnalysis.RowHeadersWidth = 51;
            dgRentalScheduleAndDurationAnalysis.Size = new Size(1417, 314);
            dgRentalScheduleAndDurationAnalysis.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(494, 37);
            label2.TabIndex = 4;
            label2.Text = "Rental Schedule and Duration Analysis ";
            // 
            // UC_Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel9);
            Name = "UC_Reports";
            Size = new Size(1509, 1219);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgFleetAvailabilityStatus).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgRentalScheduleAndDurationAnalysis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label12;
        private Panel panel9;
        private Panel panel1;
        private Label label3;
        private Label lblFleetRate;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label lblRevenuePerVehicle;
        private Label label6;
        private Panel panel3;
        private Label label7;
        private Label lblAverageRentalRate;
        private Label label9;
        private Panel panel4;
        private Label label10;
        private Label lblCustomerRetentionRate;
        private Label label13;
        private Panel panel5;
        private Label label14;
        private Panel panel6;
        private Label label15;
        private Label lblVehiclePercentage3;
        private Label lblVehiclePercentage2;
        private Label lblVehiclePercentage1;
        private Label lblVehicle3;
        private Label lblVehicle2;
        private Label lblVehicle1;
        private Panel panel7;
        private Label label16;
        private Label label11;
        private Label lblAverageDelay;
        private Label label5;
        private Label lblLateReturn;
        private Panel panel8;
        private Label label2;
        private DataGridView dgFleetAvailabilityStatus;
        private DataGridView dgRentalScheduleAndDurationAnalysis;
    }
}
