using System;
using System.Data;
using System.Linq;
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
                // Add FullName column if not exists
                if (!dt.Columns.Contains("Fullname"))
                    dt.Columns.Add("Fullname", typeof(string));

                // Add Vehiclename column if not exists
                if (!dt.Columns.Contains("Vehiclename"))
                    dt.Columns.Add("Vehiclename", typeof(string));

                // Process each row to set FullName, Vehiclename, and Overdue
                foreach (DataRow row in dt.Rows)
                {
                    // FullName
                    string firstName = row.Table.Columns.Contains("FirstName") ? row["FirstName"]?.ToString() ?? "" : "";
                    string lastName = row.Table.Columns.Contains("LastName") ? row["LastName"]?.ToString() ?? "" : "";
                    row["Fullname"] = $"{firstName} {lastName}".Trim();

                    // Vehiclename
                    string make = row.Table.Columns.Contains("Make") ? row["Make"]?.ToString() ?? "" : "";
                    string model = row.Table.Columns.Contains("Model") ? row["Model"]?.ToString() ?? "" : "";
                    row["Vehiclename"] = $"{make} {model}".Trim();

                    // Overdue
                    if (row.Table.Columns.Contains("ReturnDate") && row.Table.Columns.Contains("RentalStatus") && row.Table.Columns.Contains("Overdue"))
                    {
                        if (DateTime.TryParse(row["ReturnDate"]?.ToString(), out DateTime returnDate))
                        {
                            string rentalStatus = row["RentalStatus"]?.ToString() ?? "";
                            bool isReturned = rentalStatus.Equals("Returned", StringComparison.OrdinalIgnoreCase);
                            bool isCancelled = rentalStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase);
                            bool isOverdue = (DateTime.Now > returnDate) && !isReturned && !isCancelled;
                            row["Overdue"] = isOverdue ? "Yes" : "No";
                        }
                    }
                }

                // De-duplicate rows by RentalID
                DataTable displayTable = dt.Clone();
                if (dt.Columns.Contains("RentalID"))
                {
                    var grouped = dt.AsEnumerable()
                                    .GroupBy(r => r.Field<int>("RentalID"))
                                    .Select(g => g.First());
                    foreach (var row in grouped)
                        displayTable.ImportRow(row);
                }
                else
                {
                    displayTable = dt.Copy();
                }

                // Set DataSource
                dgCustomerHistory.DataSource = displayTable;

                // Format date columns
                if (dgCustomerHistory.Columns["PickupDate"] != null)
                    dgCustomerHistory.Columns["PickupDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                if (dgCustomerHistory.Columns["ReturnDate"] != null)
                    dgCustomerHistory.Columns["ReturnDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
                if (dgCustomerHistory.Columns["ActualReturnDate"] != null)
                    dgCustomerHistory.Columns["ActualReturnDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";

                // ------------------- Reorder columns -------------------
                // RentalID first
                if (dgCustomerHistory.Columns.Contains("RentalID"))
                    dgCustomerHistory.Columns["RentalID"].DisplayIndex = 0;

                // FullName second
                if (dgCustomerHistory.Columns.Contains("Fullname"))
                    dgCustomerHistory.Columns["Fullname"].DisplayIndex = 1;

                // Vehiclename third
                if (dgCustomerHistory.Columns.Contains("Vehiclename"))
                    dgCustomerHistory.Columns["Vehiclename"].DisplayIndex = 2;

                // ------------------- Hide raw columns -------------------
                string[] columnsToHide = { "FirstName", "LastName", "Make", "Model" };
                foreach (var columnName in columnsToHide)
                {
                    if (dgCustomerHistory.Columns.Contains(columnName))
                        dgCustomerHistory.Columns[columnName].Visible = false;
                }
            }
            else
            {
                dgCustomerHistory.DataSource = null;
            }
        }
    }
}

