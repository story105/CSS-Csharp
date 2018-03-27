using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInClass 
{
    class Car : WheeledVehicle //This is the top Car in the tree
    {
        
        
        
        public int numDoors;
        public static int count = 0;


        public Car(string name, int numDoors, int numWheels, int topSpeed, string color):base(numWheels, topSpeed, color, name)
        {           
            this.numDoors = numDoors;
              
        }
        public Car():base(0,0, "", "")
        {
            count++;
        }

        public string printString()
        {
            return "Your car color is " + color + " the number of doors is " + numDoors + " the number of wheels is " + numWheels + " the top speed is " + topSpeed + " and it's name is " + name;
        }

        
        public static void sharedCount()
        {

            Console.WriteLine("count" + count);
        }
    }
}

