using aejynmain.AuthManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static aejynmain.AuthManager.RentalOperations;

namespace aejynmain.UserControls
{
    public partial class UC_RentalOperations : UserControl
    {
        private decimal dailyRate;
        private decimal weeklyRate;
        private decimal monthlyRate;
        public UC_RentalOperations()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var customer = CustomerService.SearchCustomer(txtSearch.Text);

            if (customer != null)
            {
                lblFullName.Text = customer.FullName;
                lblLicenseNumber.Text = customer.LicenseNumber;
                lblContactNumber.Text = customer.ContactNumber;
                lblAddress.Text = customer.Address;
            }
            else
            {
                lblFullName.Text = "";
                lblLicenseNumber.Text = "";
                lblContactNumber.Text = "";
                lblAddress.Text = "";
                MessageBox.Show("Customer not found");
            }
        }
    }
}