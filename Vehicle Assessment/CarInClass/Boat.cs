using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInClass
{
    class Boat : Vehicle
    {
        public string typeBoat;
        public Boat(string name, int topSpeed, string color, string typeBoat) : base(topSpeed, color, name)
        {
            this.typeBoat = typeBoat;
        }
        public override string ToString()
        {
            return base.ToString() + " the type of boat " + typeBoat;

        }
    }
}
