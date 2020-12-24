using System;

namespace Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int vremeSnimki = int.Parse(Console.ReadLine());
            int broiSceni = int.Parse(Console.ReadLine());
            int vremetraene = int.Parse(Console.ReadLine());


            double podgotovka = (double)vremeSnimki * 0.15;
            double vremeZasnemane = broiSceni * vremetraene;
            double finalTime = (podgotovka + vremeZasnemane);

            if (vremeSnimki >= finalTime)
            {

                Console.WriteLine("You managed to finish the movie on time! You have {0} minutes left!", Math.Ceiling(Math.Abs(finalTime - vremeSnimki)));

            }
            else
            {
                Console.WriteLine("Time is up! To complete the movie you need {0} minutes.", Math.Ceiling(Math.Abs(finalTime - vremeSnimki)));
            }
        }
    }
}
