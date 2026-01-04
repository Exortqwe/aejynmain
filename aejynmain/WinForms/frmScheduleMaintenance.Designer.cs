namespace aejynmain.WinForms
{
    partial class frmScheduleMaintenance
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            btnConfirm = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 124, 165);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 75);
            panel1.TabIndex = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(369, 46);
            label1.TabIndex = 0;
            label1.Text = "Schedule Maintenance";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 253);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 153);
            textBox1.TabIndex = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 222);
            label2.Name = "label2";
            label2.Size = new Size(238, 28);
            label2.TabIndex = 77;
            label2.Text = "Maintenance Description";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(58, 124, 165);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 106, 140);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(350, 438);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(243, 41);
            btnConfirm.TabIndex = 78;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(408, 289);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 79;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(408, 379);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 80;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(408, 253);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 81;
            label3.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(408, 348);
            label4.Name = "label4";
            label4.Size = new Size(94, 28);
            label4.TabIndex = 82;
            label4.Text = "End Date";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(27, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 83;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(272, 192);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 27);
            textBox3.TabIndex = 84;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(749, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 85;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 102);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 86;
            label5.Text = "Vehicle";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Oil Change", "PMS ", "Repair", "Other" });
            comboBox1.Location = new Point(490, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 28);
            comboBox1.TabIndex = 87;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(490, 88);
            label6.Name = "label6";
            label6.Size = new Size(178, 28);
            label6.TabIndex = 88;
            label6.Text = "Maintenance Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(749, 136);
            label7.Name = "label7";
            label7.Size = new Size(52, 28);
            label7.TabIndex = 89;
            label7.Text = "Cost";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(650, 213);
            label8.Name = "label8";
            label8.Size = new Size(190, 28);
            label8.TabIndex = 90;
            label8.Text = "Maintenance Status";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Scheduled", "In Progress", "Completed" });
            comboBox2.Location = new Point(650, 244);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 28);
            comboBox2.TabIndex = 91;
            // 
            // frmScheduleMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 496);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnConfirm);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "frmScheduleMaintenance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmScheduleMaintenance";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button btnConfirm;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox2;
    }
}