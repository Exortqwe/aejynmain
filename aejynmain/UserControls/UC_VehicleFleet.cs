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

namespace aejynmain.UserControls
{
    public partial class UC_VehicleFleet : UserControl
    {
        public UC_VehicleFleet()
        {
            InitializeComponent();
            LoadVehicles();
        }
        public void LoadVehicles()
        {
            try
            {
                dgVehicleFleet.DataSource = AuthManager.VehicleFleet.GetVehicle(); // ang sulod sa database ge butang sa datagrid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load vehicles: " + ex.Message); // if mag error mo gawas ni
            }
        }
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            frmAddVehicle av = new frmAddVehicle(this); // mag error if walaon ang this
            av.Show();
        }

        private void dgVehicleFleet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_VehicleFleet_Load(object sender, EventArgs e)
        {

        }
    }
}
