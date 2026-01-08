namespace aejynmain.UserControls
{
    partial class UC_VehicleFleet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_VehicleFleet));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnSearch = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label35 = new Label();
            txtSearchVehicle = new TextBox();
            btnAddVehicle = new Button();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            dgVehicleFleet = new DataGridView();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgVehicleFleet).BeginInit();
            SuspendLayout();
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
            btnSearch.Location = new Point(331, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(68, 41);
            btnSearch.TabIndex = 5;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 73, 102);
            panel1.Controls.Add(label35);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 75);
            panel1.TabIndex = 6;
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
            txtSearchVehicle.Location = new Point(31, 92);
            txtSearchVehicle.Multiline = true;
            txtSearchVehicle.Name = "txtSearchVehicle";
            txtSearchVehicle.Size = new Size(306, 41);
            txtSearchVehicle.TabIndex = 7;
            txtSearchVehicle.TextChanged += txtSearchVehicle_TextChanged;
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
            btnAddVehicle.Location = new Point(405, 92);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(149, 41);
            btnAddVehicle.TabIndex = 8;
            btnAddVehicle.Text = "          Add Vehicle";
            btnAddVehicle.UseVisualStyleBackColor = false;
            btnAddVehicle.Click += btnAddVehicle_Click;
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
            btnRefresh.Location = new Point(560, 92);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(66, 41);
            btnRefresh.TabIndex = 9;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // dgVehicleFleet
            // 
            dgVehicleFleet.AllowUserToResizeColumns = false;
            dgVehicleFleet.AllowUserToResizeRows = false;
            dgVehicleFleet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgVehicleFleet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgVehicleFleet.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgVehicleFleet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgVehicleFleet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgVehicleFleet.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgVehicleFleet.DefaultCellStyle = dataGridViewCellStyle2;
            dgVehicleFleet.EnableHeadersVisualStyles = false;
            dgVehicleFleet.GridColor = SystemColors.GrayText;
            dgVehicleFleet.Location = new Point(31, 139);
            dgVehicleFleet.Name = "dgVehicleFleet";
            dgVehicleFleet.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgVehicleFleet.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgVehicleFleet.RowHeadersVisible = false;
            dgVehicleFleet.RowHeadersWidth = 51;
            dgVehicleFleet.Size = new Size(1622, 582);
            dgVehicleFleet.TabIndex = 72;
            dgVehicleFleet.CellContentClick += dgVehicleFleet_CellContentClick;
            dgVehicleFleet.CellEndEdit += dgVehicleFleet_CellEndEdit;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(58, 124, 165);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEdit.IconColor = Color.White;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 32;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(1444, 92);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 41);
            btnEdit.TabIndex = 73;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(201, 74, 74);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 63, 63);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 32;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(1542, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 41);
            btnDelete.TabIndex = 78;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // UC_VehicleFleet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(dgVehicleFleet);
            Controls.Add(btnRefresh);
            Controls.Add(btnAddVehicle);
            Controls.Add(txtSearchVehicle);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Name = "UC_VehicleFleet";
            Size = new Size(1685, 1219);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgVehicleFleet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSearch;
        private Panel panel1;
        private Label label35;
        private TextBox txtSearchVehicle;
        private Button btnAddVehicle;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private DataGridView dgVehicleFleet;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}
