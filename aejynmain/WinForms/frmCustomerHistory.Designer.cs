namespace aejynmain
{
    partial class frmCustomerHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dgCustomerHistory = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomerHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 124, 165);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1081, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(215, 35);
            label1.TabIndex = 6;
            label1.Text = "Customer History";
            // 
            // dgCustomerHistory
            // 
            dgCustomerHistory.AllowUserToResizeColumns = false;
            dgCustomerHistory.AllowUserToResizeRows = false;
            dgCustomerHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgCustomerHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgCustomerHistory.BackgroundColor = Color.FromArgb(245, 247, 250);
            dgCustomerHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 124, 165);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgCustomerHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgCustomerHistory.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgCustomerHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgCustomerHistory.EnableHeadersVisualStyles = false;
            dgCustomerHistory.GridColor = SystemColors.GrayText;
            dgCustomerHistory.Location = new Point(12, 101);
            dgCustomerHistory.Name = "dgCustomerHistory";
            dgCustomerHistory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(51, 106, 140);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgCustomerHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgCustomerHistory.RowHeadersVisible = false;
            dgCustomerHistory.RowHeadersWidth = 51;
            dgCustomerHistory.Size = new Size(1051, 528);
            dgCustomerHistory.TabIndex = 6;
            dgCustomerHistory.CellContentClick += dgCustomerHistory_CellContentClick;
            // 
            // frmCustomerHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1081, 641);
            Controls.Add(dgCustomerHistory);
            Controls.Add(panel1);
            Name = "frmCustomerHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerHistory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCustomerHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgCustomerHistory;
    }
}