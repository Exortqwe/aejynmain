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
            textBox1 = new TextBox();
            btnAddVehicle = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dgVehicleFleet = new DataGridView();
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
            btnSearch.Location = new Point(322, 148);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(68, 38);
            btnSearch.TabIndex = 5;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 124, 165);
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
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(22, 148);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 38);
            textBox1.TabIndex = 7;
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
            btnAddVehicle.Location = new Point(396, 148);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(149, 38);
            btnAddVehicle.TabIndex = 8;
            btnAddVehicle.Text = "          Add Vehicle";
            btnAddVehicle.UseVisualStyleBackColor = false;
            btnAddVehicle.Click += btnAddVehicle_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(58, 124, 165);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.Location = new Point(551, 148);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(51, 38);
            iconButton1.TabIndex = 9;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
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
            dgVehicleFleet.Location = new Point(22, 192);
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
            dgVehicleFleet.Size = new Size(1622, 537);
            dgVehicleFleet.TabIndex = 72;
            // 
            // UC_VehicleFleet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(dgVehicleFleet);
            Controls.Add(iconButton1);
            Controls.Add(btnAddVehicle);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button btnAddVehicle;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dgVehicleFleet;
    }
}
