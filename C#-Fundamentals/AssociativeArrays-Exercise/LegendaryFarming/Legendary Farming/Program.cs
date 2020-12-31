using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, int>();
            var junkItems = new Dictionary<string, int>();

            dictionary.Add("shards", 0);
            dictionary.Add("fragments", 0);
            dictionary.Add("motes", 0);
            bool isBreak = false;

            while (true)
            {

                string[] input = Console.ReadLine().Split();
                int currentIndex = 0;

                for (int i = 0; i < input.Length / 2; i++)
                {


                    int currentValue = int.Parse(input[currentIndex]);
                    currentIndex++;
                    string currentItem = input[currentIndex].ToLower();
                    currentIndex++;

                    if (dictionary.ContainsKey(currentItem))
                    {
                        dictionary[currentItem] += currentValue;
                    }

                    else
                    {
                        if (!junkItems.ContainsKey(currentItem))
                        {

                            junkItems.Add(currentItem, currentValue);

                        }

                        else
                        {
                            junkItems[currentItem] += currentValue;
                        }

                    }

                    if (dictionary["shards"] >= 250)
                    {

                        Console.WriteLine("Shadowmourne obtained!");

                        dictionary["shards"] -= 250;
                        isBreak = true;
                        break;
                    }

                    else if (dictionary["fragments"] >= 250)
                    {

                        Console.WriteLine("Valanyr obtained!");

                        dictionary["fragments"] -= 250;
                        isBreak = true;

                        break;
                    }

                    else if (dictionary["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");

                        dictionary["motes"] -= 250;
                        isBreak = true;
                        break;
                    }


                }

                if (isBreak)
                {
                    break;
                }

            }


            dictionary = dictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var items in dictionary)
            {
                Console.WriteLine("{0}: {1}", items.Key, items.Value);
            }

            junkItems = junkItems.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var items in junkItems)
            {
                Console.WriteLine("{0}: {1}", items.Key, items.Value);
            }
        }
    }
}
