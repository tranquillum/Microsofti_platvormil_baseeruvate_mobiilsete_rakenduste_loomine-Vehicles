using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class SportCar:Car
    {
        public string bestRace { get; set; }
        public int topSpeed { get; set; }

        public void MotorRacing()
        {
            Console.WriteLine("participate in motor racing");

        }
        public void RideOnTheTrack()
        {
            Console.WriteLine("riding on the race track");

        }
    }
}
