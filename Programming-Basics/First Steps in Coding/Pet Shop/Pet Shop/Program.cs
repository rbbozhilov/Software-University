using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int kucheta = int.Parse(Console.ReadLine());
            int drugi = int.Parse(Console.ReadLine());

            if (kucheta >= 0 && kucheta <= 100 && drugi >= 0 && drugi <= 100)
            {
                Console.WriteLine((kucheta * 2.50) + (drugi * 4) + " lv.");
            }
        }
    }
}
