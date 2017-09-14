using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle
    {
       

        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfUse { get; set; }

        public void getIn()
        {
            Console.WriteLine("Getting in");

        }

        

        public virtual void startEngine(int howFast)
        {
            for (int i = 0; i < howFast; i++)
            {
                Console.WriteLine("{0} seconds", i);
            }


        }

    }
}
