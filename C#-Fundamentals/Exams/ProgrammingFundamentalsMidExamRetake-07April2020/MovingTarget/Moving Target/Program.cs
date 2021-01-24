using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {

                string[] tokens = command.Split();
                string currentCommand = tokens[0];

                if (currentCommand == "Shoot")
                {

                    int index = int.Parse(tokens[1]);
                    int power = int.Parse(tokens[2]);

                    if (index >= 0 && index < targets.Count)
                    {

                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }

                    }

                }

                else if (currentCommand == "Add")
                {
                    int index = int.Parse(tokens[1]);
                    int value = int.Parse(tokens[2]);


                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }

                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }


                }

                else if (currentCommand == "Strike")
                {

                    int index = int.Parse(tokens[1]);
                    int radius = int.Parse(tokens[2]);

                    if (index + radius < targets.Count && index - radius >= 0)
                    {

                        int start = index - radius;
                        int end = index + radius;

                        for (int i = start; i <= end; i++)
                        {

                            targets.RemoveAt(start);

                        }

                    }

                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }


                }

            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
