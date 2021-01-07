using System;

namespace Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double paunds = double.Parse(Console.ReadLine());


            decimal result = (decimal)paunds * (decimal)1.31;

            Console.WriteLine("{0:F3}", result);
        }
    }
}
