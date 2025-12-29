using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using aejynmain.AuthManager;
using aejynmain.Models;

namespace aejynmain.UserControls
{
    public partial class UC_Customers : UserControl
    {
        private DataTable tblcustomer;
        public UC_Customers()
        {
            InitializeComponent();
            LoadCustomers();
        }

        public void LoadCustomers()
        {
            try
            {
                // Get customers as List<Customer>
                List<Customer> customers = CustomerDetails.GetCustomers();
                
                // Convert List<Customer> to DataTable
                tblcustomer = ConvertToDataTable(customers);
                
                // Set DataSource to DataTable
                dgAddCustomer.DataSource = tblcustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load customers: " + ex.Message);
            }
        }

        private DataTable ConvertToDataTable(List<Customer> customers)
        {
            DataTable dt = new DataTable();
            
            // Add columns
            dt.Columns.Add("CustomerID", typeof(int));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Contact Number", typeof(string));
            dt.Columns.Add("Email Address", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("License Number", typeof(string));
            dt.Columns.Add("License Expiry Date", typeof(DateTime));
            dt.Columns.Add("Birth Date", typeof(DateTime));
            dt.Columns.Add("Date Registered", typeof(DateTime));
            
            // Add rows
            foreach (Customer customer in customers)
            {
                dt.Rows.Add(
                    customer.CustomerID,
                    customer.FirstName,
                    customer.LastName,
                    customer.ContactNumber,
                    customer.EmailAddress,
                    customer.Address,
                    customer.Gender,
                    customer.LicenseNumber,
                    customer.LicenseExpiryDate,
                    customer.BirthDate,
                    customer.DateRegistered
                );
            }
            
            return dt;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer ac = new frmAddCustomer(this);
            ac.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (tblcustomer == null) return;
            string filter = txtSearch.Text.Trim();
            tblcustomer.DefaultView.RowFilter = $"Convert(CustomerID, 'System.String') LIKE '%{filter}%' OR " +
                                               $"FirstName LIKE '%{filter}%' OR " +
                                               $"LastName LIKE '%{filter}%'";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tblcustomer == null) return;

            string filter = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(filter))
                tblcustomer.DefaultView.RowFilter = string.Empty;
            else
                tblcustomer.DefaultView.RowFilter =
                    $"Convert(CustomerID, 'System.String') LIKE '%{filter}%' OR " +
                    $"FirstName LIKE '%{filter}%' OR LastName LIKE '%{filter}%'";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgAddCustomer.CurrentRow == null) return;
            int CustomerID = Convert.ToInt32(dgAddCustomer.CurrentRow.Cells["CustomerID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool success = CustomerDetails.DeleteCustomer(CustomerID);
                if (success)
                {
                    MessageBox.Show("Customer deleted successfully");
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Failed to delete customer.");
                }
            }
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerHistory ch = new frmCustomerHistory();
            ch.Show();
        }
    }
}