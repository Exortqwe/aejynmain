namespace aejynmain.UserControls
{
    partial class UC_Maintenance
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
            panel9 = new Panel();
            label12 = new Label();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(58, 124, 165);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1400, 75);
            panel9.TabIndex = 75;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(15, 12);
            label12.Name = "label12";
            label12.Size = new Size(220, 46);
            label12.TabIndex = 36;
            label12.Text = "Maintenance";
            // 
            // UC_Maintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel9);
            Name = "UC_Maintenance";
            Size = new Size(1400, 591);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel9;
        private Label label12;
    }
}
