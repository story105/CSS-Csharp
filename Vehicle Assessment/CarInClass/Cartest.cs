using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInClass
{
    class Vehicletest  
    {

        public static void Main(string[] args)
        {
            Car c = new Car(); //this is main! now assign Array, and ask the question in form "if, else if, else" 
            Car c1 = new Car("yo", 36, 1, 300, "purple");
            Car c2 = new Car("six", 5, 5, 5, "pink");

            Vehicle[] vehicleArray = new Vehicle[7];
            vehicleArray[0] = c; //Assigning above cars into the array spots
            vehicleArray[1] = c1;
            vehicleArray[2] = c2;

            Console.WriteLine("enter a vehicle type (bike, gascar, electriccar, or boat): ");
            string userInput = Console.ReadLine(); //This is the user interactive part where they design a vehicle
            if (userInput == "bike")
            {
                Console.WriteLine("Enter a top speed! ");
                string userTopSpeed = Console.ReadLine();
                int bikeTopSpeed = Int32.Parse(userTopSpeed); //At end of this Console.WriteLine(your bike has...")
                Console.WriteLine("Enter the number of wheels: ");
                string userNumWheels = Console.ReadLine();
                int bikeNumWheels = Int32.Parse(userNumWheels);
                Console.WriteLine("Enter the number of gears: ");
                string userNumGears = Console.ReadLine();
                int bikeNumGears = Int32.Parse(userNumGears);
                Console.WriteLine("Enter the name of your bike: ");
                string bikeName = Console.ReadLine();
                Console.WriteLine("Enter the color of the bike: ");
                string bikeColor = Console.ReadLine();
                Console.WriteLine("Your bike's top speed is " + bikeTopSpeed + " it has " + bikeNumWheels + " wheels, and " + bikeNumGears + " gears. It's name is " + bikeName + " and is colored " + bikeColor);
                //just a long line to write the user's bike input
            }
            else if (userInput == "boat")
            {
                Console.WriteLine("Enter a top speed! ");
                string userTopSpeed = Console.ReadLine(); //fine to reuse this variable because it will only ever go to one instance
                int boatTopSpeed = Int32.Parse(userTopSpeed); 
                Console.WriteLine("Enter the name of your boat: ");
                string boatName = Console.ReadLine();
                Console.WriteLine("Enter the color of the boat: ");
                string boatType = Console.ReadLine();
                Console.WriteLine("Enter the type of boat: ");
                string boatColor = Console.ReadLine();
                Console.WriteLine("Your boats's top speed is " + boatTopSpeed + " the type of the boat is "+ boatType+ ". It's name is " + boatName + " and is colored " + boatColor);
            }
            else if (userInput == "gascar")
            {
                Console.WriteLine("Enter a top speed! ");
                string userTopSpeed = Console.ReadLine();
                int carTopSpeed = Int32.Parse(userTopSpeed); 
                Console.WriteLine("Enter the number of wheels: ");
                string userNumWheels = Console.ReadLine();
                int carNumWheels = Int32.Parse(userNumWheels);
                Console.WriteLine("Enter the number of doors: ");
                string userNumDoors = Console.ReadLine();
                int carNumDoors = Int32.Parse(userNumDoors);
                Console.WriteLine("Enter the name of your gas-guzzlin' car: ");
                string carName = Console.ReadLine();
                Console.WriteLine("Enter the color of the car: ");
                string carColor = Console.ReadLine();
                Console.WriteLine("Enter the cars miles-per-gallon: ");
                string userMPG = Console.ReadLine();
                int carMPG = Int32.Parse(userMPG);
                Console.WriteLine("Your car's top speed is " + carTopSpeed + ", its MPG is "+ carMPG + ", it has " + carNumWheels + " wheels, and " + carNumDoors + " doors. It's name is " + carName + " and is colored " + carColor);
            }
            else if (userInput == "electriccar")
            {
                Console.WriteLine("Enter a top speed! ");
                string userTopSpeed = Console.ReadLine();
                int carTopSpeed = Int32.Parse(userTopSpeed); //this will look eerily similar to Gas car because it has in essence the same details, just not MPG
                Console.WriteLine("Enter the number of wheels: ");
                string userNumWheels = Console.ReadLine();
                int carNumWheels = Int32.Parse(userNumWheels);
                Console.WriteLine("Enter the number of doors: ");
                string userNumDoors = Console.ReadLine();
                int carNumDoors = Int32.Parse(userNumDoors);
                Console.WriteLine("Enter the name of your electric car: ");
                string carName = Console.ReadLine();
                Console.WriteLine("Enter the color of the car: ");
                string carColor = Console.ReadLine();
                Console.WriteLine("Enter the cars kilowatt-per-hour efficiency: ");
                string userKWH = Console.ReadLine();
                int carKWH = Int32.Parse(userKWH);
                Console.WriteLine("Your car's top speed is " + carTopSpeed + ", its KWH is " + carKWH + ", it has " + carNumWheels + " wheels, and " + carNumDoors + " doors. It's name is " + carName + " and is colored " + carColor);
            }
            else //Means user inputted something that isn't a correct input
            {
                Console.WriteLine("I think you misspelled something... ");
            }
            

            ElectricCar e = new ElectricCar( "blue", "EE", 40, 30, 100, 13);
            Console.WriteLine("The electric car: " + e);
            vehicleArray[3] = e;

            GasCar g = new GasCar("Guzzler", 4, 4, 120, "white", 24);
            Console.WriteLine("The gas car: " + g);
            vehicleArray[4] = g;

            Boat b = new Boat("speedy", 32, "translucent", "Speedboat");
            Console.WriteLine("The boat: " + b);
            vehicleArray[5] = b;

            Bike bi = new Bike(2, 15, "silver", "wheelie", 3);
            Console.WriteLine("The Bike: " + bi);
            vehicleArray[6] = bi;
            
            foreach (Vehicle Veh in vehicleArray)
            {
                Console.WriteLine(Veh);
            }
            
            Console.WriteLine(c1.printString());
            Console.WriteLine(c2.printString());
          
            // Car.sharedCount();

            Console.ReadKey();
        }

        private void PrintString()
        {
            throw new NotImplementedException(); //In Case
        }

    }
}
