using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInClass
{
    class GasCar :Car
    {
        int mpg;
        public GasCar(string name, int numDoors, int numWheels, int topSpeed, string color, int mpg) : base(name, numDoors, numWheels, topSpeed, color)
        {
            this.mpg = mpg;

        }
        public override string ToString()
        {
            return base.ToString() + " the mpg are " + mpg + " the number of doors " + numDoors + " the number of wheels " + numWheels;

        }
    }
}
