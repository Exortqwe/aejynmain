using System;
using System.Data;
using System.Windows.Forms;
using aejynmain.AuthManager;

namespace aejynmain
{
    public partial class frmCustomerHistory : Form
    {
        public frmCustomerHistory()
        {
            InitializeComponent();
        }

        public void LoadCustomerHistory(int customerID)
        {
            // Use static method from CustomerDetails instead of creating an instance
            DataTable dt = CustomerDetails.GetCustomerHistory(customerID);

            if (dt.Rows.Count > 0)
            {
                // Optional: Add FullName column if not exists
                if (!dt.Columns.Contains("FullName"))
                    dt.Columns.Add("FullName", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    row["FullName"] = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                }

                dgCustomerHistory.DataSource = dt;
            }
            else
            {
                dgCustomerHistory.DataSource = null;
            }
        }

        private void dgCustomerHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle cell clicks if needed
        }
    }
}
