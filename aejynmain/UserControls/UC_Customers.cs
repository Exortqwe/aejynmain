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
                dgAddCustomer.DataSource = AuthManager.AddCustomer.GetCustomers(); // ang sulod sa database ge butang sa datagrid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load customers: " + ex.Message); // if mag error mo gawas ni
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer ac = new frmAddCustomer(this); //mag pop-up ang form add customer
            ac.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomers(); // e refresh ang form
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (tblcustomer == null) return;
            string filter = txtSearch.Text.Trim();
            tblcustomer.DefaultView.RowFilter = $"Convert(CustomerID, 'System.String') LIKE '%{filter}%' OR " +
                $"FirstName LIKE '%{filter}%' OR" +
                $"LastName LIKE '%{filter}%'"; // apply rowfilter para lang sa ID, Fname, Lname
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Make sure tblcustomer is loaded
            if (tblcustomer == null) return;

            // Get the value typed in txtSearch
            string filter = txtSearch.Text.Trim();

            // If textbox is empty, show all customers
            if (string.IsNullOrEmpty(filter))
            {
                tblcustomer.DefaultView.RowFilter = string.Empty; // remove filter
            }
            else
            {
                // Apply filter for CustomerID, FirstName, LastName
                tblcustomer.DefaultView.RowFilter =
                    $"Convert(CustomerID, 'System.String') LIKE '%{filter}%' OR " +
                    $"FirstName LIKE '%{filter}%' OR LastName LIKE '%{filter}%'";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgAddCustomer.CurrentRow == null) return;
            int CustomerID = Convert.ToInt32(dgAddCustomer.CurrentRow.Cells["CustomerID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool success = AuthManager.AddCustomer.DeleteCustomer(CustomerID);
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

        private void dgAddCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}