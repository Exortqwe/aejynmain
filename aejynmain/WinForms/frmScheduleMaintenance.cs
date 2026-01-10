using aejynmain.AuthManager;
using aejynmain.UserControls;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace aejynmain.WinForms
{
    public partial class frmScheduleMaintenance : Form
    {
        // -----------------------------
        // PROPERTY TO HOLD REFERENCE TO UC_MAINTENANCE
        // -----------------------------
        public UC_Maintenance MaintenanceUC { get; set; }

        public frmScheduleMaintenance()
        {
            InitializeComponent();
        }

        private void frmScheduleMaintenance_Load(object sender, EventArgs e)
        {
            SetupVehicleGrid();
            LoadVehicles();
        }

        // ==========================
        // SETUP DATAGRIDVIEW
        // ==========================
        private void SetupVehicleGrid()
        {
            dgVehicleFleets.AutoGenerateColumns = false;
            dgVehicleFleets.Columns.Clear();
            dgVehicleFleets.AllowUserToAddRows = false;
            dgVehicleFleets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgVehicleFleets.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "Select",
                HeaderText = "Select",
                Width = 60
            });
            dgVehicleFleets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "VehicleID",
                DataPropertyName = "VehicleID",
                Visible = false
            });

            dgVehicleFleets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Make",
                HeaderText = "Make",
                DataPropertyName = "Make"
            });

            dgVehicleFleets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Model",
                HeaderText = "Model",
                DataPropertyName = "Model"
            });

            dgVehicleFleets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Year",
                HeaderText = "Year",
                DataPropertyName = "VehicleYear" // match sa model
            });

            dgVehicleFleets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "CategoryName",
                HeaderText = "Category",
                DataPropertyName = "CategoryName"
            });

            dgVehicleFleets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "LicensePlate",
                HeaderText = "License Plate",
                DataPropertyName = "LicensePlate"
            });

            dgVehicleFleets.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "VehicleStatus" // match sa model
            });
        }

        // ==========================
        // LOAD VEHICLES
        // ==========================
        private void LoadVehicles()
        {
            var vehicles = MaintenanceManager.GetVehicles();
            dgVehicleFleets.DataSource = vehicles
                .Where(v => v.VehicleStatus == "Available")
                .ToList();
        }

        // ==========================
        // GET SELECTED VEHICLE
        // ==========================
        private int GetSelectedVehicleID()
        {
            foreach (DataGridViewRow row in dgVehicleFleets.Rows)
            {
                var selectCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (selectCell != null &&
                    selectCell.Value != null &&
                    Convert.ToBoolean(selectCell.Value))
                {
                    return Convert.ToInt32(row.Cells["VehicleID"].Value);
                }
            }
            return 0;
        }

        // ==========================
        // CONFIRM BUTTON
        // ==========================
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int vehicleID = GetSelectedVehicleID();

            if (vehicleID == 0)
            {
                MessageBox.Show("Please select an AVAILABLE vehicle.", "Warning");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbMaintenanceType.Text))
            {
                MessageBox.Show("Please select maintenance type.");
                return;
            }

            if (!decimal.TryParse(txtCost.Text, out decimal cost))
            {
                MessageBox.Show("Invalid cost value.");
                return;
            }

            string errorMessage;
            bool success = MaintenanceManager.ScheduleMaintenance(
                vehicleID,
                cmbMaintenanceType.Text,
                txtMaintenanceDescription.Text,
                cost,
                dtpStartDate.Value,
                dtpEndDate.Value,
                out errorMessage
            );

            if (success)
            {
                MessageBox.Show("Maintenance scheduled successfully!", "Success");

                // Reload vehicles grid
                LoadVehicles();

                // Clear input fields
                ClearFields();

                // Update the UC_Maintenance datagrid
                MaintenanceUC?.LoadMaintenance();
            }
            else
            {
                MessageBox.Show("Error scheduling maintenance:\n" + errorMessage, "Error");
            }
        }

        // ==========================
        // CLEAR INPUTS
        // ==========================
        private void ClearFields()
        {
            cmbMaintenanceType.SelectedIndex = -1;
            txtMaintenanceDescription.Clear();
            txtCost.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }
    }
}