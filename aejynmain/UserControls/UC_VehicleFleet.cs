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

                // Format rate columns with currency
                if (dgVehicleFleet.Columns["DailyRate"] != null)
                    dgVehicleFleet.Columns["DailyRate"].DefaultCellStyle.Format = "₱#,##0.00";
                if (dgVehicleFleet.Columns["WeeklyRate"] != null)
                    dgVehicleFleet.Columns["WeeklyRate"].DefaultCellStyle.Format = "₱#,##0.00";
                if (dgVehicleFleet.Columns["MonthlyRate"] != null)
                    dgVehicleFleet.Columns["MonthlyRate"].DefaultCellStyle.Format = "₱#,##0.00";
                if (dgVehicleFleet.Columns["HourlyRate"] != null)
                    dgVehicleFleet.Columns["HourlyRate"].DefaultCellStyle.Format = "₱#,##0.00";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Enable editing in DataGridView
            dgVehicleFleet.ReadOnly = false;
            dgVehicleFleet.EditMode = DataGridViewEditMode.EditOnEnter;

            // Make VehicleID read-only (should not be edited)
            if (dgVehicleFleet.Columns["VehicleID"] != null)
                dgVehicleFleet.Columns["VehicleID"].ReadOnly = true;
        }

        private void dgVehicleFleet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVehicleFleet.CurrentRow == null) return;

            try
            {
                int vehicleID = Convert.ToInt32(
                    dgVehicleFleet.CurrentRow.Cells["VehicleID"].Value
                );

                string columnName = dgVehicleFleet.Columns[e.ColumnIndex].Name;

                // Protect VehicleID
                if (columnName == "VehicleID")
                    return;

                object newValue = dgVehicleFleet.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex].Value;

                // Column mapping 
                string dbColumnName = columnName;
                if (columnName == "Year")
                    dbColumnName = "VehicleYear";
                else if (columnName == "Status")
                    dbColumnName = "VehicleStatus";

                bool success = VehicleFleet.UpdateVehicle(
                    vehicleID,
                    dbColumnName,
                    newValue
                );

                if (!success)
                {
                    MessageBox.Show(
                        "Failed to update vehicle information.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    LoadVehicles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating vehicle:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                LoadVehicles();
            }
        }

        private void dgVehicleFleet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
