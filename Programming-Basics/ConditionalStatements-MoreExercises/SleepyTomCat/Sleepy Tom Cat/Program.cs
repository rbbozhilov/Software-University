using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int pochivka = int.Parse(Console.ReadLine());

            int pochivnidni = pochivka * 127;
            int rabotnidni = 365 - pochivka;
            rabotnidni *= 63;
            int sumall = pochivnidni + rabotnidni;
            int sum = 30000 - sumall;


            if (sum >= 0)
            {
                int hours = sum / 60;
                int minutes = sum % 60;

                Console.WriteLine("Tom sleeps well\n{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                int sumer = Math.Abs(30000 - sumall);
                int hours = sumer / 60;
                int minutes = sumer % 60;

                Console.WriteLine("Tom will run away\n{0} hours and {1} minutes more for play", hours, minutes);
            }
        }
    }
}
