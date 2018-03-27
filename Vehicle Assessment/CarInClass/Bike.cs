using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInClass
{
    class Bike :WheeledVehicle
    {
        public int numGears;
        public Bike(int numWheels, int topSpeed, string color, string name, int numGears):base(numWheels, topSpeed, color, name)
        {
            this.numGears = numGears;
        }
        public override string ToString()
        {
            return base.ToString() + " The number of wheels " + numWheels + " the number of gears " + numGears;

        }
    }
}
