using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var pieaceAndComp = new Dictionary<string, string>();
            var pieaceAndKey = new Dictionary<string, string>();


            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string currentPeace = input[0];
                string currentComp = input[1];
                string currentKey = input[2];

                if (!pieaceAndComp.ContainsKey(currentPeace))
                {
                    pieaceAndComp.Add(currentPeace, currentComp);
                    pieaceAndKey.Add(currentPeace, currentKey);
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {

                string[] tokens = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "Add")
                {
                    string currentPeace = tokens[1];
                    string currentComp = tokens[2];
                    string currentKey = tokens[3];

                    if (!pieaceAndComp.ContainsKey(currentPeace))
                    {
                        pieaceAndComp.Add(currentPeace, currentComp);
                        pieaceAndKey.Add(currentPeace, currentKey);
                        Console.WriteLine("{0} by {1} in {2} added to the collection!", currentPeace, currentComp, currentKey);
                    }

                    else
                    {
                        Console.WriteLine("{0} is already in the collection!", currentPeace);
                    }


                }

                else if (currentCommand == "Remove")
                {
                    string currentPeace = tokens[1];

                    if (pieaceAndComp.ContainsKey(currentPeace))
                    {
                        pieaceAndComp.Remove(currentPeace);
                        pieaceAndKey.Remove(currentPeace);
                        Console.WriteLine("Successfully removed {0}!", currentPeace);
                    }

                    else
                    {
                        Console.WriteLine("Invalid operation! {0} does not exist in the collection.", currentPeace);
                    }

                }

                else if (currentCommand == "ChangeKey")
                {

                    string currentPeace = tokens[1];
                    string newKey = tokens[2];

                    if (pieaceAndKey.ContainsKey(currentPeace))
                    {
                        pieaceAndKey[currentPeace] = newKey;
                        Console.WriteLine("Changed the key of {0} to {1}!", currentPeace, newKey);
                    }

                    else
                    {
                        Console.WriteLine("Invalid operation! {0} does not exist in the collection.", currentPeace);
                    }

                }


            }


            pieaceAndComp = pieaceAndComp.OrderBy(x => x.Key).ThenBy(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            foreach (var items in pieaceAndComp)
            {

                Console.WriteLine("{0} -> Composer: {1}, Key: {2}", items.Key, items.Value, pieaceAndKey[items.Key]);


            }
        }
    }
}
