using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoworkshop_Management_System
{
    internal class Motorcycle : Vehicle
    {
        public int Handles { get; set; }

        public override void GetVechicleData()
        {
            Console.WriteLine($"{VechicleID} {Model} {Handles}");
        }
    }
}
