using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(input);
            int count = 1;
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;

            if (stack.Peek() == 0)
            {
                Console.WriteLine("0");
                Environment.Exit(1);
            }


            while (stack.Count > 0)
            {
                int currentElement = stack.Pop();
                sum += currentElement;

                if (sum == capacity)
                {
                    count++;
                    sum = 0;
                }
                else if (sum > capacity)
                {
                    stack.Push(currentElement);
                    count++;
                    sum = 0;
                }


            }

            Console.WriteLine(count);
        }
    }
}
