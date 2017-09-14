using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Bike:Motocycle
    {
        public string wkeelsType { get; set; }
        public int bestSpeed { get; set; }

        public void fastRideTwoWheels()
        {
            Console.WriteLine("Rast ryding on two wheels");

        }
        public void motorcycleRace()
        {
            Console.WriteLine("taking part in a motorcycle race");

        }

    }
}
