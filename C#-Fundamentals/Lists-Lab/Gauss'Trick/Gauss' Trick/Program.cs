using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int count = numbers.Count;

            for (int i = 0; i < count / 2; i++)
            {


                numbers[i] += numbers[count - i - 1];
                numbers.RemoveAt(count - i - 1);


            }


            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
