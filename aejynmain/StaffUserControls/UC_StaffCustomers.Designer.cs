namespace aejynmain.StaffUserControls
{
    partial class UC_StaffCustomers
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_StaffCustomers));
            panel1 = new Panel();
            label1 = new Label();
            txtSearch = new TextBox();
            dgAddCustomer = new DataGridView();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnNewCustomer = new Button();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnViewCustomer = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAddCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 124, 165);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 75);
            panel1.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(169, 46);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(174, 168);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(232, 41);
            txtSearch.TabIndex = 76;
            // 
            // dgAddCustomer
            // 
            dgAddCustomer.AllowUserToResizeColumns = false;
            dgAddCustomer.AllowUserToResizeRows = false;
            dgAddCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgAddCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgAddCustomer.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgAddCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgAddCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgAddCustomer.ColumnHeadersHeight = 30;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgAddCustomer.DefaultCellStyle = dataGridViewCellStyle14;
            dgAddCustomer.EnableHeadersVisualStyles = false;
            dgAddCustomer.GridColor = SystemColors.GrayText;
            dgAddCustomer.Location = new Point(174, 215);
            dgAddCustomer.Name = "dgAddCustomer";
            dgAddCustomer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgAddCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgAddCustomer.RowHeadersVisible = false;
            dgAddCustomer.RowHeadersWidth = 51;
            dgAddCustomer.Size = new Size(1351, 686);
            dgAddCustomer.TabIndex = 77;
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
            btnSearch.Location = new Point(403, 168);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 41);
            btnSearch.TabIndex = 78;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.BackColor = Color.FromArgb(58, 124, 165);
            btnNewCustomer.FlatAppearance.BorderSize = 0;
            btnNewCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnNewCustomer.FlatStyle = FlatStyle.Flat;
            btnNewCustomer.ForeColor = Color.White;
            btnNewCustomer.Image = (Image)resources.GetObject("btnNewCustomer.Image");
            btnNewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewCustomer.Location = new Point(472, 168);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(191, 41);
            btnNewCustomer.TabIndex = 79;
            btnNewCustomer.Text = "    Add New Customer";
            btnNewCustomer.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(58, 124, 165);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.Location = new Point(669, 168);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 41);
            btnRefresh.TabIndex = 80;
            btnRefresh.UseVisualStyleBackColor = false;
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
            btnDelete.Location = new Point(1409, 168);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 41);
            btnDelete.TabIndex = 81;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
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
            btnEdit.Location = new Point(1293, 168);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 41);
            btnEdit.TabIndex = 82;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnViewCustomer
            // 
            btnViewCustomer.BackColor = Color.FromArgb(58, 124, 165);
            btnViewCustomer.FlatAppearance.BorderSize = 0;
            btnViewCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnViewCustomer.FlatStyle = FlatStyle.Flat;
            btnViewCustomer.ForeColor = Color.White;
            btnViewCustomer.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btnViewCustomer.IconColor = Color.White;
            btnViewCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnViewCustomer.IconSize = 32;
            btnViewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewCustomer.Location = new Point(1093, 168);
            btnViewCustomer.Name = "btnViewCustomer";
            btnViewCustomer.Size = new Size(194, 41);
            btnViewCustomer.TabIndex = 83;
            btnViewCustomer.Text = "View Customer History";
            btnViewCustomer.TextAlign = ContentAlignment.MiddleRight;
            btnViewCustomer.UseVisualStyleBackColor = false;
            // 
            // UC_StaffCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnViewCustomer);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnNewCustomer);
            Controls.Add(btnSearch);
            Controls.Add(dgAddCustomer);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Name = "UC_StaffCustomers";
            Size = new Size(1685, 951);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgAddCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtSearch;
        private DataGridView dgAddCustomer;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Button btnNewCustomer;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnViewCustomer;
    }
}
