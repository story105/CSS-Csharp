using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInClass
{
    class ElectricCar :Car
    {
        //Here you add changes to specific class here
        int kwh;
        public ElectricCar(string color, string name, int numDoors, int numWheels, int topSpeed, int kwh) : base(name, numDoors, numWheels, topSpeed, color)
        {
            this.kwh = kwh;

        }
        public override string ToString()
        {
            return base.ToString() + " the kwh are " + kwh;

        }
    }
}
