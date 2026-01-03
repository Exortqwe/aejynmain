using aejynmain.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace aejynmain.HelperMethod
{
    internal class DataTableHelper
    {
        public static DataTable VehicleListToDataTable(List<Vehicle> vehicles)
        {
            DataTable dt = new DataTable();

            // ======= DEFINE COLUMNS =======
            dt.Columns.Add("VehicleID", typeof(int));
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Columns.Add("Make", typeof(string));
            dt.Columns.Add("Model", typeof(string));
            dt.Columns.Add("LicensePlate", typeof(string));
            dt.Columns.Add("Mileage", typeof(int));
            dt.Columns.Add("VehicleYear", typeof(int));
            dt.Columns.Add("VIN", typeof(string));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Transmission", typeof(string));
            dt.Columns.Add("FuelType", typeof(string));
            dt.Columns.Add("InitialCondition", typeof(string)); // spelling fixed
            dt.Columns.Add("SeatingCapacity", typeof(int));
            dt.Columns.Add("FuelLevel", typeof(string));
            dt.Columns.Add("HourlyRate", typeof(decimal));
            dt.Columns.Add("DailyRate", typeof(decimal));
            dt.Columns.Add("WeeklyRate", typeof(decimal));
            dt.Columns.Add("MonthlyRate", typeof(decimal));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Features", typeof(string));
            dt.Columns.Add("image_path", typeof(string));

            // ======= ADD ROWS =======
            foreach (Vehicle v in vehicles)
            {
                dt.Rows.Add(
                    v.VehicleID,
                    v.CategoryName,
                    v.Make,
                    v.Model,
                    v.LicensePlate,
                    v.Mileage,
                    v.Year,
                    v.VIN,
                    v.Color,
                    v.Transmission,
                    v.FuelType,
                    v.InitialCondition,   // matches column
                    v.SeatingCapacity,    // matches column
                    v.FuelLevel,          // matches column
                    v.HourlyRate,
                    v.DailyRate,
                    v.WeeklyRate,
                    v.MonthlyRate,
                    v.Status,
                    v.Features,
                    v.image_path
                );
            }

            return dt;
        }
    }
}
