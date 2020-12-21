using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int kvmetraloze = int.Parse(Console.ReadLine());
            double grozdezaedinkv = double.Parse(Console.ReadLine());
            int nujnilitra = int.Parse(Console.ReadLine());
            int broirabotnika = int.Parse(Console.ReadLine());

            double obshtogrozde = (double)kvmetraloze * grozdezaedinkv;

            double vino = (double)0.4 * (obshtogrozde / 2.5);

            if (vino >= nujnilitra)
            {

                double sumother = (double)Math.Ceiling(vino - nujnilitra);
                double sumrabotnik = (double)Math.Ceiling(sumother / broirabotnika);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n{1} liters left -> {2} liters per person.", Math.Floor(vino), sumother, sumrabotnik);

            }

            else
            {

                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(Math.Abs(vino - nujnilitra)));
            }
        }
    }
}
