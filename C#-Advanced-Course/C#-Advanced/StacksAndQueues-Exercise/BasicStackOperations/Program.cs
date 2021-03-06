using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
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

            var stack = new Stack<int>();


            for (int i = 0; i < numbersInStack; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < popFromStack; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(searchElement))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
