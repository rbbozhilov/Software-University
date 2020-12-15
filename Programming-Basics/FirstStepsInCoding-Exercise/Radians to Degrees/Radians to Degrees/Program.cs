using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            float rad = float.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(rad * 180 / Math.PI));
        }
    }
}
