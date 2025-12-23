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

namespace aejynmain.UserControls
{
    public partial class UC_RentalOperations : UserControl
    {
        public UC_RentalOperations()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = AddCustomer.GetCustomers();
            string search = txtSearch.Text;
            foreach (DataRow dr in dt.Rows)
            {
                if ((dr["FirstName"] + " " + dr["LastName"]).Contains(search) || dr["LicenseNumber"].ToString().Contains(search))
                {
                    lblFullName.Text = dr["FirstName"] + " " + dr["LastName"];
                    lblLicenseNumber.Text = dr["LicenseNumber"].ToString();
                    lblContactNumber.Text = dr["ContactNumber"].ToString();
                    lblAddress.Text = dr["Address"].ToString();
                    return;
                }
            }
            lblFullName.Text = "Not Found";
            lblLicenseNumber.Text = "";
            lblContactNumber.Text = "";
            lblAddress.Text = "";
        }
    }
}
