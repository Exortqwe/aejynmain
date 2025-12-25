using aejynmain.AuthManager;
using aejynmain.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aejynmain
{
    public partial class frmAddVehicle : Form
    {
        private UC_VehicleFleet _parent;
        public frmAddVehicle(UC_VehicleFleet parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = VehicleFleet.AddVehicle(
                cmbCategoryName.Text,
                txtMake.Text,
                txtModel.Text,
                txtLicensePlate.Text,
                int.Parse(txtMileage.Text),
                int.Parse(txtYear.Text),
                txtVIN.Text,
                txtColor.Text,
                cmbTransmission.Text,
                cmbFuelType.Text,
                int.Parse(txtSeatingCapacity.Text),
                decimal.Parse(txtDailyRate.Text),
                decimal.Parse(txtWeeklyRate.Text),
                decimal.Parse(txtMonthlyRate.Text),
                cmbStatus.Text
            );

            if (success)
            {
                MessageBox.Show("Vehicle added successfully!");
                // Refresh datagrid by fetching updated inventory
                _parent.LoadVehicles();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add vehicle.");
            }
        }
    }
}
