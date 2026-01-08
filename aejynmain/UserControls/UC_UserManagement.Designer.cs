namespace aejynmain.UserControls
{
    partial class UC_UserManagement
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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UserManagement));
            panel9 = new Panel();
            label12 = new Label();
            dgUserManagement = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnAddUser = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblTotalUsers = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            lblActiveUsers = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            lblInactiveUsers = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel4 = new Panel();
            lblSuspendedUsers = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUserManagement).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(28, 73, 102);
            panel9.Controls.Add(label5);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1509, 112);
            panel9.TabIndex = 75;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(569, 46);
            label12.TabIndex = 36;
            label12.Text = "Vehicle Rental Management System";
            // 
            // dgUserManagement
            // 
            dgUserManagement.AllowUserToResizeColumns = false;
            dgUserManagement.AllowUserToResizeRows = false;
            dgUserManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgUserManagement.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgUserManagement.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgUserManagement.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle19.SelectionForeColor = Color.White;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dgUserManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dgUserManagement.ColumnHeadersHeight = 30;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            dgUserManagement.DefaultCellStyle = dataGridViewCellStyle20;
            dgUserManagement.EnableHeadersVisualStyles = false;
            dgUserManagement.GridColor = SystemColors.GrayText;
            dgUserManagement.Location = new Point(83, 304);
            dgUserManagement.Name = "dgUserManagement";
            dgUserManagement.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = SystemColors.Control;
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            dgUserManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            dgUserManagement.RowHeadersVisible = false;
            dgUserManagement.RowHeadersWidth = 51;
            dgUserManagement.Size = new Size(1335, 373);
            dgUserManagement.TabIndex = 74;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(83, 260);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(271, 34);
            txtSearch.TabIndex = 76;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(58, 124, 165);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 32;
            btnSearch.Location = new Point(350, 260);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 34);
            btnSearch.TabIndex = 77;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(58, 124, 165);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefresh.IconColor = Color.White;
            btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefresh.IconSize = 32;
            btnRefresh.Location = new Point(562, 260);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(63, 34);
            btnRefresh.TabIndex = 82;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(58, 124, 165);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.ForeColor = Color.White;
            btnAddUser.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAddUser.IconColor = Color.White;
            btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddUser.IconSize = 32;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(419, 260);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(137, 34);
            btnAddUser.TabIndex = 83;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
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
            btnEdit.Location = new Point(1186, 257);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 41);
            btnEdit.TabIndex = 85;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
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
            btnDelete.Location = new Point(1302, 257);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 41);
            btnDelete.TabIndex = 84;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 124, 165);
            panel1.Controls.Add(lblTotalUsers);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(167, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 92);
            panel1.TabIndex = 86;
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.Font = new Font("Segoe UI", 13F);
            lblTotalUsers.Location = new Point(3, 51);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(71, 30);
            lblTotalUsers.TabIndex = 2;
            lblTotalUsers.Text = "label5";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 67);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 0;
            label1.Text = "Total Users";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(58, 124, 165);
            panel2.Controls.Add(lblActiveUsers);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(468, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 92);
            panel2.TabIndex = 87;
            // 
            // lblActiveUsers
            // 
            lblActiveUsers.AutoSize = true;
            lblActiveUsers.Font = new Font("Segoe UI", 13F);
            lblActiveUsers.Location = new Point(3, 51);
            lblActiveUsers.Name = "lblActiveUsers";
            lblActiveUsers.Size = new Size(71, 30);
            lblActiveUsers.TabIndex = 3;
            lblActiveUsers.Text = "label6";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(220, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 67);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(141, 31);
            label2.TabIndex = 0;
            label2.Text = "Active Users";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(58, 124, 165);
            panel3.Controls.Add(lblInactiveUsers);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label3);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(769, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(281, 92);
            panel3.TabIndex = 88;
            // 
            // lblInactiveUsers
            // 
            lblInactiveUsers.AutoSize = true;
            lblInactiveUsers.Font = new Font("Segoe UI", 13F);
            lblInactiveUsers.Location = new Point(3, 51);
            lblInactiveUsers.Name = "lblInactiveUsers";
            lblInactiveUsers.Size = new Size(71, 30);
            lblInactiveUsers.TabIndex = 4;
            lblInactiveUsers.Text = "label7";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(220, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 67);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(158, 31);
            label3.TabIndex = 0;
            label3.Text = "Inactive Users";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(58, 124, 165);
            panel4.Controls.Add(lblSuspendedUsers);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label4);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(1066, 142);
            panel4.Name = "panel4";
            panel4.Size = new Size(281, 92);
            panel4.TabIndex = 89;
            // 
            // lblSuspendedUsers
            // 
            lblSuspendedUsers.AutoSize = true;
            lblSuspendedUsers.Font = new Font("Segoe UI", 13F);
            lblSuspendedUsers.Location = new Point(3, 51);
            lblSuspendedUsers.Name = "lblSuspendedUsers";
            lblSuspendedUsers.Size = new Size(71, 30);
            lblSuspendedUsers.TabIndex = 5;
            lblSuspendedUsers.Text = "label8";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(220, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 67);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(192, 31);
            label4.TabIndex = 0;
            label4.Text = "Suspended Users";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(3, 59);
            label5.Name = "label5";
            label5.Size = new Size(223, 32);
            label5.TabIndex = 37;
            label5.Text = "User Management ";
            // 
            // UC_UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAddUser);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgUserManagement);
            Controls.Add(panel9);
            Name = "UC_UserManagement";
            Size = new Size(1509, 1219);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgUserManagement).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel9;
        private Label label12;
        private DataGridView dgUserManagement;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDelete;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Label lblTotalUsers;
        private PictureBox pictureBox1;
        private Label lblActiveUsers;
        private PictureBox pictureBox2;
        private Label lblInactiveUsers;
        private PictureBox pictureBox3;
        private Label lblSuspendedUsers;
        private PictureBox pictureBox4;
        private Label label5;
    }
}
