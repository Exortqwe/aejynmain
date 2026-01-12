using aejynmain.Models;
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
    public partial class UC_Billing : UserControl
    {
        public UC_Billing()
        {
            InitializeComponent();
            LoadUser();
        }
        private void LoadUser()
        {
            lblUsername.Text = UserSession.Username;
            lblRole.Text = UserSession.Role;
        }
    }
}
