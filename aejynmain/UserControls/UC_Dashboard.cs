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
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
            LoadDashboardData();
        }
        private void LoadDashboardData()
        {
            try
            {
                // MGA PANEL CARDS SA TAAS
                lblTotalVehicles.Text = Dashboard.TotalVehicles().ToString();
                lblAvailableVehicles.Text = Dashboard.AvailableVehicles().ToString();
                lblActiveRentals.Text = Dashboard.ActiveRentals().ToString();
                lblLateReturn.Text = Dashboard.LateReturn().ToString();
                lblRevenueToday.Text = Dashboard.RevenueToday().ToString("₱#,##0.00");
                lblReservation.Text = Dashboard.PendingReservation().ToString();

                // CHARTS

                //REVENUE CHART
                DataTable dtRevenue = Dashboard.RevenueByDate();
                chartRevenue.Series[0].Points.Clear();
                foreach (DataRow row in dtRevenue.Rows)
                {
                    chartRevenue.Series[0].Points.AddXY(Convert.ToDateTime(row["payDate"]).ToString("MMM dd"),
                    Convert.ToDecimal(row["totalRevenue"]));
                }

                // Vehicle Status Pie Chart
                DataTable dtVehicle = Dashboard.VehicleStatus();
                chartVehicleStatus.Series[0].Points.Clear();
                foreach (DataRow row in dtVehicle.Rows)
                {
                    chartVehicleStatus.Series[0].Points.AddXY(
                        row["v_Status"].ToString(),
                        Convert.ToInt32(row["total"]));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chartVehicleStatus_Click(object sender, EventArgs e)
        {

        }
    }
}

