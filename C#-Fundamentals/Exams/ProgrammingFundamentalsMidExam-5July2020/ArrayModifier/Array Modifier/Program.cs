using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = string.Empty;


            while ((command = Console.ReadLine()) != "end")
            {

                string[] tokens = command.Split();
                string currentCommand = tokens[0];

                if (currentCommand == "swap")
                {

                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    if ((firstIndex >= 0 && firstIndex < numbers.Count) && (secondIndex >= 0 && secondIndex < numbers.Count))
                    {

                        int temp = numbers[firstIndex];
                        numbers[firstIndex] = numbers[secondIndex];
                        numbers[secondIndex] = temp;

                    }

                }

                else if (currentCommand == "multiply")
                {

                    int firstIndex = int.Parse(tokens[1]);
                    int secondIndex = int.Parse(tokens[2]);

                    if ((firstIndex >= 0 && firstIndex < numbers.Count) && (secondIndex >= 0 && secondIndex < numbers.Count))
                    {

                        numbers[firstIndex] *= numbers[secondIndex];

                    }

                }

                else if (currentCommand == "decrease")
                {

                    Func<int, int> func = x => x - 1;

                    numbers = numbers.Select(func).ToList();

                }



            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
