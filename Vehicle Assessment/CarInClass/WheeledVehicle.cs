using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInClass
{
    class WheeledVehicle :Vehicle
    {
        public int numWheels;
        public WheeledVehicle(int numWheels, int topSpeed, string color, string name):base(topSpeed, color, name)
        {
            this.numWheels = numWheels;
        }
        //This doesn't need a ToString() because I never specifically call this class. Vehicle has the original to string, so
        // all other classes do have one that just extends Vehicles ToString()
    }
}
