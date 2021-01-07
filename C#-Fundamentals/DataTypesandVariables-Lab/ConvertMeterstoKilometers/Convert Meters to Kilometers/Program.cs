using System;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal km = (decimal)meters / 1000;

            Console.WriteLine("{0:F2}", km);
        }
    }
}
