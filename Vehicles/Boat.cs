﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Boat:Vehicle
    {
        public string veight { get; set; }
        public int height { get; set; }

        public void stanInACove()
        {
            Console.WriteLine("standing in a cove");

        }
        public void keepOnWater()
        {
            Console.WriteLine("keeping on water");

        }
    }
}
