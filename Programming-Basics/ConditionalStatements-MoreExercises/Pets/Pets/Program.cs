using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            int obshtahranakilo = int.Parse(Console.ReadLine());
            double hranakuche = double.Parse(Console.ReadLine());
            double hranakotka = double.Parse(Console.ReadLine());
            double hranakostenurka = double.Parse(Console.ReadLine());

            double sumkuche = dni * hranakuche;
            double sumkotka = dni * hranakotka;
            double sumkoste = (dni * hranakostenurka) / 1000;

            double obshtohrana = sumkuche + sumkotka + sumkoste;

            if (obshtahranakilo >= obshtohrana)
            {

                double finalsum = Math.Floor(obshtahranakilo - obshtohrana);
                Console.WriteLine("{0} kilos of food left.", finalsum);

            }
            else
            {
                double finalsum = Math.Ceiling(Math.Abs(obshtahranakilo - obshtohrana));
                Console.WriteLine("{0} more kilos of food are needed.", finalsum);
            }
        }
    }
}
