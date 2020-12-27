using System;

namespace Tennis_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOneRacket = double.Parse(Console.ReadLine());
            int countRackets = int.Parse(Console.ReadLine());
            int countShoes = int.Parse(Console.ReadLine());


            double priceRacket = priceOneRacket * countRackets;

            double priceShoes = (double)priceOneRacket / 6;

            double priceAllShoes = priceShoes * countShoes;

            double priceOther = (priceRacket + priceAllShoes) * 0.2;

            double finalPrice = priceRacket + priceOther + priceAllShoes;




            Console.WriteLine("Price to be paid by Djokovic {0}", Math.Floor(finalPrice / 8));
            Console.WriteLine("Price to be paid by sponsors {0}", Math.Ceiling(finalPrice * 7 / 8));
        }
    }
}
