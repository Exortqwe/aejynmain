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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            panel9 = new Panel();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            label9 = new Label();
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
            panel8 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            lblTotalVehicles = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 247, 250);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 1219);
            panel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(58, 124, 165);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1685, 75);
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
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column11, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.GrayText;
            dataGridView1.Location = new Point(15, 513);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1651, 423);
            dataGridView1.TabIndex = 72;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Client Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Vehicle";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column11
            // 
            Column11.HeaderText = "Plate Number";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 128;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Condition Before";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Condition After";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.HeaderText = "Rent Date";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Return Date";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Daily Rental Price";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column9.HeaderText = "Days";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column10.HeaderText = "Total";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(58, 124, 165);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(521, 451);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 28);
            comboBox1.TabIndex = 71;
            comboBox1.Text = "Status";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(58, 124, 165);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.Location = new Point(452, 451);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(63, 28);
            iconButton2.TabIndex = 70;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(58, 124, 165);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(383, 451);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(63, 28);
            iconButton1.TabIndex = 69;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(60, 451);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 28);
            textBox1.TabIndex = 68;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(46, 46, 46);
            label9.Location = new Point(60, 416);
            label9.Name = "label9";
            label9.Size = new Size(154, 23);
            label9.TabIndex = 67;
            label9.Text = "Today Transactions";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(58, 124, 165);
            panel7.Controls.Add(lblRevenueToday);
            panel7.Controls.Add(label21);
            panel7.Location = new Point(770, 273);
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
            panel6.Location = new Point(392, 273);
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
            label19.Size = new Size(184, 46);
            label19.TabIndex = 19;
            label19.Text = "Customers";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(58, 124, 165);
            panel5.Controls.Add(lblDamageLost);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(15, 273);
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
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(58, 124, 165);
            panel8.Controls.Add(chart1);
            panel8.Location = new Point(1155, 126);
            panel8.Name = "panel8";
            panel8.Size = new Size(511, 272);
            panel8.TabIndex = 66;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(23, 13);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(460, 240);
            chart1.TabIndex = 34;
            chart1.Text = "chart1";
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
            Size = new Size(1685, 1219);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox1;
        private Label label9;
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
        private Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel2;
        private Label lblTotalVehicles;
        private Label label5;
        private DataGridView dataGridView1;
        private Label lblRevenueToday;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Panel panel9;
        private Label label12;
    }
}
