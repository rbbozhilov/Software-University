using System;
using VehiclesExtension.Models;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {


            string[] inputCar = Console.ReadLine().Split();
            Car car = new Car(double.Parse(inputCar[1]), double.Parse(inputCar[2]),double.Parse(inputCar[3]));
            string[] inputTruck = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]),double.Parse(inputTruck[3]));
            string[] inputBus = Console.ReadLine().Split();
            Bus bus = new Bus(double.Parse(inputBus[1]), double.Parse(inputBus[2]), double.Parse(inputBus[3]));
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {

                string[] commands = Console.ReadLine().Split();
                string currentCommand = commands[0] + " " + commands[1];
                double currentNum = double.Parse(commands[2]);

                if (currentCommand == "Drive Car")
                {
                    Console.WriteLine(car.Driving(currentNum,true));
                }
                else if (currentCommand == "Drive Truck")
                {
                    Console.WriteLine(truck.Driving(currentNum,true));
                }
                else if(currentCommand=="Drive Bus")
                {
                    Console.WriteLine(bus.Driving(currentNum,true));
                }
                else if(currentCommand=="DriveEmpty Bus")
                {
                    Console.WriteLine(bus.Driving(currentNum,false));
                }
                else if (currentCommand == "Refuel Car")
                {
                    car.Refuel(currentNum);
                }
                else if (currentCommand == "Refuel Truck")
                {
                    truck.Refuel(currentNum);
                }
                else if(currentCommand == "Refuel Bus")
                {
                    bus.Refuel(currentNum);
                }

            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());

        }
    }
}

