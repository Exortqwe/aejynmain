using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aejynmain.WinForms
{
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }
        public void LoadInvoice(
            string date,
            string customerName,
            string licenseNumber,
            string contactNumber,
            string address,
            string vehicle,
            string dates,
            string totalDays,
            string rate,
            string totalPrice,
            string paymentType,
            string amount,
            string paymentMethod,
            string paymentStatus
                               )
        {
            lblDate.Text = date;

            lblCustomerName.Text = customerName;
            lblLicenseNum.Text = licenseNumber;
            lblCustomerNumber.Text = contactNumber;
            lblAddress.Text = address;

            lblVehicle.Text = vehicle;
            lblDates.Text = dates;
            lblTotalDays.Text = totalDays;
            lblRate.Text = rate;
            lblTotalPrice.Text = totalPrice;

            lblPaymentType.Text = paymentType;
            lblAmount.Text = amount;
            lblPaymentMethod.Text = paymentMethod;
            lblPaymentStatus.Text = paymentStatus;
        }

        Bitmap receiptBitmap;

        private void CaptureReceipt()
        {
            receiptBitmap = new Bitmap(panelReceipt.Width, panelReceipt.Height);
            panelReceipt.DrawToBitmap(
                receiptBitmap,
                new Rectangle(0, 0, panelReceipt.Width, panelReceipt.Height)
            );
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = (e.PageBounds.Width - receiptBitmap.Width) / 2;
            int y = 20;

            e.Graphics.DrawImage(receiptBitmap, x, y);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureReceipt();
            printDocument1.Print();
        }
    }
}
