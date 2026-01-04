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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Maintenance));
            panel9 = new Panel();
            label12 = new Label();
            btnSearch = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            dgMaintenance = new DataGridView();
            ibtnEdit = new FontAwesome.Sharp.IconButton();
            btnScheduleMaintenance = new Button();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgMaintenance).BeginInit();
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
            panel9.TabIndex = 75;
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
            btnSearch.Location = new Point(305, 113);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 41);
            btnSearch.TabIndex = 79;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(76, 113);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 41);
            textBox1.TabIndex = 78;
            // 
            // dgMaintenance
            // 
            dgMaintenance.AllowUserToResizeColumns = false;
            dgMaintenance.AllowUserToResizeRows = false;
            dgMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgMaintenance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgMaintenance.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgMaintenance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgMaintenance.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgMaintenance.DefaultCellStyle = dataGridViewCellStyle2;
            dgMaintenance.EnableHeadersVisualStyles = false;
            dgMaintenance.GridColor = SystemColors.GrayText;
            dgMaintenance.Location = new Point(76, 160);
            dgMaintenance.Name = "dgMaintenance";
            dgMaintenance.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgMaintenance.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgMaintenance.RowHeadersVisible = false;
            dgMaintenance.RowHeadersWidth = 51;
            dgMaintenance.Size = new Size(1217, 547);
            dgMaintenance.TabIndex = 81;
            // 
            // ibtnEdit
            // 
            ibtnEdit.BackColor = Color.FromArgb(58, 124, 165);
            ibtnEdit.FlatAppearance.BorderSize = 0;
            ibtnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            ibtnEdit.FlatStyle = FlatStyle.Flat;
            ibtnEdit.ForeColor = Color.White;
            ibtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            ibtnEdit.IconColor = Color.White;
            ibtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnEdit.IconSize = 32;
            ibtnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnEdit.Location = new Point(1183, 113);
            ibtnEdit.Name = "ibtnEdit";
            ibtnEdit.Size = new Size(110, 41);
            ibtnEdit.TabIndex = 83;
            ibtnEdit.Text = "Edit";
            ibtnEdit.UseVisualStyleBackColor = false;
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
            btnScheduleMaintenance.Location = new Point(374, 113);
            btnScheduleMaintenance.Name = "btnScheduleMaintenance";
            btnScheduleMaintenance.Size = new Size(191, 41);
            btnScheduleMaintenance.TabIndex = 84;
            btnScheduleMaintenance.Text = "    Add New Customer";
            btnScheduleMaintenance.UseVisualStyleBackColor = false;
            btnScheduleMaintenance.Click += btnScheduleMaintenance_Click;
            // 
            // UC_Maintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnScheduleMaintenance);
            Controls.Add(ibtnEdit);
            Controls.Add(dgMaintenance);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
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
        private Label label12;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox textBox1;
        private DataGridView dgMaintenance;
        private FontAwesome.Sharp.IconButton ibtnEdit;
        private Button btnScheduleMaintenance;
    }
}
