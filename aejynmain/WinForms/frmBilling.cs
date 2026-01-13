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
    public partial class frmBilling : Form
    {
        public frmBilling()
        {
            InitializeComponent();
        }

        public void LoadBillingData(
    string customerName,
    string rentalId,
    decimal rentalCharges,
    decimal additionalCharges,
    decimal cleaningFee,
    decimal subTotal,
    decimal depositPaid,
    decimal balanceDue,
    decimal refund,
    string paymentMethod
)
        {
            lblCustomerName.Text = customerName;
            lblRentalID.Text = rentalId;

            lblRentalCharges.Text = rentalCharges.ToString("₱#,##0.00");
            lblAdditionalCharges.Text = additionalCharges.ToString("₱#,##0.00");
            lblCleaningFees.Text = cleaningFee.ToString("₱#,##0.00");
            lblSubTotal.Text = subTotal.ToString("₱#,##0.00");
            lblDepositPaid.Text = depositPaid.ToString("₱#,##0.00");
            lblBalanceDue.Text = balanceDue.ToString("₱#,##0.00");
            lblRefund.Text = refund.ToString("₱#,##0.00");
            lblPaymentMethod.Text = paymentMethod;
        }
        Bitmap billingBitmap;
        private void CaptureBilling()
        {
            billingBitmap = new Bitmap(panelBilling.Width, panelBilling.Height);
            panelBilling.DrawToBitmap(
                billingBitmap,
                new Rectangle(0, 0, panelBilling.Width, panelBilling.Height)
            );
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureBilling();
            printDocumentBilling.Print();
        }

        private void printDocumentBilling_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = (e.PageBounds.Width - billingBitmap.Width) / 2;
            int y = 20;

            e.Graphics.DrawImage(billingBitmap, x, y);
        }
    }
}
