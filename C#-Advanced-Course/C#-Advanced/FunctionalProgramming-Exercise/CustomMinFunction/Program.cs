using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = x => int.Parse(x);

            int[] numbers = Console.ReadLine().Split().Select(parser).ToArray();

            Func<int[], int> minValue = x =>
            {

                int min = int.MaxValue;

                foreach (var items in numbers)
                {
                    if (items < min)
                    {
                        min = items;
                    }
                }
                return min;
            };


            Console.WriteLine(minValue(numbers));
        }
    }
}
