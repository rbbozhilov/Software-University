using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            double uspeh = double.Parse(Console.ReadLine());
            double minzaplata = double.Parse(Console.ReadLine());
            double stipendiaotlichen = Math.Floor(uspeh * 25);
            double socstipendia = Math.Floor(minzaplata * 0.35);


            if (dohod >= minzaplata && uspeh >= 5.5)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", stipendiaotlichen);
            }
            else if (dohod >= minzaplata && uspeh < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (dohod < minzaplata && uspeh >= 5.5 && socstipendia <= stipendiaotlichen)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", stipendiaotlichen);
            }
            else if (dohod < minzaplata && uspeh > 4.5)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", socstipendia);
            }
            else if (dohod < minzaplata && uspeh <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
