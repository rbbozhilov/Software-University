using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int procesors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());



            double sumVideoCards = 250 * videoCards;
            double sumProcessor = (sumVideoCards * 0.35) * procesors;
            double sumRam = (sumVideoCards * 0.1) * ram;


            double finalSum = sumVideoCards + sumProcessor + sumRam;

            if (videoCards > procesors)
            {
                finalSum = finalSum - (finalSum * 0.15);
            }


            if (finalSum <= budjet)
            {
                Console.WriteLine("You have {0:F2} leva left!", budjet - finalSum);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva more!", finalSum - budjet);
            }
        }
    }
}
