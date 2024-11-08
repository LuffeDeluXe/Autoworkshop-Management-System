using Microsoft.Data.SqlClient;

namespace Autoworkshop_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.GetVechicleData();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.GetVechicleData();
        }

    }
}
