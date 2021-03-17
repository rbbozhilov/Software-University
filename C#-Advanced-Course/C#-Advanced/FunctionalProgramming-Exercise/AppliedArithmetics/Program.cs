using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = string.Empty;

            Func<int, int> addDelegate = x => { return x + 1; };
            Func<int, int> multiplyDelegate = x => { return x * 2; };
            Func<int, int> subtractDelegate = x => { return x - 1; };
            Action<int> printer = x => Console.Write(x + " ");

            while ((command = Console.ReadLine()) != "end")
            {

                if (command == "add")
                {
                    numbers = numbers.Select(addDelegate).ToList();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtractDelegate).ToList();

                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiplyDelegate).ToList();
                }
                else if (command == "print")
                {
                    numbers.ForEach(printer);
                    Console.WriteLine();
                }
            }
        }
    }
}
