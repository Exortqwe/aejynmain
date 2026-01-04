namespace aejynmain.StaffUserControls
{
    partial class UC_StaffVehicleFleet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_StaffVehicleFleet));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label35 = new Label();
            txtSearchVehicle = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnAddVehicle = new Button();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            dgVehicleFleet = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgVehicleFleet).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 124, 165);
            panel1.Controls.Add(label35);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 75);
            panel1.TabIndex = 7;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label35.ForeColor = Color.White;
            label35.Location = new Point(22, 15);
            label35.Name = "label35";
            label35.Size = new Size(213, 46);
            label35.TabIndex = 7;
            label35.Text = "Vehicle Fleet";
            // 
            // txtSearchVehicle
            // 
            txtSearchVehicle.BorderStyle = BorderStyle.FixedSingle;
            txtSearchVehicle.Location = new Point(22, 81);
            txtSearchVehicle.Multiline = true;
            txtSearchVehicle.Name = "txtSearchVehicle";
            txtSearchVehicle.Size = new Size(306, 41);
            txtSearchVehicle.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(58, 124, 165);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 32;
            btnSearch.Location = new Point(324, 81);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(68, 41);
            btnSearch.TabIndex = 9;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.BackColor = Color.FromArgb(58, 124, 165);
            btnAddVehicle.FlatAppearance.BorderSize = 0;
            btnAddVehicle.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnAddVehicle.FlatStyle = FlatStyle.Flat;
            btnAddVehicle.ForeColor = Color.White;
            btnAddVehicle.Image = (Image)resources.GetObject("btnAddVehicle.Image");
            btnAddVehicle.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddVehicle.Location = new Point(398, 81);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(149, 41);
            btnAddVehicle.TabIndex = 10;
            btnAddVehicle.Text = "          Add Vehicle";
            btnAddVehicle.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(58, 124, 165);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 32;
            btnRefresh.Location = new Point(553, 81);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(66, 41);
            btnRefresh.TabIndex = 11;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgVehicleFleet
            // 
            dgVehicleFleet.AllowUserToResizeColumns = false;
            dgVehicleFleet.AllowUserToResizeRows = false;
            dgVehicleFleet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgVehicleFleet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgVehicleFleet.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgVehicleFleet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgVehicleFleet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgVehicleFleet.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgVehicleFleet.DefaultCellStyle = dataGridViewCellStyle5;
            dgVehicleFleet.EnableHeadersVisualStyles = false;
            dgVehicleFleet.GridColor = SystemColors.GrayText;
            dgVehicleFleet.Location = new Point(22, 128);
            dgVehicleFleet.Name = "dgVehicleFleet";
            dgVehicleFleet.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgVehicleFleet.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgVehicleFleet.RowHeadersVisible = false;
            dgVehicleFleet.RowHeadersWidth = 51;
            dgVehicleFleet.Size = new Size(1622, 582);
            dgVehicleFleet.TabIndex = 73;
            // 
            // UCStaffVehicleFleet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgVehicleFleet);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddVehicle);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchVehicle);
            Controls.Add(panel1);
            Name = "UCStaffVehicleFleet";
            Size = new Size(1685, 1219);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgVehicleFleet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label35;
        private TextBox txtSearchVehicle;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Button btnAddVehicle;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private DataGridView dgVehicleFleet;
    }
}
