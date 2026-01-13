using MySql.Data.MySqlClient; 
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using aejynmain.AuthManager; 
using aejynmain.Models;      

namespace aejynmain.UserControls
{
    public partial class UC_Customers : UserControl // OOP: Inheritance from UserControl
    {
        private DataTable tblcustomer; // Holds customer data for grid

        public UC_Customers()
        {
            InitializeComponent();   // Initialize UI controls
            LoadCustomers();         // Load all customers (OOP: abstraction)
            LoadUser();              // Load logged-in user info (OOP: abstraction)
        }

        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username; // Show username
            lblRole.Text = UserSession.Role;         // Show user role
        }

        public void LoadCustomers()
        {
            try
            {
                tblcustomer = CustomerDetails.GetCustomers(); // Fetch customer list (SRP: CustomerDetails handles DB)
                dgAddCustomer.DataSource = tblcustomer;      // Bind to DataGridView

                // Format date columns
                if (dgAddCustomer.Columns["LicenseExpiryDate"] != null)
                    dgAddCustomer.Columns["LicenseExpiryDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

                if (dgAddCustomer.Columns["BirthDate"] != null)
                    dgAddCustomer.Columns["BirthDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

                if (dgAddCustomer.Columns["DateRegistered"] != null)
                    dgAddCustomer.Columns["DateRegistered"].DefaultCellStyle.Format = "MM/dd/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer ac = new frmAddCustomer(this); // OOP: Object creation
            ac.ShowDialog();                               // Open add customer form
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers(); // Refresh customer list
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (tblcustomer == null) return;
            string filter = txtSearch.Text.Trim();
            tblcustomer.DefaultView.RowFilter = $"Convert(CustomerID, 'System.String') LIKE '%{filter}%' OR " +
                                               $"FirstName LIKE '%{filter}%' OR LastName LIKE '%{filter}%'";
            // Filter grid dynamically while typing
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tblcustomer == null) return;
            string filter = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(filter))
                tblcustomer.DefaultView.RowFilter = string.Empty; // Clear filter
            else
                tblcustomer.DefaultView.RowFilter = $"Convert(CustomerID, 'System.String') LIKE '%{filter}%' OR " +
                                                    $"FirstName LIKE '%{filter}%' OR LastName LIKE '%{filter}%'";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgAddCustomer.CurrentRow == null) return;

            int CustomerID = Convert.ToInt32(dgAddCustomer.CurrentRow.Cells["CustomerID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool success = CustomerDetails.DeleteCustomer(CustomerID); // Delete customer (SRP: CustomerDetails handles DB)
                if (success)
                {
                    MessageBox.Show("Customer deleted successfully");
                    LoadCustomers(); // Refresh grid
                }
                else
                {
                    MessageBox.Show("Failed to delete customer.");
                }
            }
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            if (dgAddCustomer.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            int customerID = Convert.ToInt32(dgAddCustomer.CurrentRow.Cells["CustomerID"].Value);
            frmCustomerHistory ch = new frmCustomerHistory();
            ch.LoadCustomerHistory(customerID); // Load history for selected customer
            ch.Show();                          // Show history form
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgAddCustomer.ReadOnly = false;                     // Enable editing
            dgAddCustomer.EditMode = DataGridViewEditMode.EditOnEnter;
            if (dgAddCustomer.Columns["CustomerID"] != null)
                dgAddCustomer.Columns["CustomerID"].ReadOnly = true; // Protect ID
            if (dgAddCustomer.Columns["DateRegistered"] != null)
                dgAddCustomer.Columns["DateRegistered"].ReadOnly = true; // Protect registration date
        }

        private void dgAddCustomer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAddCustomer.CurrentRow == null) return;

            try
            {
                int customerID = Convert.ToInt32(dgAddCustomer.CurrentRow.Cells["CustomerID"].Value);
                string columnName = dgAddCustomer.Columns[e.ColumnIndex].Name;

                if (columnName == "CustomerID" || columnName == "DateRegistered") return; // Skip non-editable columns

                object newValue = dgAddCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                bool success = CustomerDetails.UpdateCustomer(customerID, columnName, newValue); // Update DB

                if (!success)
                {
                    MessageBox.Show("Failed to update customer information.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadCustomers(); // Revert changes
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadCustomers(); // Revert changes
            }
        }
    }
}