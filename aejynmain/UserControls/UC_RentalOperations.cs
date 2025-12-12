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
    public partial class UC_RentalOperations : UserControl
    {
        public UC_RentalOperations()
        {
            InitializeComponent();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            UC_NewClient rr = new UC_NewClient();
            rr.Show();
            
        }
    }
}
