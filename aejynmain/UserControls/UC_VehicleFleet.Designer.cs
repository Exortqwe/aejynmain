namespace aejynmain.UserControls
{
    partial class UC_VehicleFleet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_VehicleFleet));
            label1 = new Label();
            btnNewCustomer = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.Location = new Point(177, 19);
            label1.Name = "label1";
            label1.Size = new Size(213, 46);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Fleet";
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.BackColor = Color.FromArgb(58, 124, 165);
            btnNewCustomer.FlatAppearance.BorderSize = 0;
            btnNewCustomer.FlatStyle = FlatStyle.Flat;
            btnNewCustomer.Font = new Font("Segoe UI", 13F);
            btnNewCustomer.ForeColor = Color.White;
            btnNewCustomer.Image = (Image)resources.GetObject("btnNewCustomer.Image");
            btnNewCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewCustomer.Location = new Point(177, 133);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(171, 55);
            btnNewCustomer.TabIndex = 2;
            btnNewCustomer.Text = "    Add Vehicle";
            btnNewCustomer.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(177, 65);
            label2.Name = "label2";
            label2.Size = new Size(295, 28);
            label2.TabIndex = 3;
            label2.Text = "Monitor and manage all vehicles";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(58, 124, 165);
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Rented", "Reserved", "Maintenance", "Out of Service", "Retired/Sold" });
            comboBox1.Location = new Point(354, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 43);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Status";
            // 
            // UC_VehicleFleet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(btnNewCustomer);
            Controls.Add(label1);
            Name = "UC_VehicleFleet";
            Size = new Size(1685, 1219);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNewCustomer;
        private Label label2;
        private ComboBox comboBox1;
    }
}
