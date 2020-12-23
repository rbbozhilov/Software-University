using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            double litraGorivo = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();


            double priceFuel = litraGorivo * 2.10;
            priceFuel += 100;


            if (day == "Saturday")
            {
                priceFuel = priceFuel - (priceFuel * 0.1);
            }
            else if (day == "Sunday")
            {
                priceFuel = priceFuel - (priceFuel * 0.2);
            }


            if (priceFuel <= budjet)
            {
                Console.WriteLine("Safari time! Money left: {0:F2} lv.", budjet - priceFuel);
            }
            else
            {
                Console.WriteLine("Not enough money! Money needed: {0:F2} lv.", priceFuel - budjet);
            }
        }
    }
}
