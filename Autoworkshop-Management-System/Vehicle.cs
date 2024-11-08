using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoworkshop_Management_System
{
    internal abstract class Vehicle
    {
        public int VehicleID { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public int Year { get; set; }

        public string LicensePlate { get; set; }

        public string Wheels { get; set; }

        public string GearType { get; set; }

        public abstract void GetVechicleData();
   

       
    }
}
