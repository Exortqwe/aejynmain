using aejynmain.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aejynmain.AuthManager;
using aejynmain.Models;

namespace aejynmain
{
    public partial class frmAddCustomer : Form
    {
        private UC_Customers _parent;
        public frmAddCustomer(UC_Customers parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        private void btnSaveCustomerDetails_Click(object sender, EventArgs e)
        {
            bool success = CustomerDetails.AddCustomer(
             txtFirstName.Text,
             txtLastName.Text,
             txtContactNum.Text,
             txtEmailAddress.Text,
             txtAddress.Text,
             cmbGender.Text,
             txtLicenseNumber.Text,
             dtpLicenseExpiry.Value,
             dtpBirthDate.Value,
             dtpDateRegistered.Value
 );

            if (success)
            {
                MessageBox.Show("Customer added successfully!");
                _parent.LoadCustomers();   // refresh datagrid
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add customer.");
            }
        }
    }
}