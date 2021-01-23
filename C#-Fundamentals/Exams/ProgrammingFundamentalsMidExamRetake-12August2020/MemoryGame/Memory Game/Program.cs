using System;
using System.Collections.Generic;
using System.Linq;

namespace Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            int count = 0;

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {

                count++;

                string[] tokens = command.Split();
                int firstIndex = int.Parse(tokens[0]);
                int secondIndex = int.Parse(tokens[1]);

                if ((firstIndex == secondIndex) || (firstIndex < 0 || firstIndex >= numbers.Count) || (secondIndex < 0 || secondIndex >= numbers.Count))
                {

                    numbers.Insert(numbers.Count / 2, $"-{count.ToString()}a");
                    numbers.Insert(numbers.Count / 2, $"-{count.ToString()}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                else
                {
                    if (numbers[firstIndex] == numbers[secondIndex])
                    {
                        string item = numbers[firstIndex];
                        Console.WriteLine("Congrats! You have found matching elements - {0}!", numbers[firstIndex]);
                        numbers.Remove(item);
                        numbers.Remove(item);

                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

                if (numbers.Count == 0)
                {
                    Console.WriteLine("You have won in {0} turns!", count);
                    Environment.Exit(0);

                }


            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
