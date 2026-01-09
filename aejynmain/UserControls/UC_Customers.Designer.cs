namespace aejynmain.UserControls
{
    partial class UC_Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customers));
            dgAddCustomer = new DataGridView();
            panel1 = new Panel();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnNewCustomer = new Button();
            txtSearch = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnViewCustomer = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgAddCustomer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dgAddCustomer.Location = new Point(48, 189);
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
            dgAddCustomer.Size = new Size(1606, 686);
            dgAddCustomer.TabIndex = 72;
            dgAddCustomer.CellEndEdit += dgAddCustomer_CellEndEdit;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 73, 102);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 112);
            panel1.TabIndex = 74;
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
            btnRefresh.Location = new Point(541, 142);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 41);
            btnRefresh.TabIndex = 73;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
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
            btnNewCustomer.Location = new Point(344, 142);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(191, 41);
            btnNewCustomer.TabIndex = 1;
            btnNewCustomer.Text = "    Add New Customer";
            btnNewCustomer.UseVisualStyleBackColor = false;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(46, 142);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(232, 41);
            txtSearch.TabIndex = 75;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            btnSearch.Location = new Point(275, 142);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 41);
            btnSearch.TabIndex = 76;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
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
            btnDelete.Location = new Point(1538, 142);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 41);
            btnDelete.TabIndex = 77;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnEdit.Location = new Point(1422, 142);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 41);
            btnEdit.TabIndex = 78;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            btnViewCustomer.Location = new Point(1222, 142);
            btnViewCustomer.Name = "btnViewCustomer";
            btnViewCustomer.Size = new Size(194, 41);
            btnViewCustomer.TabIndex = 79;
            btnViewCustomer.Text = "View Customer History";
            btnViewCustomer.TextAlign = ContentAlignment.MiddleRight;
            btnViewCustomer.UseVisualStyleBackColor = false;
            btnViewCustomer.Click += btnViewCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(569, 46);
            label1.TabIndex = 39;
            label1.Text = "Vehicle Rental Management System";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlLight;
            label12.Location = new Point(3, 60);
            label12.Name = "label12";
            label12.Size = new Size(245, 32);
            label12.TabIndex = 38;
            label12.Text = "Customers Overview ";
            // 
            // UC_Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(btnViewCustomer);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Controls.Add(btnRefresh);
            Controls.Add(dgAddCustomer);
            Controls.Add(btnNewCustomer);
            Name = "UC_Customers";
            Size = new Size(1685, 951);
            ((System.ComponentModel.ISupportInitialize)dgAddCustomer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgAddCustomer;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Button btnNewCustomer;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnViewCustomer;
        private Label label1;
        private Label label12;
    }
}
