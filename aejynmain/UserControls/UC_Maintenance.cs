using aejynmain.AuthManager;
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
            dgMaintenance.DataSource = null;
            var list = MaintenanceManager.GetScheduledMaintenance();
            dgMaintenance.DataSource = list
                .Where(m => m.MaintenanceStatus == "Scheduled" || m.MaintenanceStatus == "In Progress")
                .ToList();
        }
        private void SetupMaintenanceGrid()
        {
            dgMaintenance.AutoGenerateColumns = false;
            dgMaintenance.Columns.Clear();
            dgMaintenance.AllowUserToAddRows = false;
            dgMaintenance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
    }
}
