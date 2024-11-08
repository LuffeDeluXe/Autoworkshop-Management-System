using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoworkshop_Management_System
{
    internal class Motorcycle : Vehicle
    {
        public string Handles { get; set; }

        public override void GetVechicleData()
        {
            List<Motorcycle> ListOfCars = new List<Motorcycle>();

            string ConnectionString = "Data Source=localhost;" +
                                      "Initial Catalog=Autoworkshop;" +
                                      "Integrated Security=SSPI;" +
                                      "TrustServerCertificate=true";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "select * from Motorcycle\njoin Vehicle on Motorcycle.VechicleID = Vehicle.VehicleID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Motorcycle vehicleFromDB = new Motorcycle();
                            vehicleFromDB.VehicleID = Convert.ToInt32(reader["VehicleID"]);
                            vehicleFromDB.Model = reader["Model"].ToString();
                            vehicleFromDB.Brand = reader["Brand"].ToString();
                            vehicleFromDB.Year = Convert.ToInt32(reader["Year"]);
                            vehicleFromDB.LicensePlate = reader["LicensePlate"].ToString();
                            vehicleFromDB.Wheels = reader["Wheels"].ToString();
                            vehicleFromDB.GearType = reader["GearType"].ToString();
                            vehicleFromDB.Handles = reader["Handles"].ToString();

                            Console.WriteLine($"" +
                                $"------------------------------\n" +
                                $"ID: {vehicleFromDB.VehicleID}\n" +
                                $"BRAND: {vehicleFromDB.Brand}\n" +
                                $"MODEL: {vehicleFromDB.Model}\n" +
                                $"YEAR: {vehicleFromDB.Year}\n" +
                                $"LICENSEPLATE: {vehicleFromDB.LicensePlate}\n" +
                                $"WHEELS: {vehicleFromDB.Wheels}\n" +
                                $"GEARTYPE: {vehicleFromDB.GearType}\n" +
                                $"HANDLES: {vehicleFromDB.Handles}\n" +
                                $"------------------------------\n");
                        }
                    }
                }
            }
        }
    }
    
}
