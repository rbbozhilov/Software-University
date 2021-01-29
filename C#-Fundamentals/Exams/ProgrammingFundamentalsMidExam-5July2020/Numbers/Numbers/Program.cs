using System;
using System.Collections.Generic;
using System.Linq;
namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            numbers = numbers.Where(x => x > numbers.Average()).ToList();
            numbers = numbers.OrderByDescending(x => x).ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                numbers = numbers.Take(5).ToList();

                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
