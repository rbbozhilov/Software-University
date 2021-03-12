using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Function(number, Count);
            Function(number, Sum);

        }

        static void Function(int[] array, Func<int[], int> operation)
        {

            int result = operation(array);

            Console.WriteLine(result);
        }

        static int Count(int[] array)
        {
            return array.Length;
        }

        static int Sum(int[] array)
        {
            return array.Sum();
        }

    }
}
