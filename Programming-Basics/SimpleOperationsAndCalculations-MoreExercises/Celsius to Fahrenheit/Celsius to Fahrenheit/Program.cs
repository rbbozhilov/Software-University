using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradus = double.Parse(Console.ReadLine());

            double sum = (gradus * 9 / 5) + 32;

            Console.WriteLine("{0:F2}", sum);
        }
    }
}
