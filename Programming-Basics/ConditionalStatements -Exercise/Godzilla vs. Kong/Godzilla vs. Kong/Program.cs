using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfStatists = int.Parse(Console.ReadLine());
            double priceForClotes = double.Parse(Console.ReadLine());
            double priceForDecor = budget * 0.10;
            double priceForClothing = countOfStatists * priceForClotes;



            if (countOfStatists > 150)
            {
                priceForClothing = priceForClothing - (priceForClothing * 0.10);
            }
            double allThogether = priceForDecor + priceForClothing;
            double leftMoney = budget - allThogether;
            double neededMoney = allThogether - budget;
            if (budget >= allThogether)
            {
                if (budget >= allThogether)
                    Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", leftMoney);
            }
            else if (budget < allThogether)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", neededMoney);
            }
        }
    }
}
