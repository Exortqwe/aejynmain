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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            btnNewCustomer = new Button();
            dataGridView1 = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            EmailAddress = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            LicenseNumber = new DataGridViewTextBoxColumn();
            LicenseExpiryDate = new DataGridViewTextBoxColumn();
            DateRegistered = new DataGridViewTextBoxColumn();
            btnSearchCustomer = new Button();
            btnViewCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(153, 29);
            label1.Name = "label1";
            label1.Size = new Size(169, 46);
            label1.TabIndex = 0;
            label1.Text = "Customer";
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.BackColor = Color.FromArgb(58, 124, 165);
            btnNewCustomer.FlatAppearance.BorderSize = 0;
            btnNewCustomer.FlatStyle = FlatStyle.Flat;
            btnNewCustomer.ForeColor = Color.White;
            btnNewCustomer.Image = (Image)resources.GetObject("btnNewCustomer.Image");
            btnNewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewCustomer.Location = new Point(539, 102);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(196, 52);
            btnNewCustomer.TabIndex = 1;
            btnNewCustomer.Text = "    Add New Customer";
            btnNewCustomer.UseVisualStyleBackColor = false;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(245, 247, 250);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FirstName, LastName, Gender, BirthDate, ContactNumber, EmailAddress, Address, LicenseNumber, LicenseExpiryDate, DateRegistered });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.GrayText;
            dataGridView1.Location = new Point(153, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1363, 494);
            dataGridView1.TabIndex = 72;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerID.HeaderText = "Customer ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 119;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.Width = 108;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LastName.HeaderText = "Last Name";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.Width = 107;
            // 
            // Gender
            // 
            Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            Gender.Width = 85;
            // 
            // BirthDate
            // 
            BirthDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BirthDate.HeaderText = "Birth of Date";
            BirthDate.MinimumWidth = 6;
            BirthDate.Name = "BirthDate";
            BirthDate.Width = 122;
            // 
            // ContactNumber
            // 
            ContactNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ContactNumber.HeaderText = "Contact Number";
            ContactNumber.MinimumWidth = 6;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.Width = 146;
            // 
            // EmailAddress
            // 
            EmailAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmailAddress.HeaderText = "Email Address";
            EmailAddress.MinimumWidth = 6;
            EmailAddress.Name = "EmailAddress";
            EmailAddress.Width = 131;
            // 
            // Address
            // 
            Address.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 90;
            // 
            // LicenseNumber
            // 
            LicenseNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LicenseNumber.HeaderText = "License Number";
            LicenseNumber.MinimumWidth = 6;
            LicenseNumber.Name = "LicenseNumber";
            LicenseNumber.Width = 143;
            // 
            // LicenseExpiryDate
            // 
            LicenseExpiryDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LicenseExpiryDate.HeaderText = "License Expiry Date";
            LicenseExpiryDate.MinimumWidth = 6;
            LicenseExpiryDate.Name = "LicenseExpiryDate";
            LicenseExpiryDate.Width = 165;
            // 
            // DateRegistered
            // 
            DateRegistered.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DateRegistered.HeaderText = "Date Registered";
            DateRegistered.MinimumWidth = 6;
            DateRegistered.Name = "DateRegistered";
            DateRegistered.Width = 144;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.FromArgb(58, 124, 165);
            btnSearchCustomer.FlatAppearance.BorderSize = 0;
            btnSearchCustomer.FlatStyle = FlatStyle.Flat;
            btnSearchCustomer.ForeColor = Color.White;
            btnSearchCustomer.Image = (Image)resources.GetObject("btnSearchCustomer.Image");
            btnSearchCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchCustomer.Location = new Point(153, 102);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(187, 52);
            btnSearchCustomer.TabIndex = 3;
            btnSearchCustomer.Text = "    Search Customer";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // btnViewCustomer
            // 
            btnViewCustomer.BackColor = Color.FromArgb(58, 124, 165);
            btnViewCustomer.FlatAppearance.BorderSize = 0;
            btnViewCustomer.FlatStyle = FlatStyle.Flat;
            btnViewCustomer.ForeColor = Color.White;
            btnViewCustomer.Image = (Image)resources.GetObject("btnViewCustomer.Image");
            btnViewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewCustomer.Location = new Point(346, 102);
            btnViewCustomer.Name = "btnViewCustomer";
            btnViewCustomer.Size = new Size(187, 52);
            btnViewCustomer.TabIndex = 4;
            btnViewCustomer.Text = "    View Customer";
            btnViewCustomer.UseVisualStyleBackColor = false;
            // 
            // UC_Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(btnViewCustomer);
            Controls.Add(btnSearchCustomer);
            Controls.Add(dataGridView1);
            Controls.Add(btnNewCustomer);
            Controls.Add(label1);
            Name = "UC_Customers";
            Size = new Size(1685, 1219);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNewCustomer;
        private DataGridView dataGridView1;
        private Button btnSearchCustomer;
        private Button btnViewCustomer;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn EmailAddress;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn LicenseNumber;
        private DataGridViewTextBoxColumn LicenseExpiryDate;
        private DataGridViewTextBoxColumn DateRegistered;
    }
}
