using System;
using System.Collections.Generic;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var petrols = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                petrols.Enqueue(input);


            }

            int totalSum = 0;

            for (int i = 0; i < n; i++)
            {

                string currentInput = petrols.Dequeue();
                string[] tokens = currentInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int currentPetrol = int.Parse(tokens[0]);
                int currentDistance = int.Parse(tokens[1]);

                totalSum += currentPetrol;

                if (totalSum >= currentDistance)
                {
                    totalSum -= currentDistance;
                }
                else
                {
                    totalSum = 0;
                    i = -1;
                }

                petrols.Enqueue(currentInput);
            }


            string[] result = petrols.Dequeue().Split();

            Console.WriteLine(result[2]);
        }
    }
}
