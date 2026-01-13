namespace aejynmain.WinForms
{
    partial class frmReceipt
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            lblCustomerName = new Label();
            lblLicenseNum = new Label();
            lblCustomerNumber = new Label();
            lblAddress = new Label();
            lblVehicle = new Label();
            lblTotalDays = new Label();
            lblDates = new Label();
            lblRate = new Label();
            lblPaymentType = new Label();
            lblPaymentMethod = new Label();
            lblTotalPrice = new Label();
            lblPaymentStatus = new Label();
            lblAmount = new Label();
            lblDate = new Label();
            panelReceipt = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnPrint = new Button();
            panelReceipt.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.Location = new Point(286, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 35);
            label1.TabIndex = 0;
            label1.Text = "RECEIPT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(576, 12);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 57);
            label4.Name = "label4";
            label4.Size = new Size(172, 28);
            label4.TabIndex = 3;
            label4.Text = "Customer Details:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 104);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 4;
            label5.Text = "Customer Name: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 143);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 5;
            label6.Text = "License Number: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 201);
            label7.Name = "label7";
            label7.Size = new Size(140, 28);
            label7.TabIndex = 6;
            label7.Text = "Rental Details:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 244);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 7;
            label8.Text = "Vehicle:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 276);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 8;
            label9.Text = "Total Days:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(27, 342);
            label10.Name = "label10";
            label10.Size = new Size(190, 28);
            label10.TabIndex = 9;
            label10.Text = "Payment Summary ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(409, 104);
            label11.Name = "label11";
            label11.Size = new Size(137, 20);
            label11.TabIndex = 10;
            label11.Text = "Customer Number: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(409, 143);
            label12.Name = "label12";
            label12.Size = new Size(69, 20);
            label12.TabIndex = 11;
            label12.Text = "Address: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(370, 244);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 12;
            label13.Text = "Dates : ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(375, 276);
            label15.Name = "label15";
            label15.Size = new Size(42, 20);
            label15.TabIndex = 14;
            label15.Text = "Rate:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(27, 379);
            label16.Name = "label16";
            label16.Size = new Size(103, 20);
            label16.TabIndex = 15;
            label16.Text = "Payment Type:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(27, 414);
            label17.Name = "label17";
            label17.Size = new Size(124, 20);
            label17.TabIndex = 16;
            label17.Text = "Payment Method:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(27, 448);
            label18.Name = "label18";
            label18.Size = new Size(81, 20);
            label18.TabIndex = 17;
            label18.Text = "Total Price:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(398, 379);
            label19.Name = "label19";
            label19.Size = new Size(112, 20);
            label19.TabIndex = 18;
            label19.Text = "Payment Status:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(398, 414);
            label20.Name = "label20";
            label20.Size = new Size(65, 20);
            label20.TabIndex = 19;
            label20.Text = "Amount:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(158, 104);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(58, 20);
            lblCustomerName.TabIndex = 20;
            lblCustomerName.Text = "label21";
            // 
            // lblLicenseNum
            // 
            lblLicenseNum.AutoSize = true;
            lblLicenseNum.Location = new Point(162, 143);
            lblLicenseNum.Name = "lblLicenseNum";
            lblLicenseNum.Size = new Size(58, 20);
            lblLicenseNum.TabIndex = 21;
            lblLicenseNum.Text = "label22";
            // 
            // lblCustomerNumber
            // 
            lblCustomerNumber.AutoSize = true;
            lblCustomerNumber.Location = new Point(552, 104);
            lblCustomerNumber.Name = "lblCustomerNumber";
            lblCustomerNumber.Size = new Size(58, 20);
            lblCustomerNumber.TabIndex = 22;
            lblCustomerNumber.Text = "label23";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(484, 143);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(58, 20);
            lblAddress.TabIndex = 23;
            lblAddress.Text = "label24";
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Location = new Point(99, 244);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(58, 20);
            lblVehicle.TabIndex = 24;
            lblVehicle.Text = "label25";
            // 
            // lblTotalDays
            // 
            lblTotalDays.AutoSize = true;
            lblTotalDays.Location = new Point(118, 276);
            lblTotalDays.Name = "lblTotalDays";
            lblTotalDays.Size = new Size(58, 20);
            lblTotalDays.TabIndex = 25;
            lblTotalDays.Text = "label26";
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Location = new Point(420, 244);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(58, 20);
            lblDates.TabIndex = 26;
            lblDates.Text = "label27";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(420, 276);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(58, 20);
            lblRate.TabIndex = 28;
            lblRate.Text = "label29";
            // 
            // lblPaymentType
            // 
            lblPaymentType.AutoSize = true;
            lblPaymentType.Location = new Point(127, 379);
            lblPaymentType.Name = "lblPaymentType";
            lblPaymentType.Size = new Size(58, 20);
            lblPaymentType.TabIndex = 29;
            lblPaymentType.Text = "label30";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(149, 414);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(58, 20);
            lblPaymentMethod.TabIndex = 30;
            lblPaymentMethod.Text = "label31";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(114, 448);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(58, 20);
            lblTotalPrice.TabIndex = 31;
            lblTotalPrice.Text = "label32";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Location = new Point(516, 379);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(58, 20);
            lblPaymentStatus.TabIndex = 32;
            lblPaymentStatus.Text = "label33";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(469, 414);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(58, 20);
            lblAmount.TabIndex = 33;
            lblAmount.Text = "label34";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(622, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 20);
            lblDate.TabIndex = 35;
            lblDate.Text = "label36";
            // 
            // panelReceipt
            // 
            panelReceipt.BorderStyle = BorderStyle.FixedSingle;
            panelReceipt.Controls.Add(lblDate);
            panelReceipt.Controls.Add(lblAmount);
            panelReceipt.Controls.Add(lblPaymentStatus);
            panelReceipt.Controls.Add(lblTotalPrice);
            panelReceipt.Controls.Add(lblPaymentMethod);
            panelReceipt.Controls.Add(lblPaymentType);
            panelReceipt.Controls.Add(lblRate);
            panelReceipt.Controls.Add(lblDates);
            panelReceipt.Controls.Add(lblTotalDays);
            panelReceipt.Controls.Add(lblVehicle);
            panelReceipt.Controls.Add(lblAddress);
            panelReceipt.Controls.Add(lblCustomerNumber);
            panelReceipt.Controls.Add(lblLicenseNum);
            panelReceipt.Controls.Add(lblCustomerName);
            panelReceipt.Controls.Add(label20);
            panelReceipt.Controls.Add(label19);
            panelReceipt.Controls.Add(label18);
            panelReceipt.Controls.Add(label17);
            panelReceipt.Controls.Add(label16);
            panelReceipt.Controls.Add(label15);
            panelReceipt.Controls.Add(label13);
            panelReceipt.Controls.Add(label12);
            panelReceipt.Controls.Add(label11);
            panelReceipt.Controls.Add(label10);
            panelReceipt.Controls.Add(label9);
            panelReceipt.Controls.Add(label8);
            panelReceipt.Controls.Add(label7);
            panelReceipt.Controls.Add(label6);
            panelReceipt.Controls.Add(label5);
            panelReceipt.Controls.Add(label4);
            panelReceipt.Controls.Add(label3);
            panelReceipt.Controls.Add(label1);
            panelReceipt.Location = new Point(25, 9);
            panelReceipt.Name = "panelReceipt";
            panelReceipt.Size = new Size(736, 489);
            panelReceipt.TabIndex = 36;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(664, 504);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(97, 34);
            btnPrint.TabIndex = 37;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmReceipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 578);
            Controls.Add(btnPrint);
            Controls.Add(panelReceipt);
            Name = "frmReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReceipt";
            panelReceipt.ResumeLayout(false);
            panelReceipt.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label lblCustomerName;
        private Label lblLicenseNum;
        private Label lblCustomerNumber;
        private Label lblAddress;
        private Label lblVehicle;
        private Label lblTotalDays;
        private Label lblDates;
        private Label lblReturnDate;
        private Label lblRate;
        private Label lblPaymentType;
        private Label lblPaymentMethod;
        private Label lblTotalPrice;
        private Label lblPaymentStatus;
        private Label lblAmount;
        private Label lblDate;
        private Panel panelReceipt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnPrint;
    }
}