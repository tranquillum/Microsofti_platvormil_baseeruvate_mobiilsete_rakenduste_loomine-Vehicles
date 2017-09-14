using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car: Vehicle
    {
        public int tankTize { get; set; }
        public int seatsAtTheBack { get; set; }

        public void twistTheWheel()
        {
            Console.WriteLine("twisting the wheel");

        }


        public void RideOnTheRoad()
        {
            Console.WriteLine("riding on the road");

        }
    }
}
