using System;

namespace Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());


            if (liters >= 25 && (fuel == "Gas" || fuel == "Diesel" || fuel == "Gasoline"))
            {


                if (fuel == "Gas")
                {
                    Console.WriteLine("You have enough gas.");
                }
                else if (fuel == "Diesel")
                {
                    Console.WriteLine("You have enough diesel.");
                }
                else if (fuel == "Gasoline")
                {
                    Console.WriteLine("You have enough gasoline.");
                }

            }
            else if (liters < 25 && (fuel == "Gas" || fuel == "Diesel" || fuel == "Gasoline"))
            {
                if (fuel == "Gas")
                {
                    Console.WriteLine("Fill your tank with gas!");
                }
                else if (fuel == "Diesel")
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
                else if (fuel == "Gasoline")
                {
                    Console.WriteLine("Fill your tank with gasoline!");
                }

            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
