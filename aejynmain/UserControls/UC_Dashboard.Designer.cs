namespace aejynmain.UserControls
{
    partial class UC_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            panel10 = new Panel();
            lblUnderMaintenance = new Label();
            label6 = new Label();
            piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel8 = new Panel();
            lblOverDue = new Label();
            label3 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel9 = new Panel();
            label12 = new Label();
            panel7 = new Panel();
            lblRevenueToday = new Label();
            label21 = new Label();
            panel6 = new Panel();
            lblCustomers = new Label();
            label19 = new Label();
            panel5 = new Panel();
            lblDamageLost = new Label();
            label7 = new Label();
            panel4 = new Panel();
            lblVehiclesAvailable = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            lblActiveRentals = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblTotalVehicles = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piechart).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 247, 250);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(piechart);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(chart1);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1509, 1219);
            panel1.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(58, 124, 165);
            panel10.Controls.Add(lblUnderMaintenance);
            panel10.Controls.Add(label6);
            panel10.Location = new Point(1145, 273);
            panel10.Name = "panel10";
            panel10.Size = new Size(356, 125);
            panel10.TabIndex = 67;
            // 
            // lblUnderMaintenance
            // 
            lblUnderMaintenance.AutoSize = true;
            lblUnderMaintenance.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblUnderMaintenance.ForeColor = Color.White;
            lblUnderMaintenance.Location = new Point(15, 69);
            lblUnderMaintenance.Name = "lblUnderMaintenance";
            lblUnderMaintenance.Size = new Size(0, 46);
            lblUnderMaintenance.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(324, 46);
            label6.TabIndex = 19;
            label6.Text = "Under Maintenance";
            // 
            // piechart
            // 
            chartArea1.Name = "ChartArea1";
            piechart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            piechart.Legends.Add(legend1);
            piechart.Location = new Point(754, 467);
            piechart.Name = "piechart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            piechart.Series.Add(series1);
            piechart.Size = new Size(730, 501);
            piechart.TabIndex = 74;
            piechart.Text = "chart2";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(58, 124, 165);
            panel8.Controls.Add(lblOverDue);
            panel8.Controls.Add(label3);
            panel8.Location = new Point(770, 273);
            panel8.Name = "panel8";
            panel8.Size = new Size(356, 125);
            panel8.TabIndex = 66;
            // 
            // lblOverDue
            // 
            lblOverDue.AutoSize = true;
            lblOverDue.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblOverDue.ForeColor = Color.White;
            lblOverDue.Location = new Point(15, 69);
            lblOverDue.Name = "lblOverDue";
            lblOverDue.Size = new Size(0, 46);
            lblOverDue.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(197, 46);
            label3.TabIndex = 19;
            label3.Text = "Late Return";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(18, 467);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(730, 501);
            chart1.TabIndex = 34;
            chart1.Text = "chart1";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(58, 124, 165);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1509, 75);
            panel9.TabIndex = 73;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(15, 12);
            label12.Name = "label12";
            label12.Size = new Size(188, 46);
            label12.TabIndex = 36;
            label12.Text = "Dashboard";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(58, 124, 165);
            panel7.Controls.Add(lblRevenueToday);
            panel7.Controls.Add(label21);
            panel7.Location = new Point(393, 273);
            panel7.Name = "panel7";
            panel7.Size = new Size(356, 125);
            panel7.TabIndex = 65;
            // 
            // lblRevenueToday
            // 
            lblRevenueToday.AutoSize = true;
            lblRevenueToday.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblRevenueToday.ForeColor = Color.White;
            lblRevenueToday.Location = new Point(15, 69);
            lblRevenueToday.Name = "lblRevenueToday";
            lblRevenueToday.Size = new Size(0, 46);
            lblRevenueToday.TabIndex = 36;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label21.ForeColor = Color.White;
            label21.Location = new Point(3, 13);
            label21.Name = "label21";
            label21.Size = new Size(251, 46);
            label21.TabIndex = 19;
            label21.Text = "Revenue Today";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(58, 124, 165);
            panel6.Controls.Add(lblCustomers);
            panel6.Controls.Add(label19);
            panel6.Location = new Point(15, 273);
            panel6.Name = "panel6";
            panel6.Size = new Size(356, 125);
            panel6.TabIndex = 64;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblCustomers.ForeColor = Color.White;
            lblCustomers.Location = new Point(15, 69);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(0, 46);
            lblCustomers.TabIndex = 35;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label19.ForeColor = Color.White;
            label19.Location = new Point(3, 13);
            label19.Name = "label19";
            label19.Size = new Size(288, 46);
            label19.TabIndex = 19;
            label19.Text = "Active Customers";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(58, 124, 165);
            panel5.Controls.Add(lblDamageLost);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(1145, 126);
            panel5.Name = "panel5";
            panel5.Size = new Size(356, 125);
            panel5.TabIndex = 63;
            // 
            // lblDamageLost
            // 
            lblDamageLost.AutoSize = true;
            lblDamageLost.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblDamageLost.ForeColor = Color.White;
            lblDamageLost.Location = new Point(15, 69);
            lblDamageLost.Name = "lblDamageLost";
            lblDamageLost.Size = new Size(0, 46);
            lblDamageLost.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 13);
            label7.Name = "label7";
            label7.Size = new Size(226, 46);
            label7.TabIndex = 19;
            label7.Text = "Damage/Lost";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(58, 124, 165);
            panel4.Controls.Add(lblVehiclesAvailable);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(392, 126);
            panel4.Name = "panel4";
            panel4.Size = new Size(356, 125);
            panel4.TabIndex = 62;
            // 
            // lblVehiclesAvailable
            // 
            lblVehiclesAvailable.AutoSize = true;
            lblVehiclesAvailable.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblVehiclesAvailable.ForeColor = Color.White;
            lblVehiclesAvailable.Location = new Point(15, 70);
            lblVehiclesAvailable.Name = "lblVehiclesAvailable";
            lblVehiclesAvailable.Size = new Size(0, 46);
            lblVehiclesAvailable.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(293, 46);
            label4.TabIndex = 19;
            label4.Text = "Vehicles Available";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(58, 124, 165);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblActiveRentals);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(770, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 125);
            panel3.TabIndex = 61;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(9, 13);
            label10.Name = "label10";
            label10.Size = new Size(236, 46);
            label10.TabIndex = 36;
            label10.Text = "Active Rentals";
            // 
            // lblActiveRentals
            // 
            lblActiveRentals.AutoSize = true;
            lblActiveRentals.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblActiveRentals.ForeColor = Color.White;
            lblActiveRentals.Location = new Point(15, 70);
            lblActiveRentals.Name = "lblActiveRentals";
            lblActiveRentals.Size = new Size(0, 46);
            lblActiveRentals.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(0, 46);
            label2.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(58, 124, 165);
            panel2.Controls.Add(lblTotalVehicles);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(15, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(356, 125);
            panel2.TabIndex = 60;
            // 
            // lblTotalVehicles
            // 
            lblTotalVehicles.AutoSize = true;
            lblTotalVehicles.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTotalVehicles.ForeColor = Color.White;
            lblTotalVehicles.Location = new Point(15, 70);
            lblTotalVehicles.Name = "lblTotalVehicles";
            lblTotalVehicles.Size = new Size(0, 46);
            lblTotalVehicles.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 13);
            label5.Name = "label5";
            label5.Size = new Size(229, 46);
            label5.TabIndex = 19;
            label5.Text = "Total Vehicles";
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_Dashboard";
            Size = new Size(1509, 1219);
            panel1.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piechart).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel7;
        private Label label21;
        private Panel panel6;
        private Label lblCustomers;
        private Label label19;
        private Panel panel5;
        private Label lblDamageLost;
        private Label label7;
        private Panel panel4;
        private Label lblVehiclesAvailable;
        private Label label4;
        private Panel panel3;
        private Label lblActiveRentals;
        private Label label2;
        private Panel panel2;
        private Label lblTotalVehicles;
        private Label label5;
        private Label lblRevenueToday;
        private Label label10;
        private Panel panel9;
        private Label label12;
        private Panel panel8;
        private Label lblOverDue;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
        private Panel panel10;
        private Label lblUnderMaintenance;
        private Label label6;
    }
}
