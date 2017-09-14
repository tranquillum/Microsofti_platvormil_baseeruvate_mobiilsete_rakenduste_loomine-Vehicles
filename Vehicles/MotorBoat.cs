using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class MotorBoat:Boat
    {
        public int tankTize { get; set; }
        public string topSpeed { get; set; }

        public void competeOnTheLake()
        {
            Console.WriteLine("Competing on the Lake");
        }

        public void quicklyMoveOnEater()
        {
            Console.WriteLine("quickly moving on water");
        }

    }
}
