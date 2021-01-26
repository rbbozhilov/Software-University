using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string commands = string.Empty;


            while ((commands = Console.ReadLine()) != "Craft!")
            {

                string[] tokens = commands.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "Collect")
                {

                    string item = tokens[1];

                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }

                }

                else if (currentCommand == "Drop")
                {

                    string item = tokens[1];


                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }

                }

                else if (currentCommand == "Combine Items")
                {

                    string[] deepToken = tokens[1].Split(":", StringSplitOptions.RemoveEmptyEntries);
                    string oldItem = deepToken[0];
                    string newItem = deepToken[1];

                    if (items.Contains(oldItem))
                    {
                        int index = items.IndexOf(oldItem);
                        items.Insert(++index, newItem);

                    }

                }

                else if (currentCommand == "Renew")
                {

                    string item = tokens[1];

                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }

                }

            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
