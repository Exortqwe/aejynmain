namespace aejynmain.WinForms
{
    partial class frmBilling
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
            panel16 = new Panel();
            lblRentalID = new Label();
            lblCustomerName = new Label();
            label30 = new Label();
            label28 = new Label();
            label1 = new Label();
            panelBilling = new Panel();
            btnPrint = new Button();
            printDocumentBilling = new System.Drawing.Printing.PrintDocument();
            panel5 = new Panel();
            label22 = new Label();
            lblRentalCharges = new Label();
            panel6 = new Panel();
            label21 = new Label();
            lblAdditionalCharges = new Label();
            panel7 = new Panel();
            label19 = new Label();
            lblTotalCharges = new Label();
            panel8 = new Panel();
            label11 = new Label();
            lblCleaningFees = new Label();
            panel11 = new Panel();
            label26 = new Label();
            lblSubTotal = new Label();
            panel12 = new Panel();
            label10 = new Label();
            lblDepositPaid = new Label();
            panel13 = new Panel();
            label17 = new Label();
            lblBalanceDue = new Label();
            panel14 = new Panel();
            label20 = new Label();
            lblRefund = new Label();
            label27 = new Label();
            lblPaymentMethod = new Label();
            panel1 = new Panel();
            panel16.SuspendLayout();
            panelBilling.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel16
            // 
            panel16.BorderStyle = BorderStyle.FixedSingle;
            panel16.Controls.Add(lblRentalID);
            panel16.Controls.Add(lblCustomerName);
            panel16.Controls.Add(label30);
            panel16.Controls.Add(label28);
            panel16.Location = new Point(43, 61);
            panel16.Name = "panel16";
            panel16.Size = new Size(632, 67);
            panel16.TabIndex = 18;
            // 
            // lblRentalID
            // 
            lblRentalID.AutoSize = true;
            lblRentalID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalID.Location = new Point(525, 23);
            lblRentalID.Name = "lblRentalID";
            lblRentalID.Size = new Size(0, 23);
            lblRentalID.TabIndex = 31;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(181, 23);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(0, 23);
            lblCustomerName.TabIndex = 30;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(422, 21);
            label30.Name = "label30";
            label30.Size = new Size(97, 25);
            label30.TabIndex = 29;
            label30.Text = "Rental ID :";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(19, 21);
            label28.Name = "label28";
            label28.Size = new Size(156, 25);
            label28.TabIndex = 27;
            label28.Text = "Customer Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 35);
            label1.TabIndex = 19;
            label1.Text = "Billing";
            // 
            // panelBilling
            // 
            panelBilling.Controls.Add(panel1);
            panelBilling.Controls.Add(panel14);
            panelBilling.Controls.Add(panel5);
            panelBilling.Controls.Add(panel13);
            panelBilling.Controls.Add(label1);
            panelBilling.Controls.Add(panel12);
            panelBilling.Controls.Add(panel11);
            panelBilling.Controls.Add(panel16);
            panelBilling.Controls.Add(panel8);
            panelBilling.Controls.Add(panel6);
            panelBilling.Controls.Add(panel7);
            panelBilling.Location = new Point(44, 9);
            panelBilling.Name = "panelBilling";
            panelBilling.Size = new Size(719, 701);
            panelBilling.TabIndex = 20;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(612, 716);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(107, 37);
            btnPrint.TabIndex = 22;
            btnPrint.Text = "PRINT BILL";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // printDocumentBilling
            // 
            printDocumentBilling.PrintPage += printDocumentBilling_PrintPage;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(lblRentalCharges);
            panel5.Controls.Add(label22);
            panel5.Location = new Point(43, 134);
            panel5.Name = "panel5";
            panel5.Size = new Size(632, 54);
            panel5.TabIndex = 31;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(3, 13);
            label22.Name = "label22";
            label22.Size = new Size(145, 25);
            label22.TabIndex = 29;
            label22.Text = "Rental Charges :";
            // 
            // lblRentalCharges
            // 
            lblRentalCharges.AutoSize = true;
            lblRentalCharges.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalCharges.Location = new Point(537, 17);
            lblRentalCharges.Name = "lblRentalCharges";
            lblRentalCharges.Size = new Size(20, 23);
            lblRentalCharges.TabIndex = 30;
            lblRentalCharges.Text = "d";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(lblAdditionalCharges);
            panel6.Controls.Add(label21);
            panel6.Location = new Point(43, 199);
            panel6.Name = "panel6";
            panel6.Size = new Size(632, 54);
            panel6.TabIndex = 32;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(6, 13);
            label21.Name = "label21";
            label21.Size = new Size(179, 25);
            label21.TabIndex = 28;
            label21.Text = "Additional Charges :";
            // 
            // lblAdditionalCharges
            // 
            lblAdditionalCharges.AutoSize = true;
            lblAdditionalCharges.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdditionalCharges.Location = new Point(537, 15);
            lblAdditionalCharges.Name = "lblAdditionalCharges";
            lblAdditionalCharges.Size = new Size(20, 23);
            lblAdditionalCharges.TabIndex = 31;
            lblAdditionalCharges.Text = "d";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(lblTotalCharges);
            panel7.Controls.Add(label19);
            panel7.Location = new Point(43, 262);
            panel7.Name = "panel7";
            panel7.Size = new Size(632, 54);
            panel7.TabIndex = 33;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(6, 12);
            label19.Name = "label19";
            label19.Size = new Size(132, 25);
            label19.TabIndex = 24;
            label19.Text = "Total Charges :";
            // 
            // lblTotalCharges
            // 
            lblTotalCharges.AutoSize = true;
            lblTotalCharges.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCharges.Location = new Point(537, 14);
            lblTotalCharges.Name = "lblTotalCharges";
            lblTotalCharges.Size = new Size(20, 23);
            lblTotalCharges.TabIndex = 32;
            lblTotalCharges.Text = "d";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(lblCleaningFees);
            panel8.Controls.Add(label11);
            panel8.Location = new Point(43, 322);
            panel8.Name = "panel8";
            panel8.Size = new Size(632, 54);
            panel8.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 13);
            label11.Name = "label11";
            label11.Size = new Size(136, 25);
            label11.TabIndex = 35;
            label11.Text = "Cleaning Fees :";
            // 
            // lblCleaningFees
            // 
            lblCleaningFees.AutoSize = true;
            lblCleaningFees.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCleaningFees.Location = new Point(536, 13);
            lblCleaningFees.Name = "lblCleaningFees";
            lblCleaningFees.Size = new Size(20, 23);
            lblCleaningFees.TabIndex = 33;
            lblCleaningFees.Text = "d";
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.Fixed3D;
            panel11.Controls.Add(lblSubTotal);
            panel11.Controls.Add(label26);
            panel11.Location = new Point(43, 382);
            panel11.Name = "panel11";
            panel11.Size = new Size(632, 54);
            panel11.TabIndex = 36;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(8, 15);
            label26.Name = "label26";
            label26.Size = new Size(93, 25);
            label26.TabIndex = 37;
            label26.Text = "SubTotal :";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(538, 17);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(20, 23);
            lblSubTotal.TabIndex = 37;
            lblSubTotal.Text = "d";
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.Fixed3D;
            panel12.Controls.Add(lblDepositPaid);
            panel12.Controls.Add(label10);
            panel12.Location = new Point(43, 442);
            panel12.Name = "panel12";
            panel12.Size = new Size(632, 54);
            panel12.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(8, 15);
            label10.Name = "label10";
            label10.Size = new Size(126, 25);
            label10.TabIndex = 20;
            label10.Text = "Deposit Paid :";
            // 
            // lblDepositPaid
            // 
            lblDepositPaid.AutoSize = true;
            lblDepositPaid.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepositPaid.Location = new Point(538, 15);
            lblDepositPaid.Name = "lblDepositPaid";
            lblDepositPaid.Size = new Size(20, 23);
            lblDepositPaid.TabIndex = 38;
            lblDepositPaid.Text = "d";
            // 
            // panel13
            // 
            panel13.BorderStyle = BorderStyle.Fixed3D;
            panel13.Controls.Add(lblBalanceDue);
            panel13.Controls.Add(label17);
            panel13.Location = new Point(43, 502);
            panel13.Name = "panel13";
            panel13.Size = new Size(632, 54);
            panel13.TabIndex = 38;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(8, 15);
            label17.Name = "label17";
            label17.Size = new Size(123, 25);
            label17.TabIndex = 15;
            label17.Text = "Balance Due :";
            // 
            // lblBalanceDue
            // 
            lblBalanceDue.AutoSize = true;
            lblBalanceDue.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalanceDue.Location = new Point(538, 20);
            lblBalanceDue.Name = "lblBalanceDue";
            lblBalanceDue.Size = new Size(20, 23);
            lblBalanceDue.TabIndex = 39;
            lblBalanceDue.Text = "d";
            // 
            // panel14
            // 
            panel14.BorderStyle = BorderStyle.Fixed3D;
            panel14.Controls.Add(lblRefund);
            panel14.Controls.Add(label20);
            panel14.Location = new Point(43, 562);
            panel14.Name = "panel14";
            panel14.Size = new Size(632, 54);
            panel14.TabIndex = 39;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(13, 15);
            label20.Name = "label20";
            label20.Size = new Size(81, 25);
            label20.TabIndex = 26;
            label20.Text = "Refund :";
            // 
            // lblRefund
            // 
            lblRefund.AutoSize = true;
            lblRefund.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRefund.Location = new Point(537, 17);
            lblRefund.Name = "lblRefund";
            lblRefund.Size = new Size(20, 23);
            lblRefund.TabIndex = 40;
            lblRefund.Text = "d";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(8, 12);
            label27.Name = "label27";
            label27.Size = new Size(164, 25);
            label27.TabIndex = 27;
            label27.Text = "Payment Method :";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentMethod.Location = new Point(538, 14);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(20, 23);
            lblPaymentMethod.TabIndex = 41;
            lblPaymentMethod.Text = "d";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblPaymentMethod);
            panel1.Controls.Add(label27);
            panel1.Location = new Point(43, 622);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 54);
            panel1.TabIndex = 42;
            // 
            // frmBilling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 866);
            Controls.Add(btnPrint);
            Controls.Add(panelBilling);
            Name = "frmBilling";
            Text = "frmBilling";
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panelBilling.ResumeLayout(false);
            panelBilling.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel16;
        private Label lblRentalID;
        private Label lblCustomerName;
        private Label label30;
        private Label label28;
        private Label label1;
        private Panel panelBilling;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocumentBilling;
        private Label lblPaymentMethod;
        private Label label27;
        private Panel panel5;
        private Label lblRentalCharges;
        private Label label22;
        private Panel panel6;
        private Label lblAdditionalCharges;
        private Label label21;
        private Panel panel7;
        private Label lblTotalCharges;
        private Label label19;
        private Panel panel8;
        private Label lblCleaningFees;
        private Label label11;
        private Panel panel11;
        private Label lblSubTotal;
        private Label label26;
        private Panel panel12;
        private Label lblDepositPaid;
        private Label label10;
        private Panel panel13;
        private Label lblBalanceDue;
        private Label label17;
        private Panel panel14;
        private Label lblRefund;
        private Label label20;
        private Panel panel1;
    }
}