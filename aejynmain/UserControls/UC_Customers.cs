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
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("ContactNumber", typeof(string));
            dt.Columns.Add("EmailAddress", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("LicenseNumber", typeof(string));
            dt.Columns.Add("LicenseExpiryDate", typeof(DateTime));
            dt.Columns.Add("BirthDate", typeof(DateTime));
            dt.Columns.Add("DateRegistered", typeof(DateTime));

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
            if (dgAddCustomer.CurrentRow == null)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            // Get the selected customer ID from the DataGridView
            int customerID = Convert.ToInt32(dgAddCustomer.CurrentRow.Cells["CustomerID"].Value);

            // Open the frmCustomerHistory form and pass the customer ID
            frmCustomerHistory ch = new frmCustomerHistory();
            ch.LoadCustomerHistory(customerID); // Call the method to load customer history with the customer ID
            ch.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgAddCustomer.ReadOnly = false;
            dgAddCustomer.EditMode = DataGridViewEditMode.EditOnEnter;
            if (dgAddCustomer.Columns["CustomerID"] != null)
                dgAddCustomer.Columns["CustomerID"].ReadOnly = true;
            if (dgAddCustomer.Columns["DateRegistered"] != null)
                dgAddCustomer.Columns["DateRegistered"].ReadOnly = true;

        }

        private void dgAddCustomer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAddCustomer.CurrentRow == null) return;

            try
            {
                int customerID = Convert.ToInt32(
                    dgAddCustomer.CurrentRow.Cells["CustomerID"].Value
                );

                string columnName = dgAddCustomer.Columns[e.ColumnIndex].Name;

                // Protect non-editable columns
                if (columnName == "CustomerID" || columnName == "DateRegistered")
                    return;

                object newValue = dgAddCustomer.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex].Value;

                bool success = CustomerDetails.UpdateCustomer(
                    customerID,
                    columnName,
                    newValue
                );

                if (!success)
                {
                    MessageBox.Show(
                        "Failed to update customer information.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    LoadCustomers(); // revert changes
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating customer:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                LoadCustomers(); // revert changes
            }
        }
    }
}