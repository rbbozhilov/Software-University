using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceDress = double.Parse(Console.ReadLine());


            double dekor = budjet * 0.1;

            double sumDress = statists * priceDress;

            if (statists > 150)
            {
                sumDress = sumDress - (sumDress * 0.1);
            }


            double finalSum = sumDress + dekor;

            if (finalSum <= budjet)
            {

                Console.WriteLine("Action!\nWingard starts filming with {0:F2} leva left.", budjet - finalSum);

            }
            else
            {
                Console.WriteLine("Not enough money!\nWingard needs {0:F2} leva more.", finalSum - budjet);
            }
        }
    }
}
