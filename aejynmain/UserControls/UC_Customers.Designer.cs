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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customers));
            label1 = new Label();
            dgAddCustomer = new DataGridView();
            panel1 = new Panel();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnNewCustomer = new Button();
            btnViewCustomer = new Button();
            txtSearch = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgAddCustomer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // dgAddCustomer
            // 
            dgAddCustomer.AllowUserToResizeColumns = false;
            dgAddCustomer.AllowUserToResizeRows = false;
            dgAddCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgAddCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgAddCustomer.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgAddCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgAddCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgAddCustomer.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgAddCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            dgAddCustomer.EnableHeadersVisualStyles = false;
            dgAddCustomer.GridColor = SystemColors.GrayText;
            dgAddCustomer.Location = new Point(152, 205);
            dgAddCustomer.Name = "dgAddCustomer";
            dgAddCustomer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgAddCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgAddCustomer.RowHeadersVisible = false;
            dgAddCustomer.RowHeadersWidth = 51;
            dgAddCustomer.Size = new Size(1363, 494);
            dgAddCustomer.TabIndex = 72;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 124, 165);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 75);
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
            btnRefresh.Location = new Point(822, 141);
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
            btnNewCustomer.Location = new Point(625, 141);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(191, 41);
            btnNewCustomer.TabIndex = 1;
            btnNewCustomer.Text = "    Add New Customer";
            btnNewCustomer.UseVisualStyleBackColor = false;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // btnViewCustomer
            // 
            btnViewCustomer.BackColor = Color.FromArgb(58, 124, 165);
            btnViewCustomer.FlatAppearance.BorderSize = 0;
            btnViewCustomer.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnViewCustomer.FlatStyle = FlatStyle.Flat;
            btnViewCustomer.ForeColor = Color.White;
            btnViewCustomer.Image = (Image)resources.GetObject("btnViewCustomer.Image");
            btnViewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewCustomer.Location = new Point(450, 141);
            btnViewCustomer.Name = "btnViewCustomer";
            btnViewCustomer.Size = new Size(169, 41);
            btnViewCustomer.TabIndex = 4;
            btnViewCustomer.Text = "    View Customer";
            btnViewCustomer.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(152, 141);
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
            btnSearch.Location = new Point(381, 141);
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
            btnDelete.Location = new Point(1449, 141);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 41);
            btnDelete.TabIndex = 77;
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
            btnEdit.Location = new Point(1377, 141);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(66, 41);
            btnEdit.TabIndex = 78;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // UC_Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Controls.Add(btnRefresh);
            Controls.Add(btnViewCustomer);
            Controls.Add(dgAddCustomer);
            Controls.Add(btnNewCustomer);
            Name = "UC_Customers";
            Size = new Size(1685, 1219);
            ((System.ComponentModel.ISupportInitialize)dgAddCustomer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgAddCustomer;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private Button btnNewCustomer;
        private Button btnViewCustomer;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnEdit;
    }
}
