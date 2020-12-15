using System;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());

            double h = double.Parse(Console.ReadLine());

            double sum = 0;

            sum = b1 * h / 2;

            Console.WriteLine("{0:F2}", sum);
        }
    }
}
