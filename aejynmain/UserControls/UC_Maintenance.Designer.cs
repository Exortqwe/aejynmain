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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Maintenance));
            panel9 = new Panel();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            dgMaintenance = new DataGridView();
            btnScheduleMaintenance = new Button();
            label1 = new Label();
            label12 = new Label();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMaintenance).BeginInit();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(28, 73, 102);
            panel9.Controls.Add(label1);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1400, 112);
            panel9.TabIndex = 75;
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
            dataGridViewCellStyle16.BackColor = Color.White;
            dgMaintenance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dgMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMaintenance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgMaintenance.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgMaintenance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle17.SelectionForeColor = Color.White;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dgMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dgMaintenance.ColumnHeadersHeight = 30;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = Color.White;
            dataGridViewCellStyle18.SelectionForeColor = Color.Black;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dgMaintenance.DefaultCellStyle = dataGridViewCellStyle18;
            dgMaintenance.EnableHeadersVisualStyles = false;
            dgMaintenance.GridColor = SystemColors.GrayText;
            dgMaintenance.Location = new Point(180, 196);
            dgMaintenance.Name = "dgMaintenance";
            dgMaintenance.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.White;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = Color.White;
            dataGridViewCellStyle19.SelectionForeColor = Color.Black;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgMaintenance.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgMaintenance.RowHeadersVisible = false;
            dgMaintenance.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = Color.White;
            dgMaintenance.RowsDefaultCellStyle = dataGridViewCellStyle20;
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
            // UC_Maintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnScheduleMaintenance);
            Controls.Add(dgMaintenance);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel9);
            Name = "UC_Maintenance";
            Size = new Size(1400, 928);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
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
    }
}
