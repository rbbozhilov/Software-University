using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {

                string[] tokens = Console.ReadLine().Split();
                string currentModel = tokens[0];
                double currentAmount = double.Parse(tokens[1]);
                double currentFuelPer = double.Parse(tokens[2]);

                cars.Add(new Car(currentModel, currentAmount, currentFuelPer));

            }

            string command = string.Empty;

            while((command=Console.ReadLine()) !="End")
            {

                string[] tokens = command.Split();
                string currentCommand = tokens[0];
                string currentModel = tokens[1];
                int currentAmount = int.Parse(tokens[2]);

                Car currentCar = cars.FirstOrDefault(x=>x.Model==currentModel);
                currentCar.Drive(currentAmount);



            }

            foreach(var items in cars)
            {
                Console.WriteLine(items.ToString());
            }
            
        }
    }
}
