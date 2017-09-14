using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class RowingBoat : Boat
    {
        public int oars { get; set; }
        public int seats { get; set; }

        public void useTheOars()
        {
            Console.WriteLine("using the oars to move");

        }

        public void drestOnTheWater()
        {
            Console.WriteLine("resting on the water");

        }

    }
}
