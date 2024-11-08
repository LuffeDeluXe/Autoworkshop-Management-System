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
        public string Airbags { get; set; }

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

                string query = "select * from PrivateCar\njoin Vehicle on PrivateCar.VehicleID = Vehicle.VehicleID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car vehicleFromDB = new Car();
                            vehicleFromDB.VehicleID = Convert.ToInt32(reader["VehicleID"]);
                            vehicleFromDB.Model = reader["Model"].ToString();
                            vehicleFromDB.Brand = reader["Brand"].ToString();
                            vehicleFromDB.Year = Convert.ToInt32(reader["Year"]);
                            vehicleFromDB.LicensePlate = reader["LicensePlate"].ToString();
                            vehicleFromDB.Wheels = reader["Wheels"].ToString();
                            vehicleFromDB.GearType = reader["GearType"].ToString();
                            vehicleFromDB.Doors = Convert.ToInt32(reader["Doors"]);
                            vehicleFromDB.Airbags = reader["Airbags"].ToString();

                            Console.WriteLine($"" +
                                $"------------------------------\n" +
                                $"ID: {vehicleFromDB.VehicleID}\n" +
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
