using aejynmain.AuthManager;
using aejynmain.Models;
using aejynmain.WinForms;
using MySql.Data.MySqlClient;
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
    public partial class UC_Maintenance : UserControl
    {
        public UC_Maintenance()
        {
            InitializeComponent();
            SetupMaintenanceGrid();
            LoadMaintenance();
            LoadUser();
        }
        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username;
            lblRole.Text = UserSession.Role;
        }
        private void btnScheduleMaintenance_Click(object sender, EventArgs e)
        {
            frmScheduleMaintenance sm = new frmScheduleMaintenance();
            sm.ShowDialog();
        }
        public void LoadMaintenance()
        {
            dgMaintenance.DataSource = null;  // Reset DataSource to clear out any previous data

            var list = MaintenanceManager.GetScheduledMaintenance();

            dgMaintenance.DataSource = list
                .Where(m => m.MaintenanceStatus == "Scheduled" || m.MaintenanceStatus == "In Progress" || m.MaintenanceStatus == "Ongoing")
                .ToList();
        }

        private void SetupMaintenanceGrid()
        {
            dgMaintenance.AutoGenerateColumns = false;
            dgMaintenance.Columns.Clear();
            dgMaintenance.AllowUserToAddRows = false;
            dgMaintenance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Add hidden MaintenanceID column (important for identifying selected row)
            dgMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MaintenanceID",
                HeaderText = "MaintenanceID",
                DataPropertyName = "MaintenanceID",
                Visible = false
            });

            dgMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "VehicleName",
                HeaderText = "Vehicle Name",
                DataPropertyName = "VehicleName"
            });

            dgMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MaintenanceType",
                HeaderText = "Maintenance Type",
                DataPropertyName = "MaintenanceType"
            });

            dgMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Description",
                HeaderText = "Description",
                DataPropertyName = "Description"
            });

            dgMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Cost",
                HeaderText = "Cost",
                DataPropertyName = "Cost"
            });

            dgMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "StartDate",
                HeaderText = "Start Date",
                DataPropertyName = "StartDate"
            });

            dgMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "EndDate",
                HeaderText = "End Date",
                DataPropertyName = "EndDate"
            });

            dgMaintenance.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MaintenanceStatus",
                HeaderText = "Maintenance Status",
                DataPropertyName = "MaintenanceStatus"
            });

            // Add event handler for formatting dates
            dgMaintenance.CellFormatting += dgMaintenance_CellFormatting;
        }

        // CellFormatting event to format the date
        private void dgMaintenance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column being formatted is either "StartDate" or "EndDate"
            if (dgMaintenance.Columns[e.ColumnIndex].Name == "StartDate" || dgMaintenance.Columns[e.ColumnIndex].Name == "EndDate")
            {
                // Check if the value is not null or DBNull
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    // Convert the value to DateTime and format it as MM/dd/yyyy
                    DateTime dateValue = Convert.ToDateTime(e.Value);
                    e.Value = dateValue.ToString("MM/dd/yyyy");
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower();

            var list = MaintenanceManager.GetScheduledMaintenance()
                .Where(m => (m.MaintenanceStatus == "Scheduled" || m.MaintenanceStatus == "In Progress") &&
                            (m.VehicleName.ToLower().Contains(search) ||
                             m.MaintenanceType.ToLower().Contains(search) ||
                             m.Description.ToLower().Contains(search)))
                .ToList();

            dgMaintenance.DataSource = null;
            dgMaintenance.DataSource = list;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (dgMaintenance.CurrentRow == null) return;

            int maintenanceId = Convert.ToInt32(
                dgMaintenance.CurrentRow.Cells["MaintenanceID"].Value
            );

            MaintenanceManager.StartMaintenance(maintenanceId);

            LoadMaintenance(); // refresh
        }

    }
}
