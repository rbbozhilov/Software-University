using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] largestNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            largestNumbers = largestNumbers.OrderByDescending(x => x).ToArray();
            largestNumbers = largestNumbers.Take(3).ToArray();

            Console.WriteLine(string.Join(" ", largestNumbers));
        }
    }
}
