using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaKiloZel = double.Parse(Console.ReadLine());
            double cenaKiloPlod = double.Parse(Console.ReadLine());
            double obshtokiogramzel = double.Parse(Console.ReadLine());
            double obstokilogramplod = double.Parse(Console.ReadLine());

            double sumazel = cenaKiloZel * obshtokiogramzel;
            double sumaplod = cenaKiloPlod * obstokilogramplod;
            double obshtasum = (sumazel + sumaplod) / 1.94;

            Console.WriteLine("{0:F2}", obshtasum);
        }
    }
}
