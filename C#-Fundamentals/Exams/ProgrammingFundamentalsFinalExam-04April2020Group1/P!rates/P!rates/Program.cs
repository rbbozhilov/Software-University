using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            var townAndPopulation = new Dictionary<string, int>();
            var townAndGold = new Dictionary<string, int>();

            string input = string.Empty;


            while ((input = Console.ReadLine()) != "Sail")
            {

                string[] tokens = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                if (!townAndGold.ContainsKey(tokens[0]))
                {

                    townAndGold.Add(tokens[0], int.Parse(tokens[2]));
                    townAndPopulation.Add(tokens[0], int.Parse(tokens[1]));


                }

                else
                {
                    townAndGold[tokens[0]] += int.Parse(tokens[2]);
                    townAndPopulation[tokens[0]] += int.Parse(tokens[1]);
                }

            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {

                string[] tokens = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "Plunder")
                {

                    string currentTown = tokens[1];
                    int currentPeople = int.Parse(tokens[2]);
                    int currentGold = int.Parse(tokens[3]);

                    if (townAndPopulation.ContainsKey(currentTown))
                    {

                        townAndPopulation[currentTown] -= currentPeople;
                        townAndGold[currentTown] -= currentGold;

                        Console.WriteLine("{0} plundered! {1} gold stolen, {2} citizens killed.", currentTown, currentGold, currentPeople);



                    }

                    if (townAndGold[currentTown] <= 0 || townAndPopulation[currentTown] <= 0)
                    {
                        townAndGold.Remove(currentTown);
                        townAndPopulation.Remove(currentTown);
                        Console.WriteLine("{0} has been wiped off the map!", currentTown);
                    }


                }


                else if (currentCommand == "Prosper")
                {

                    string currentTown = tokens[1];
                    int gold = int.Parse(tokens[2]);

                    if (gold >= 0)
                    {

                        if (townAndGold.ContainsKey(currentTown))
                        {
                            townAndGold[currentTown] += gold;

                            Console.WriteLine("{0} gold added to the city treasury. {1} now has {2} gold.", gold, currentTown, townAndGold[currentTown]);
                        }

                    }

                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }


                }

            }


            townAndGold = townAndGold.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);


            if (townAndGold.Count > 0)
            {

                Console.WriteLine("Ahoy, Captain! There are {0} wealthy settlements to go to:", townAndGold.Count);

                foreach (var items in townAndGold)
                {

                    Console.WriteLine("{0} -> Population: {1} citizens, Gold: {2} kg", items.Key, townAndPopulation[items.Key], items.Value);


                }

            }

            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
