using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using aejynmain.AuthManager;
using aejynmain.Models;
using aejynmain.HelperMethod;

namespace aejynmain.UserControls
{
    public partial class UC_VehicleFleet : UserControl
    {
        private DataTable tblVehicle;

        public UC_VehicleFleet()
        {
            InitializeComponent();
            LoadVehicles();
            LoadUser();
        }
        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username;
            lblRole.Text = UserSession.Role;
        }

        // ================= LOAD VEHICLES =================
        public void LoadVehicles()
        { 
            try
            {
                // Get data
                List<Vehicle> vehicles = VehicleFleet.GetVehicleList();

                // Convert using helper
                tblVehicle = DataTableHelper.VehicleListToDataTable(vehicles);

                // Bind to existing DataGridView
                dgVehicleFleet.AutoGenerateColumns = true;
                dgVehicleFleet.DataSource = tblVehicle;

                // Format currency columns
                if (dgVehicleFleet.Columns["HourlyRate"] != null)
                    dgVehicleFleet.Columns["HourlyRate"].DefaultCellStyle.Format = "₱#,##0.00";
                if (dgVehicleFleet.Columns["DailyRate"] != null)
                    dgVehicleFleet.Columns["DailyRate"].DefaultCellStyle.Format = "₱#,##0.00";
                if (dgVehicleFleet.Columns["WeeklyRate"] != null)
                    dgVehicleFleet.Columns["WeeklyRate"].DefaultCellStyle.Format = "₱#,##0.00";
                if (dgVehicleFleet.Columns["MonthlyRate"] != null)
                    dgVehicleFleet.Columns["MonthlyRate"].DefaultCellStyle.Format = "₱#,##0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load vehicles: " + ex.Message);
            }
        }

        // ================= SEARCH =================
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
                   
                    $"Convert(VehicleYear, 'System.String') LIKE '%{filter}%'";
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tblVehicle == null) return; string filter = txtSearchVehicle.Text.Trim();
            if (string.IsNullOrEmpty(filter)) tblVehicle.DefaultView.RowFilter = string.Empty;
            else tblVehicle.DefaultView.RowFilter = $"Convert(VehicleID, 'System.String') LIKE '%{filter}%' OR "
            + $"Make LIKE '%{filter}%' OR " + $"Model LIKE '%{filter}%' OR "
            + $"LicensePlate LIKE '%{filter}%' OR " + $"CategoryName LIKE '%{filter}%' OR "
            + $"Status LIKE '%{filter}%' OR "
            + $"Convert(Year, 'System.String') LIKE '%{filter}%'";
        }

        // ================= ADD =================
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            frmAddVehicle av = new frmAddVehicle(this);
            av.ShowDialog();
        }

        // ================= REFRESH =================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgVehicleFleet.CurrentRow == null) return;

            int vehicleID = Convert.ToInt32(
                dgVehicleFleet.CurrentRow.Cells["VehicleID"].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this vehicle?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (VehicleFleet.DeleteVehicle(vehicleID))
                {
                    MessageBox.Show("Vehicle deleted successfully.");
                    LoadVehicles();
                }
                else
                {
                    MessageBox.Show("Failed to delete vehicle.");
                }
            }
        }

        // ================= ENABLE EDIT =================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            dgVehicleFleet.ReadOnly = false;
            dgVehicleFleet.EditMode = DataGridViewEditMode.EditOnEnter;

            if (dgVehicleFleet.Columns["VehicleID"] != null)
                dgVehicleFleet.Columns["VehicleID"].ReadOnly = true;
        }

        // ================= SAVE EDIT =================
        private void dgVehicleFleet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgVehicleFleet.CurrentRow == null) return;

            try
            {
                int vehicleID = Convert.ToInt32(
                    dgVehicleFleet.CurrentRow.Cells["VehicleID"].Value
                );

                string columnName = dgVehicleFleet.Columns[e.ColumnIndex].Name;

                if (columnName == "VehicleID")
                    return;

                object newValue = dgVehicleFleet.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex].Value;


                // Column mapping (minimal)
                string dbColumnName = columnName;

                if (columnName == "Status")
                    dbColumnName = "VehicleStatus";

                bool success = VehicleFleet.UpdateVehicle(
                    vehicleID,
                    dbColumnName,
                    newValue
                );

                if (!success)
                {
                    MessageBox.Show("Failed to update vehicle.");
                    LoadVehicles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating vehicle:\n" + ex.Message);
                LoadVehicles();
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        private void dgVehicleFleet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}