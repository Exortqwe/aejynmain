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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel9 = new Panel();
            label12 = new Label();
            dgFleetAvailabilityStatus = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new FontAwesome.Sharp.IconButton();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            btnRefresh = new FontAwesome.Sharp.IconButton();
            btnAddUser = new FontAwesome.Sharp.IconButton();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgFleetAvailabilityStatus).BeginInit();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgFleetAvailabilityStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgFleetAvailabilityStatus.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgFleetAvailabilityStatus.DefaultCellStyle = dataGridViewCellStyle2;
            dgFleetAvailabilityStatus.EnableHeadersVisualStyles = false;
            dgFleetAvailabilityStatus.GridColor = SystemColors.GrayText;
            dgFleetAvailabilityStatus.Location = new Point(86, 186);
            dgFleetAvailabilityStatus.Name = "dgFleetAvailabilityStatus";
            dgFleetAvailabilityStatus.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgFleetAvailabilityStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgFleetAvailabilityStatus.RowHeadersVisible = false;
            dgFleetAvailabilityStatus.RowHeadersWidth = 51;
            dgFleetAvailabilityStatus.Size = new Size(1335, 373);
            dgFleetAvailabilityStatus.TabIndex = 74;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(86, 142);
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
            btnSearch.Location = new Point(353, 142);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 34);
            btnSearch.TabIndex = 77;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "RentalAgent" });
            comboBox1.Location = new Point(677, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 78;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(677, 125);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 79;
            label1.Text = "Role :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(852, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(852, 122);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 81;
            label2.Text = "Date :";
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
            btnRefresh.Location = new Point(565, 142);
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
            btnAddUser.Location = new Point(422, 142);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(137, 34);
            btnAddUser.TabIndex = 83;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // UC_UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddUser);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgFleetAvailabilityStatus);
            Controls.Add(panel9);
            Name = "UC_UserManagement";
            Size = new Size(1509, 1219);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgFleetAvailabilityStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel9;
        private Label label12;
        private DataGridView dgFleetAvailabilityStatus;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private ComboBox comboBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnAddUser;
    }
}
