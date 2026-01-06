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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            panel1 = new Panel();
            chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel10 = new Panel();
            lblReservedVehicles = new Label();
            label6 = new Label();
            chartVehicleStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel8 = new Panel();
            lblLateReturn = new Label();
            label3 = new Label();
            panel9 = new Panel();
            label12 = new Label();
            panel7 = new Panel();
            lblRevenueToday = new Label();
            label21 = new Label();
            panel4 = new Panel();
            lblAvailableVehicles = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            lblActiveRentals = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblTotalVehicles = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVehicleStatus).BeginInit();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 247, 250);
            panel1.Controls.Add(chartRevenue);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(chartVehicleStatus);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1688, 1219);
            panel1.TabIndex = 0;
            // 
            // chartRevenue
            // 
            chartArea3.Name = "ChartArea1";
            chartRevenue.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartRevenue.Legends.Add(legend3);
            chartRevenue.Location = new Point(38, 290);
            chartRevenue.Name = "chartRevenue";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartRevenue.Series.Add(series3);
            chartRevenue.Size = new Size(774, 501);
            chartRevenue.TabIndex = 75;
            chartRevenue.Text = "chart1";
            chartRevenue.Click += chartRevenue_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(58, 124, 165);
            panel10.Controls.Add(pictureBox3);
            panel10.Controls.Add(lblReservedVehicles);
            panel10.Controls.Add(label6);
            panel10.Location = new Point(1343, 125);
            panel10.Name = "panel10";
            panel10.Size = new Size(255, 125);
            panel10.TabIndex = 67;
            // 
            // lblReservedVehicles
            // 
            lblReservedVehicles.AutoSize = true;
            lblReservedVehicles.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblReservedVehicles.ForeColor = Color.White;
            lblReservedVehicles.Location = new Point(15, 69);
            lblReservedVehicles.Name = "lblReservedVehicles";
            lblReservedVehicles.Size = new Size(0, 46);
            lblReservedVehicles.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(224, 35);
            label6.TabIndex = 19;
            label6.Text = " Reserved Vehicles";
            // 
            // chartVehicleStatus
            // 
            chartArea4.Name = "ChartArea1";
            chartVehicleStatus.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartVehicleStatus.Legends.Add(legend4);
            chartVehicleStatus.Location = new Point(821, 290);
            chartVehicleStatus.Name = "chartVehicleStatus";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartVehicleStatus.Series.Add(series4);
            chartVehicleStatus.Size = new Size(774, 501);
            chartVehicleStatus.TabIndex = 74;
            chartVehicleStatus.Text = "chart2";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(58, 124, 165);
            panel8.Controls.Add(pictureBox5);
            panel8.Controls.Add(lblLateReturn);
            panel8.Controls.Add(label3);
            panel8.Location = new Point(1082, 125);
            panel8.Name = "panel8";
            panel8.Size = new Size(255, 125);
            panel8.TabIndex = 66;
            // 
            // lblLateReturn
            // 
            lblLateReturn.AutoSize = true;
            lblLateReturn.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblLateReturn.ForeColor = Color.White;
            lblLateReturn.Location = new Point(15, 69);
            lblLateReturn.Name = "lblLateReturn";
            lblLateReturn.Size = new Size(0, 46);
            lblLateReturn.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 35);
            label3.TabIndex = 19;
            label3.Text = "Overdue";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(58, 124, 165);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1688, 75);
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
            panel7.Controls.Add(pictureBox4);
            panel7.Controls.Add(lblRevenueToday);
            panel7.Controls.Add(label21);
            panel7.Location = new Point(821, 125);
            panel7.Name = "panel7";
            panel7.Size = new Size(255, 125);
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
            label21.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label21.ForeColor = Color.White;
            label21.Location = new Point(0, 0);
            label21.Name = "label21";
            label21.Size = new Size(187, 35);
            label21.TabIndex = 19;
            label21.Text = "Revenue Today";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(58, 124, 165);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(lblAvailableVehicles);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(299, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 125);
            panel4.TabIndex = 62;
            // 
            // lblAvailableVehicles
            // 
            lblAvailableVehicles.AutoSize = true;
            lblAvailableVehicles.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblAvailableVehicles.ForeColor = Color.White;
            lblAvailableVehicles.Location = new Point(15, 70);
            lblAvailableVehicles.Name = "lblAvailableVehicles";
            lblAvailableVehicles.Size = new Size(0, 46);
            lblAvailableVehicles.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 35);
            label4.TabIndex = 19;
            label4.Text = "Available Vehicles";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(58, 124, 165);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblActiveRentals);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(560, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 125);
            panel3.TabIndex = 61;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(176, 35);
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
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTotalVehicles);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(38, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 125);
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
            label5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(-5, 0);
            label5.Name = "label5";
            label5.Size = new Size(170, 35);
            label5.TabIndex = 19;
            label5.Text = "Total Vehicles";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(191, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(190, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 64);
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(181, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(71, 64);
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(189, 58);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 64);
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(189, 58);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(66, 64);
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(186, 61);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(66, 64);
            pictureBox6.TabIndex = 40;
            pictureBox6.TabStop = false;
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_Dashboard";
            Size = new Size(1688, 1219);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRevenue).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartVehicleStatus).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel7;
        private Label label21;
        private Panel panel4;
        private Label lblAvailableVehicles;
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
        private Label lblLateReturn;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVehicleStatus;
        private Panel panel10;
        private Label lblReservedVehicles;
        private Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}
