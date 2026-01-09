using aejynmain.AuthManager;
using aejynmain.Models;
using aejynmain.WinForms;
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
    public partial class UC_UserManagement : UserControl
    {
        private List<UserModel> allUsers = new List<UserModel>();
        public UC_UserManagement()
        {
            InitializeComponent();
        }

        public void LoadUsers()
        {
            allUsers = UserManagementManager.GetAllUsers();
            dgUserManagement.AutoGenerateColumns = true;
            dgUserManagement.DataSource = new BindingList<UserModel>(allUsers);

            if (dgUserManagement.Columns["UserID"] != null)
                dgUserManagement.Columns["UserID"].ReadOnly = true;
            if (dgUserManagement.Columns["DateCreated"] != null)
                dgUserManagement.Columns["DateCreated"].ReadOnly = true;
            if (dgUserManagement.Columns["Password"] != null)
                dgUserManagement.Columns["Password"].Visible = false;
        }

        private void UC_UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
            UpdateUserCards();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim().ToLower();

            var filtered = allUsers
                .Where(user => user.UserID.ToString().Contains(filter)
                         || user.FirstName.ToLower().Contains(filter)
                         || user.LastName.ToLower().Contains(filter)
                         || user.Username.ToLower().Contains(filter)
                         || user.EmailAddress.ToLower().Contains(filter)
                         || user.Role.ToLower().Contains(filter))
                .ToList();

            dgUserManagement.DataSource = new BindingList<UserModel>(filtered);
        }
        private void btnSearchUserManagement_Click(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.Trim().ToLower();

            List<UserModel> filtered;

            if (string.IsNullOrEmpty(filter))
            {
                filtered = allUsers;
            }
            else
            {
                filtered = allUsers
                    .Where(user => user.UserID.ToString().Contains(filter)
                             || user.FirstName.ToLower().Contains(filter)
                             || user.LastName.ToLower().Contains(filter)
                             || user.Username.ToLower().Contains(filter)
                             || user.EmailAddress.ToLower().Contains(filter)
                             || user.Role.ToLower().Contains(filter))
                    .ToList();
            }

            // rebind the filtered list to the DataGridView
            dgUserManagement.DataSource = new BindingList<UserModel>(filtered);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmUserManagement uma = new frmUserManagement(this);
            uma.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgUserManagement.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int selectedUserId = Convert.ToInt32(dgUserManagement.CurrentRow.Cells["UserID"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    UserManagementManager.DeleteUser(selectedUserId);
                    MessageBox.Show("User deleted successfully.");
                    LoadUsers();  // Refresh your DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete user: " + ex.Message);
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgUserManagement.CurrentRow == null)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }
            int selectedUserId = Convert.ToInt32(dgUserManagement.CurrentRow.Cells["UserID"].Value);

            LoadUsers();
        }
        private void dgUserManagement_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgUserManagement.CurrentRow == null) return;

            try
            {
                int userId = Convert.ToInt32(
                    dgUserManagement.CurrentRow.Cells["UserID"].Value
                );

                string columnName = dgUserManagement.Columns[e.ColumnIndex].Name;

                // Protect non-editable columns
                if (columnName == "UserID" || columnName == "DateCreated")
                    return;

                object newValue = dgUserManagement.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Get the full user model from the current row
                UserModel updatedUser = new UserModel
                {
                    UserID = userId,
                    FirstName = dgUserManagement.CurrentRow.Cells["FirstName"].Value.ToString(),
                    LastName = dgUserManagement.CurrentRow.Cells["LastName"].Value.ToString(),
                    Username = dgUserManagement.CurrentRow.Cells["Username"].Value.ToString(),
                    Gender = dgUserManagement.CurrentRow.Cells["Gender"].Value.ToString(),
                    BirthDate = string.IsNullOrEmpty(dgUserManagement.CurrentRow.Cells["BirthDate"].Value?.ToString())
                        ? null
                        : Convert.ToDateTime(dgUserManagement.CurrentRow.Cells["BirthDate"].Value),
                    ContactNumber = dgUserManagement.CurrentRow.Cells["ContactNumber"].Value.ToString(),
                    EmailAddress = dgUserManagement.CurrentRow.Cells["EmailAddress"].Value.ToString(),
                    Address = dgUserManagement.CurrentRow.Cells["Address"].Value.ToString(),
                    Role = dgUserManagement.CurrentRow.Cells["Role"].Value.ToString(),
                    Status = dgUserManagement.CurrentRow.Cells["Status"].Value.ToString(),
                    DateCreated = Convert.ToDateTime(dgUserManagement.CurrentRow.Cells["DateCreated"].Value)
                };

                // Call the manager to update the user in the database
                UserManagementManager.UpdateUser(updatedUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating user:\n" + ex.Message,
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                LoadUsers(); // revert changes if update fails
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void UpdateUserCards()
        {
            lblTotalUsers.Text = allUsers.Count.ToString();

            lblActiveUsers.Text = allUsers
                .Count(user => user.Status == "Active")
                .ToString();

            lblInactiveUsers.Text = allUsers
                .Count(user => user.Status == "Inactive")
                .ToString();

            lblSuspendedUsers.Text = allUsers
                .Count(user => user.Status == "Suspended")
                .ToString();
        }
    }

}