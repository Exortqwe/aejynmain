namespace aejynmain.StaffUserControls
{
    partial class UC_StaffMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_StaffMaintenance));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel9 = new Panel();
            label12 = new Label();
            textBox1 = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnScheduleMaintenance = new Button();
            dgStaffMaintenance = new DataGridView();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgStaffMaintenance).BeginInit();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(58, 124, 165);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1400, 75);
            panel9.TabIndex = 76;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(15, 12);
            label12.Name = "label12";
            label12.Size = new Size(220, 46);
            label12.TabIndex = 36;
            label12.Text = "Maintenance";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(75, 111);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 41);
            textBox1.TabIndex = 79;
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
            btnSearch.Location = new Point(304, 111);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 41);
            btnSearch.TabIndex = 80;
            btnSearch.UseVisualStyleBackColor = false;
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
            btnScheduleMaintenance.Location = new Point(373, 111);
            btnScheduleMaintenance.Name = "btnScheduleMaintenance";
            btnScheduleMaintenance.Size = new Size(191, 41);
            btnScheduleMaintenance.TabIndex = 85;
            btnScheduleMaintenance.Text = "    Add New Customer";
            btnScheduleMaintenance.UseVisualStyleBackColor = false;
            // 
            // dgStaffMaintenance
            // 
            dgStaffMaintenance.AllowUserToResizeColumns = false;
            dgStaffMaintenance.AllowUserToResizeRows = false;
            dgStaffMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgStaffMaintenance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgStaffMaintenance.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgStaffMaintenance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgStaffMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgStaffMaintenance.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgStaffMaintenance.DefaultCellStyle = dataGridViewCellStyle5;
            dgStaffMaintenance.EnableHeadersVisualStyles = false;
            dgStaffMaintenance.GridColor = SystemColors.GrayText;
            dgStaffMaintenance.Location = new Point(75, 158);
            dgStaffMaintenance.Name = "dgStaffMaintenance";
            dgStaffMaintenance.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgStaffMaintenance.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgStaffMaintenance.RowHeadersVisible = false;
            dgStaffMaintenance.RowHeadersWidth = 51;
            dgStaffMaintenance.Size = new Size(1217, 547);
            dgStaffMaintenance.TabIndex = 86;
            dgStaffMaintenance.CellContentClick += dgMaintenance_CellContentClick;
            // 
            // UC_StaffMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgStaffMaintenance);
            Controls.Add(btnScheduleMaintenance);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(panel9);
            Name = "UC_StaffMaintenance";
            Size = new Size(1400, 928);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgStaffMaintenance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel9;
        private Label label12;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Button btnScheduleMaintenance;
        private DataGridView dgStaffMaintenance;
    }
}
