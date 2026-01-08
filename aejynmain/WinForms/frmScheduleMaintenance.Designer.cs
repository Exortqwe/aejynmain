namespace aejynmain.WinForms
{
    partial class frmScheduleMaintenance
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            txtMaintenanceDescription = new TextBox();
            label2 = new Label();
            btnConfirm = new Button();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtCost = new TextBox();
            label5 = new Label();
            cmbMaintenanceType = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbMaintenanceStatus = new ComboBox();
            dgVehicleFleets = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgVehicleFleets).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 73, 102);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 75);
            panel1.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(369, 46);
            label1.TabIndex = 0;
            label1.Text = "Schedule Maintenance";
            // 
            // txtMaintenanceDescription
            // 
            txtMaintenanceDescription.BorderStyle = BorderStyle.FixedSingle;
            txtMaintenanceDescription.Location = new Point(629, 318);
            txtMaintenanceDescription.Multiline = true;
            txtMaintenanceDescription.Name = "txtMaintenanceDescription";
            txtMaintenanceDescription.Size = new Size(278, 213);
            txtMaintenanceDescription.TabIndex = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(629, 287);
            label2.Name = "label2";
            label2.Size = new Size(238, 28);
            label2.TabIndex = 77;
            label2.Text = "Maintenance Description";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(58, 124, 165);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(268, 538);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(243, 41);
            btnConfirm.TabIndex = 78;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(68, 207);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(243, 27);
            dtpStartDate.TabIndex = 79;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(331, 207);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(242, 27);
            dtpEndDate.TabIndex = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 171);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 81;
            label3.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(331, 174);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 82;
            label4.Text = "End Date";
            // 
            // txtCost
            // 
            txtCost.BorderStyle = BorderStyle.FixedSingle;
            txtCost.Location = new Point(541, 143);
            txtCost.Multiline = true;
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(168, 28);
            txtCost.TabIndex = 85;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(68, 287);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 86;
            label5.Text = "Vehicle";
            // 
            // cmbMaintenanceType
            // 
            cmbMaintenanceType.FormattingEnabled = true;
            cmbMaintenanceType.Items.AddRange(new object[] { "Oil Change", "PMS ", "Repair", "Other" });
            cmbMaintenanceType.Location = new Point(68, 143);
            cmbMaintenanceType.Name = "cmbMaintenanceType";
            cmbMaintenanceType.Size = new Size(210, 28);
            cmbMaintenanceType.TabIndex = 87;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(68, 112);
            label6.Name = "label6";
            label6.Size = new Size(178, 28);
            label6.TabIndex = 88;
            label6.Text = "Maintenance Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(541, 109);
            label7.Name = "label7";
            label7.Size = new Size(52, 28);
            label7.TabIndex = 89;
            label7.Text = "Cost";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(297, 108);
            label8.Name = "label8";
            label8.Size = new Size(190, 28);
            label8.TabIndex = 90;
            label8.Text = "Maintenance Status";
            // 
            // cmbMaintenanceStatus
            // 
            cmbMaintenanceStatus.FormattingEnabled = true;
            cmbMaintenanceStatus.Items.AddRange(new object[] { "Scheduled", "In Progress", "Completed" });
            cmbMaintenanceStatus.Location = new Point(301, 143);
            cmbMaintenanceStatus.Name = "cmbMaintenanceStatus";
            cmbMaintenanceStatus.Size = new Size(210, 28);
            cmbMaintenanceStatus.TabIndex = 91;
            // 
            // dgVehicleFleets
            // 
            dgVehicleFleets.AllowUserToResizeColumns = false;
            dgVehicleFleets.AllowUserToResizeRows = false;
            dgVehicleFleets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgVehicleFleets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgVehicleFleets.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgVehicleFleets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgVehicleFleets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgVehicleFleets.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgVehicleFleets.DefaultCellStyle = dataGridViewCellStyle2;
            dgVehicleFleets.EnableHeadersVisualStyles = false;
            dgVehicleFleets.GridColor = SystemColors.GrayText;
            dgVehicleFleets.Location = new Point(68, 318);
            dgVehicleFleets.Name = "dgVehicleFleets";
            dgVehicleFleets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgVehicleFleets.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgVehicleFleets.RowHeadersVisible = false;
            dgVehicleFleets.RowHeadersWidth = 51;
            dgVehicleFleets.ScrollBars = ScrollBars.Horizontal;
            dgVehicleFleets.Size = new Size(528, 213);
            dgVehicleFleets.TabIndex = 93;
            // 
            // frmScheduleMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 591);
            Controls.Add(dgVehicleFleets);
            Controls.Add(cmbMaintenanceStatus);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbMaintenanceType);
            Controls.Add(label5);
            Controls.Add(txtCost);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnConfirm);
            Controls.Add(label2);
            Controls.Add(txtMaintenanceDescription);
            Controls.Add(panel1);
            Name = "frmScheduleMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmScheduleMaintenance";
            Load += frmScheduleMaintenance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgVehicleFleets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtMaintenanceDescription;
        private Label label2;
        private Button btnConfirm;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label3;
        private Label label4;
        private TextBox txtCost;
        private Label label5;
        private ComboBox cmbMaintenanceType;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbMaintenanceStatus;
        private DataGridView dgVehicleFleets;
    }
}