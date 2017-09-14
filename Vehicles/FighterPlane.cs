using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class FighterPlane:Plane
    {
        public void shootDownAnAirplane()
        {
            Console.WriteLine("shooting down anamys airplane");

        }
        public void SoundSpeed()
        {
            Console.WriteLine("flying over sound speed");

        }


        public override void startEngine(int fromWhatAttempt)
        {
            Console.WriteLine("Started on the {0} try", fromWhatAttempt);
        }
    }
}
