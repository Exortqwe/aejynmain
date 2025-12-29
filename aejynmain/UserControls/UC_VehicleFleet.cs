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
                dgVehicleFleet.AutoGenerateColumns = true;
                dgVehicleFleet.DataSource = VehicleFleet.GetVehicleList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load vehicles: " + ex.Message);
            }
        }

        // ADD VEHICLE
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            frmAddVehicle av = new frmAddVehicle(this);
            av.ShowDialog(); // mas maayo modal
        }

        // REFRESH BUTTON
        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadVehicles();
        }

        // OPTIONAL: double click to edit
    }
}
