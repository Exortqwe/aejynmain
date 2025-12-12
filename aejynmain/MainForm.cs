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

namespace aejynmain
{
    public partial class MainForm : Form
    {
        UC_Dashboard dash = new UC_Dashboard();
        UC_RentalOperations rv = new UC_RentalOperations();
        public MainForm()
        {
            InitializeComponent();
            addUserControls(dash);
        }

        private void addUserControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard dash = new UC_Dashboard();
            addUserControls(dash);
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            UC_RentalOperations rv = new UC_RentalOperations();
            addUserControls(rv);
        }

    }
}
