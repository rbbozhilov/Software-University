using System;

namespace Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int naem = int.Parse(Console.ReadLine());

            double priceStatuet = (double)naem - (naem * 0.3);
            double priceketarink = priceStatuet - (priceStatuet * 0.15);
            double priceSound = priceketarink / 2;

            double totalPrice = naem + priceketarink + priceStatuet + priceSound;


            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}
