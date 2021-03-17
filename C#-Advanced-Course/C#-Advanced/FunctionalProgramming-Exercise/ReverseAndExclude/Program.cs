using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();

            int number = int.Parse(Console.ReadLine());


            Func<int, bool> func = x => x % number != 0;

            numbers = numbers.Where(func).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
