using System;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double lice = Math.PI * r * r;
            double perimetur = 2 * Math.PI * r;

            Console.WriteLine("{0:F2}\n{1:F2}", lice, perimetur);
        }
    }
}
