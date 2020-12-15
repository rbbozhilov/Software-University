using System;

namespace Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradus = double.Parse(Console.ReadLine());


            if (gradus >= 26 && gradus <= 35)
            {
                Console.WriteLine("Hot");
            }
            else if (gradus >= 20.1 && gradus <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (gradus >= 15 && gradus <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (gradus >= 12 && gradus <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (gradus >= 5 && gradus <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
