using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using aejynmain.AuthManager;
using aejynmain.Models;

namespace aejynmain.UserControls
{
    public partial class UC_VehicleFleet : UserControl
    {
        private DataTable tblVehicle;
        public UC_VehicleFleet()
        {
            InitializeComponent();
            LoadVehicles();
        }
        // LOAD DATA
        public void LoadVehicles()
        {
            try
            {
                // Get vehicles as List<Vehicle>
                List<Vehicle> vehicles = VehicleFleet.GetVehicleList();

                // Convert List<Vehicle> to DataTable
                tblVehicle = ConvertToDataTable(vehicles);

                // Set DataSource to DataTable
                dgVehicleFleet.AutoGenerateColumns = true;
                dgVehicleFleet.DataSource = tblVehicle;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load vehicles: " + ex.Message);
            }
        }

        private DataTable ConvertToDataTable(List<Vehicle> vehicles)
        {
            DataTable dt = new DataTable();

            // Add columns
            dt.Columns.Add("VehicleID", typeof(int));
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Columns.Add("Make", typeof(string));
            dt.Columns.Add("Model", typeof(string));
            dt.Columns.Add("LicensePlate", typeof(string));
            dt.Columns.Add("Mileage", typeof(int));
            dt.Columns.Add("Year", typeof(int));
            dt.Columns.Add("VIN", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Transmission", typeof(string));
            dt.Columns.Add("FuelType", typeof(string));
            dt.Columns.Add("SeatingCapacity", typeof(int));
            dt.Columns.Add("HourlyRate", typeof(decimal));
            dt.Columns.Add("DailyRate", typeof(decimal));
            dt.Columns.Add("WeeklyRate", typeof(decimal));
            dt.Columns.Add("MonthlyRate", typeof(decimal));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Features", typeof(string));
            dt.Columns.Add("image_path", typeof(string));

            // Add rows
            foreach (Vehicle vehicle in vehicles)
            {
                dt.Rows.Add(
                    vehicle.VehicleID,
                    vehicle.CategoryName,
                    vehicle.Make,
                    vehicle.Model,
                    vehicle.LicensePlate,
                    vehicle.Mileage,
                    vehicle.Year,
                    vehicle.VIN,
                    vehicle.Color,
                    vehicle.Transmission,
                    vehicle.FuelType,
                    vehicle.SeatingCapacity,
                    vehicle.HourlyRate,
                    vehicle.DailyRate,
                    vehicle.WeeklyRate,
                    vehicle.MonthlyRate,
                    vehicle.Status,
                    vehicle.Features,
                    vehicle.image_path
                );
            }

            return dt;
        }

        // Add Vehicle
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            frmAddVehicle av = new frmAddVehicle(this);
            av.ShowDialog();
        }
        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        private void txtSearchVehicle_TextChanged(object sender, EventArgs e)
        {
            if (tblVehicle == null) return;
            string filter = txtSearchVehicle.Text.Trim();
            if (string.IsNullOrEmpty(filter))
            {
                tblVehicle.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                tblVehicle.DefaultView.RowFilter = 
                    $"Convert(VehicleID, 'System.String') LIKE '%{filter}%' OR " +
                    $"Make LIKE '%{filter}%' OR " +
                    $"Model LIKE '%{filter}%' OR " +
                    $"LicensePlate LIKE '%{filter}%' OR " +
                    $"CategoryName LIKE '%{filter}%' OR " +
                    $"Status LIKE '%{filter}%' OR " +
                    $"Convert(Year, 'System.String') LIKE '%{filter}%'";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tblVehicle == null) return;

            string filter = txtSearchVehicle.Text.Trim();
            if (string.IsNullOrEmpty(filter))
                tblVehicle.DefaultView.RowFilter = string.Empty;
            else
                tblVehicle.DefaultView.RowFilter =
                    $"Convert(VehicleID, 'System.String') LIKE '%{filter}%' OR " +
                    $"Make LIKE '%{filter}%' OR " +
                    $"Model LIKE '%{filter}%' OR " +
                    $"LicensePlate LIKE '%{filter}%' OR " +
                    $"CategoryName LIKE '%{filter}%' OR " +
                    $"Status LIKE '%{filter}%' OR " +
                    $"Convert(Year, 'System.String') LIKE '%{filter}%'";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgVehicleFleet.CurrentRow == null) return;
            int VehicleID = Convert.ToInt32(dgVehicleFleet.CurrentRow.Cells["VehicleID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this vehicle?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool success = VehicleFleet.DeleteVehicle(VehicleID);
                if (success)
                {
                    MessageBox.Show("Vehicle deleted successfully");
                    LoadVehicles();
                }
                else
                {
                    MessageBox.Show("Failed to delete vehicle.");
                }
            }
        }
    }
}
