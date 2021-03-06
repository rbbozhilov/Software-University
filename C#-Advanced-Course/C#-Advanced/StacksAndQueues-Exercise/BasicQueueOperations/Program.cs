using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numbersInStack = command[0];
            int popFromStack = command[1];
            int searchElement = command[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var other = new Queue<int>();


            for (int i = 0; i < numbersInStack; i++)
            {
                other.Enqueue(numbers[i]);
            }

            for (int i = 0; i < popFromStack; i++)
            {
                other.Dequeue();
            }

            if (other.Contains(searchElement))
            {
                Console.WriteLine("true");
            }
            else if (other.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(other.Min());
            }
        }
    }
}
