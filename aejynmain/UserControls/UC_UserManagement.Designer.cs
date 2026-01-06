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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UserManagement));
            panel9 = new Panel();
            label12 = new Label();
            dgFleetAvailabilityStatus = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnAddUser = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblTotalUsers = new Label();
            lblActiveUsers = new Label();
            lblInactiveUsers = new Label();
            lblSuspendedUsers = new Label();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgFleetAvailabilityStatus).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(58, 124, 165);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1509, 75);
            panel9.TabIndex = 75;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(15, 12);
            label12.Name = "label12";
            label12.Size = new Size(304, 46);
            label12.TabIndex = 36;
            label12.Text = "User Management";
            // 
            // dgFleetAvailabilityStatus
            // 
            dgFleetAvailabilityStatus.AllowUserToResizeColumns = false;
            dgFleetAvailabilityStatus.AllowUserToResizeRows = false;
            dgFleetAvailabilityStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgFleetAvailabilityStatus.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgFleetAvailabilityStatus.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgFleetAvailabilityStatus.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgFleetAvailabilityStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgFleetAvailabilityStatus.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgFleetAvailabilityStatus.DefaultCellStyle = dataGridViewCellStyle5;
            dgFleetAvailabilityStatus.EnableHeadersVisualStyles = false;
            dgFleetAvailabilityStatus.GridColor = SystemColors.GrayText;
            dgFleetAvailabilityStatus.Location = new Point(68, 252);
            dgFleetAvailabilityStatus.Name = "dgFleetAvailabilityStatus";
            dgFleetAvailabilityStatus.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgFleetAvailabilityStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgFleetAvailabilityStatus.RowHeadersVisible = false;
            dgFleetAvailabilityStatus.RowHeadersWidth = 51;
            dgFleetAvailabilityStatus.Size = new Size(1335, 373);
            dgFleetAvailabilityStatus.TabIndex = 74;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(68, 208);
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
            btnSearch.Location = new Point(335, 208);
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
            btnRefresh.Location = new Point(547, 208);
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
            btnAddUser.Location = new Point(404, 208);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(137, 34);
            btnAddUser.TabIndex = 83;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
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
            btnEdit.Location = new Point(1171, 205);
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
            btnDelete.Location = new Point(1287, 205);
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
            panel1.Location = new Point(152, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 92);
            panel1.TabIndex = 86;
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
            panel2.Location = new Point(453, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 92);
            panel2.TabIndex = 87;
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
            panel3.Location = new Point(754, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(281, 92);
            panel3.TabIndex = 88;
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
            panel4.Location = new Point(1051, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(281, 92);
            panel4.TabIndex = 89;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 67);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(220, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 67);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
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
            Controls.Add(dgFleetAvailabilityStatus);
            Controls.Add(panel9);
            Name = "UC_UserManagement";
            Size = new Size(1509, 1219);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgFleetAvailabilityStatus).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel9;
        private Label label12;
        private DataGridView dgFleetAvailabilityStatus;
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
    }
}
