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

namespace aejynmain
{
    public partial class frmCustomerHistory : Form
    {
        public frmCustomerHistory()
        {
            InitializeComponent();
        }
        private void LoadCustomerHistory(int CustomerID)
        {
            AddCustomer customerInfo = new AddCustomer();
            DataTable dt = customerInfo.GetCustomerHistory(CustomerID);

            if (dt.Rows.Count > 0)
            {
                // Optional: Add FullName column
                if (!dt.Columns.Contains("FullName"))
                    dt.Columns.Add("FullName", typeof(string));

                foreach (DataRow row in dt.Rows)
                    row["FullName"] = row["FirstName"].ToString() + " " + row["LastName"].ToString();

                dgCustomerHistory.DataSource = dt;
            }
        }

        private void dgCustomerHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
