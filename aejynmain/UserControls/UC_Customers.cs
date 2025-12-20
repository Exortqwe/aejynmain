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
using MySql.Data.MySqlClient;
namespace aejynmain.UserControls
{
    public partial class UC_Customers : UserControl
    {
        public UC_Customers()
        {
            InitializeComponent();
        }
        public void LoadCustomers()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aejyndb;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("sp_AddCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgAddCustomer.DataSource = dt;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgAddCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewCustomer_Click_1(object sender, EventArgs e)
        {
            
                frmAddCustomer ac = new frmAddCustomer();

                ac.CustomerSaved += () =>
                {
                    LoadCustomers(); // refresh datagridview
                };

                ac.ShowDialog(); // mas maayo kaysa Show()
            
        }
    }
}
