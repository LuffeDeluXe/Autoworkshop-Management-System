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
            Console.WriteLine($"{VechicleID} {Model} {Doors} {Airbags}");
        }
    }
}
