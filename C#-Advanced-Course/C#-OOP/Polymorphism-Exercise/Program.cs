using System;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {

           
            string[] inputCar = Console.ReadLine().Split();
            Car car = new Car(double.Parse(inputCar[1]), double.Parse(inputCar[2]));
            string[] inputTruck = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]));

            int numberOfCommands = int.Parse(Console.ReadLine());

            for(int i=0;i<numberOfCommands;i++)
            {

                string[] commands = Console.ReadLine().Split();
                string currentCommand = commands[0] + " " + commands[1];
                double currentNum = double.Parse(commands[2]);

                if(currentCommand == "Drive Car")
                {
                    Console.WriteLine(car.Driving(currentNum));
                }
                else if(currentCommand=="Drive Truck")
                {
                    Console.WriteLine(truck.Driving(currentNum));
                }
                else if(currentCommand == "Refuel Car")
                {
                    car.Refuel(currentNum);
                }
                else if(currentCommand=="Refuel Truck")
                {
                    truck.Refuel(currentNum);
                }

            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());

        }
    }
}
