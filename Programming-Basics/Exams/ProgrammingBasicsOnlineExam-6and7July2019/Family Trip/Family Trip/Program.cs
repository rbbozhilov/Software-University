using System;

namespace Family_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double priceNight = double.Parse(Console.ReadLine());
            int percentOther = int.Parse(Console.ReadLine());


            if (nights > 7)
            {

                priceNight = priceNight - (priceNight * 0.05);

            }


            double sum = priceNight * nights;

            sum += (double)((double)percentOther / 100) * budjet;

            if (sum <= budjet)
            {

                Console.WriteLine("Ivanovi will be left with {0:F2} leva after vacation.", budjet - sum);
            }
            else
            {
                Console.WriteLine("{0:F2} leva needed.", sum - budjet);
            }
        }
    }
}
