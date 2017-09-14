using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Plane: Vehicle
    {
        public int stewardess { get; set; }
        public int seats { get; set; }
        public void Fly()
        {
            Console.WriteLine("Flying in the sky");

        }
        public void useAutopilot()
        {
            Console.WriteLine("using autopilot");

        }
    }
}
