namespace aejynmain.UserControls
{
    partial class UC_Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Maintenance));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel9 = new Panel();
            lblRole = new Label();
            lblUsername = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label12 = new Label();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            dgMaintenance = new DataGridView();
            btnScheduleMaintenance = new Button();
            btnStart = new Button();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgMaintenance).BeginInit();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(28, 73, 102);
            panel9.Controls.Add(lblRole);
            panel9.Controls.Add(lblUsername);
            panel9.Controls.Add(pictureBox1);
            panel9.Controls.Add(label1);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1677, 112);
            panel9.TabIndex = 75;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(1494, 69);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(0, 23);
            lblRole.TabIndex = 44;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(1494, 29);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 23);
            lblUsername.TabIndex = 43;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1591, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 68);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(569, 46);
            label1.TabIndex = 41;
            label1.Text = "Vehicle Rental Management System";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlLight;
            label12.Location = new Point(3, 60);
            label12.Name = "label12";
            label12.Size = new Size(163, 32);
            label12.TabIndex = 40;
            label12.Text = "Maintenance ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(58, 124, 165);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 32;
            btnSearch.Location = new Point(409, 149);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 41);
            btnSearch.TabIndex = 79;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(180, 149);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(232, 41);
            txtSearch.TabIndex = 78;
            // 
            // dgMaintenance
            // 
            dgMaintenance.AllowUserToResizeColumns = false;
            dgMaintenance.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgMaintenance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMaintenance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgMaintenance.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgMaintenance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgMaintenance.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgMaintenance.DefaultCellStyle = dataGridViewCellStyle3;
            dgMaintenance.EnableHeadersVisualStyles = false;
            dgMaintenance.GridColor = SystemColors.GrayText;
            dgMaintenance.Location = new Point(180, 196);
            dgMaintenance.Name = "dgMaintenance";
            dgMaintenance.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgMaintenance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgMaintenance.RowHeadersVisible = false;
            dgMaintenance.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dgMaintenance.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgMaintenance.Size = new Size(1217, 547);
            dgMaintenance.TabIndex = 81;
            // 
            // btnScheduleMaintenance
            // 
            btnScheduleMaintenance.BackColor = Color.FromArgb(58, 124, 165);
            btnScheduleMaintenance.FlatAppearance.BorderSize = 0;
            btnScheduleMaintenance.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnScheduleMaintenance.FlatStyle = FlatStyle.Flat;
            btnScheduleMaintenance.ForeColor = Color.White;
            btnScheduleMaintenance.Image = (Image)resources.GetObject("btnScheduleMaintenance.Image");
            btnScheduleMaintenance.ImageAlign = ContentAlignment.MiddleLeft;
            btnScheduleMaintenance.Location = new Point(478, 149);
            btnScheduleMaintenance.Name = "btnScheduleMaintenance";
            btnScheduleMaintenance.Size = new Size(208, 41);
            btnScheduleMaintenance.TabIndex = 84;
            btnScheduleMaintenance.Text = "       Schedule Maintenance";
            btnScheduleMaintenance.UseVisualStyleBackColor = false;
            btnScheduleMaintenance.Click += btnScheduleMaintenance_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(58, 124, 165);
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(637, 749);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(243, 41);
            btnStart.TabIndex = 85;
            btnStart.Text = "Start Maintenance";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // UC_Maintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnStart);
            Controls.Add(btnScheduleMaintenance);
            Controls.Add(dgMaintenance);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel9);
            Name = "UC_Maintenance";
            Size = new Size(1677, 928);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgMaintenance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel9;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox txtSearch;
        private DataGridView dgMaintenance;
        private Button btnScheduleMaintenance;
        private Label label1;
        private Label label12;
        private Label lblRole;
        private Label lblUsername;
        private PictureBox pictureBox1;
        private Button btnStart;
    }
}
