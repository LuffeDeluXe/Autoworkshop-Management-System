using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoworkshop_Management_System
{
    internal class Car : Vehicle
    {
        public int Doors { get; set; }
        public int Airbags { get; set; }

        public override void GetVechicleData()
        {
            List<Car> ListOfCars = new List<Car>();

            string ConnectionString = "Data Source=localhost;" +
                                      "Initial Catalog=Autoworkshop;" +
                                      "Integrated Security=SSPI;" +
                                      "TrustServerCertificate=true";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Car";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car vehicleFromDB = new Car();
                            vehicleFromDB.VechicleID = Convert.ToInt32(reader["VehicleID"]);
                            vehicleFromDB.Model = reader["Model"].ToString();
                            vehicleFromDB.Brand = reader["Brand"].ToString();
                            vehicleFromDB.Year = Convert.ToInt32(reader["Year"]);
                            vehicleFromDB.LicensePlate = reader["LicensePlate"].ToString();
                            vehicleFromDB.Wheels = Convert.ToInt32(reader["Wheels"]);
                            vehicleFromDB.GearType = reader["GearType"].ToString();
                            vehicleFromDB.Doors = Convert.ToInt32(reader["Doors"]);
                            vehicleFromDB.Airbags = Convert.ToInt32(reader["Airbags"]);

                            Console.WriteLine($"" +
                                $"------------------------------\n" +
                                $"ID: {vehicleFromDB.VechicleID}\n" +
                                $"BRAND: {vehicleFromDB.Brand}\n" +
                                $"MODEL: {vehicleFromDB.Model}\n" +
                                $"YEAR: {vehicleFromDB.Year}\n" +
                                $"LICENSEPLATE: {vehicleFromDB.LicensePlate}\n" +
                                $"WHEELS: {vehicleFromDB.Wheels}\n" +
                                $"GEARTYPE: {vehicleFromDB.GearType}\n" +
                                $"DOORS: {vehicleFromDB.Doors}\n" +
                                $"AIRBAGS: {vehicleFromDB.Airbags}\n" +
                                $"------------------------------\n");
                        }
                    }
                }
            }
        }
    }
}
