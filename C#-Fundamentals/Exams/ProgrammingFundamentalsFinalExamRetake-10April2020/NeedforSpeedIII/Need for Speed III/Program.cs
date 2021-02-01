using System;
using System.Collections.Generic;
using System.Linq;

namespace Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var nameAndMil = new Dictionary<string, int>();
            var nameAndFuel = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string currentCar = input[0];
                int mil = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                if (!nameAndMil.ContainsKey(currentCar))
                {

                    nameAndMil.Add(currentCar, mil);
                    nameAndFuel.Add(currentCar, fuel);


                }



            }

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "Stop")
            {

                string[] tokens = commands.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string currentCommand = tokens[0];

                if (currentCommand == "Drive")
                {

                    string currentCar = tokens[1];
                    int dist = int.Parse(tokens[2]);
                    int fuel = int.Parse(tokens[3]);

                    if (nameAndFuel[currentCar] >= fuel)
                    {

                        nameAndFuel[currentCar] -= fuel;
                        nameAndMil[currentCar] += dist;

                        Console.WriteLine("{0} driven for {1} kilometers. {2} liters of fuel consumed.", currentCar, dist, fuel);

                    }

                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }


                    if (nameAndMil[currentCar] >= 100000)
                    {
                        nameAndMil.Remove(currentCar);
                        nameAndFuel.Remove(currentCar);
                        Console.WriteLine("Time to sell the {0}!", currentCar);
                    }


                }

                else if (currentCommand == "Refuel")
                {

                    string currentCar = tokens[1];
                    int fuel = int.Parse(tokens[2]);

                    int sum = fuel + nameAndFuel[currentCar];

                    if (sum >= 75)
                    {

                        sum = 75 - nameAndFuel[currentCar];
                        nameAndFuel[currentCar] = 75;

                    }

                    else
                    {
                        nameAndFuel[currentCar] += fuel;
                        sum = fuel;
                    }

                    Console.WriteLine("{0} refueled with {1} liters", currentCar, sum);

                }

                else if (currentCommand == "Revert")
                {

                    string currentCar = tokens[1];
                    int kilometres = int.Parse(tokens[2]);

                    nameAndMil[currentCar] -= kilometres;

                    if (nameAndMil[currentCar] < 10000)
                    {
                        nameAndMil[currentCar] = 10000;
                    }

                    Console.WriteLine("{0} mileage decreased by {1} kilometers", currentCar, kilometres);

                }


            }

            nameAndMil = nameAndMil.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            foreach (var items in nameAndMil)
            {
                Console.WriteLine("{0} -> Mileage: {1} kms, Fuel in the tank: {2} lt.", items.Key, items.Value, nameAndFuel[items.Key]);
            }
        }
    }
}
