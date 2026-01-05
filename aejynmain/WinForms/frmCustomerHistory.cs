using System;
using System.Data;
using System.Windows.Forms;
using aejynmain.AuthManager;

namespace aejynmain
{
    public partial class frmCustomerHistory : Form
    {
        public frmCustomerHistory()
        {
            InitializeComponent();
        }
        public void LoadCustomerHistory(int customerID)
        {
            DataTable dt = CustomerDetails.GetCustomerHistory(customerID);

            if (dt != null && dt.Rows.Count > 0)
            {
                // Add and populate FullName column
                if (!dt.Columns.Contains("FullName"))
                {
                    dt.Columns.Add("FullName", typeof(string));
                }

                // Add and populate VehicleName column
                if (!dt.Columns.Contains("VehicleName"))
                {
                    dt.Columns.Add("VehicleName", typeof(string));
                }

                // Process each row to set FullName and VehicleName
                foreach (DataRow row in dt.Rows)
                {
                    // Set FullName
                    string firstName = row.Table.Columns.Contains("FirstName") ? row["FirstName"]?.ToString() ?? "" : "";
                    string lastName = row.Table.Columns.Contains("LastName") ? row["LastName"]?.ToString() ?? "" : "";
                    row["FullName"] = $"{firstName} {lastName}".Trim();

                    // Set VehicleName
                    string make = row.Table.Columns.Contains("Make") ? row["Make"]?.ToString() ?? "" : "";
                    string model = row.Table.Columns.Contains("Model") ? row["Model"]?.ToString() ?? "" : "";
                    row["VehicleName"] = $"{make} {model}".Trim();

                    // Set Overdue status (if needed)
                    if (row.Table.Columns.Contains("ReturnDate") && row.Table.Columns.Contains("RentalStatus"))
                    {
                        if (DateTime.TryParse(row["ReturnDate"]?.ToString(), out DateTime returnDate))
                        {
                            string rentalStatus = row["RentalStatus"]?.ToString() ?? "";
                            bool isReturned = rentalStatus.Equals("Returned", StringComparison.OrdinalIgnoreCase);
                            bool isCancelled = rentalStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase);
                            bool isOverdue = (DateTime.Now > returnDate) && !isReturned && !isCancelled;

                            if (row.Table.Columns.Contains("Overdue"))
                            {
                                row["Overdue"] = isOverdue ? "Yes" : "No";
                            }
                        }
                    }
                }

                // Simple de-dup: keep 1 row per RentalID
                DataTable displayTable = dt.Clone(); // This will clone the structure including our new columns

                if (dt.Columns.Contains("RentalID"))
                {
                    var grouped = dt.AsEnumerable()
                                  .GroupBy(r => r.Field<int>("RentalID"))
                                  .Select(g => g.First());

                    foreach (var row in grouped)
                    {
                        displayTable.ImportRow(row);
                    }
                }
                else
                {
                    displayTable = dt.Copy();
                }

                // Set the data source
                dgCustomerHistory.DataSource = displayTable;

                // Reorder columns
                if (dgCustomerHistory.Columns.Contains("RentalID"))
                {
                    int rentalIdIndex = dgCustomerHistory.Columns["RentalID"].DisplayIndex;

                    if (dgCustomerHistory.Columns.Contains("FullName"))
                    {
                        dgCustomerHistory.Columns["FullName"].DisplayIndex = rentalIdIndex + 1;
                    }

                    if (dgCustomerHistory.Columns.Contains("VehicleName"))
                    {
                        dgCustomerHistory.Columns["VehicleName"].DisplayIndex = rentalIdIndex + 2;
                    }
                }

                // Hide the individual columns
                string[] columnsToHide = { "FirstName", "LastName", "Make", "Model" };
                foreach (var columnName in columnsToHide)
                {
                    if (dgCustomerHistory.Columns.Contains(columnName))
                    {
                        dgCustomerHistory.Columns[columnName].Visible = false;
                    }
                }
            }
            else
            {
                dgCustomerHistory.DataSource = null;
            }
        }
    }
}