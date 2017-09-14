using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Motocycle: Vehicle
    {
        public string bestRace { get; set; }
        public int topSpeed { get; set; }

        public void rideTwoWheels()
        {
            Console.WriteLine("Riding on 2 wheels");
        }

        public void rideInTheHelemet()
        {
            Console.WriteLine("Ride in the helmet");
        }


    }
}
