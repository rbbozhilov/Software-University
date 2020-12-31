using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split();

                string command = input[0];


                if (command == "register")
                {

                    string name = input[1];
                    string numberOfCar = input[2];

                    if (!dictionary.ContainsKey(name))
                    {

                        dictionary.Add(name, numberOfCar);

                        Console.WriteLine("{0} registered {1} successfully", name, numberOfCar);

                    }

                    else
                    {

                        Console.WriteLine("ERROR: already registered with plate number {0}", numberOfCar);

                    }

                }

                else if (command == "unregister")
                {

                    string name = input[1];

                    if (dictionary.ContainsKey(name))
                    {
                        dictionary.Remove(name);
                        Console.WriteLine("{0} unregistered successfully", name);
                    }

                    else
                    {
                        Console.WriteLine("ERROR: user {0} not found", name);
                    }

                }

            }


            foreach (var items in dictionary)
            {
                Console.WriteLine("{0} => {1}", items.Key, items.Value);
            }
        }
    }
}
