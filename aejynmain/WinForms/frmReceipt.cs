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
    }
}
