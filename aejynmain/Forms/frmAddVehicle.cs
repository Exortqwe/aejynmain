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
using aejynmain.Models;

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
            try
            {
                Vehicle v = new Vehicle
                {
                    CategoryName = cmbCategoryName.Text,
                    Make = txtMake.Text,
                    Model = txtModel.Text,
                    LicensePlate = txtLicensePlate.Text,
                    Mileage = int.Parse(txtMileage.Text),
                    Year = int.Parse(txtYear.Text),
                    VIN = txtVIN.Text,
                    Color = txtColor.Text,
                    Transmission = cmbTransmission.Text,
                    FuelType = cmbFuelType.Text,
                    SeatingCapacity = int.Parse(txtSeatingCapacity.Text),
                    HourlyRate = decimal.Parse(txtHourlyRate.Text),
                    DailyRate = decimal.Parse(txtDailyRate.Text),
                    WeeklyRate = decimal.Parse(txtWeeklyRate.Text),
                    MonthlyRate = decimal.Parse(txtMonthlyRate.Text),
                    Status = cmbStatus.Text
                };

                bool success = VehicleFleet.AddVehicle(v);

                if (success)
                {
                    MessageBox.Show("Vehicle added successfully!");
                    _parent.LoadVehicles();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add vehicle.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input: " + ex.Message);
            }
        }
    }
}