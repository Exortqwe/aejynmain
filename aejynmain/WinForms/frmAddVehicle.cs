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
                    Features = txtFeatures.Text,
                    Status = cmbStatus.Text,
                    image_path = pbCarImage.ImageLocation
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

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png"; 
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the image in the PictureBox
                pbCarImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}