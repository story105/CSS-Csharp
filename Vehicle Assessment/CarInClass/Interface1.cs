using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInClass
{
    class Vehicle
    {
        public int topSpeed;
        public string color;
        public string name;

        public Vehicle(int topSpeed, string color, string name)
        {
            this.topSpeed = topSpeed;
            this.color = color;
            this.name = name;
        }
        public override string ToString()
        {
            return "Your vehicle color is " + color + " the top speed is " + topSpeed + " and it's name is " + name;

        }
    }
}
