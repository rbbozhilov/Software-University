using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static int CalculateArea(int height, int weight)
        {


            return height * weight;

        }

        static void Main(string[] args)
        {


            int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());


            Console.WriteLine(CalculateArea(height, weight));

        }
    }
}
