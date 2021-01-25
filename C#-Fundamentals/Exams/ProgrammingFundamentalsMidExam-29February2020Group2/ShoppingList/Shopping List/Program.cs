using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();


            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "Go Shopping!")
            {

                string[] tokens = commands.Split();
                string currentCommand = tokens[0];

                if (currentCommand == "Urgent")
                {

                    string item = tokens[1];

                    if (!products.Contains(item))
                    {
                        products.Insert(0, item);
                    }

                }

                else if (currentCommand == "Unnecessary")
                {

                    string item = tokens[1];


                    if (products.Contains(item))
                    {
                        products.Remove(item);
                    }


                }

                else if (currentCommand == "Correct")
                {

                    string oldItem = tokens[1];
                    string newItem = tokens[2];

                    if (products.Contains(oldItem))
                    {
                        int index = products.IndexOf(oldItem);
                        products[index] = newItem;
                    }


                }

                else if (currentCommand == "Rearrange")
                {

                    string item = tokens[1];

                    if (products.Contains(item))
                    {
                        products.Remove(item);
                        products.Add(item);
                    }

                }


            }


            Console.WriteLine(string.Join(", ", products));
        }
    }
}
