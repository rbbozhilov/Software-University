using System;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int mladshi = int.Parse(Console.ReadLine());
            int starshi = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            switch (trace)
            {
                case "trail":
                    {
                        double summladshi = (double)5.50 * mladshi;
                        double starshisum = (double)7 * starshi;
                        double obshtasum = starshisum + summladshi;
                        obshtasum = obshtasum - (obshtasum * 0.05);
                        Console.WriteLine("{0:F2}", obshtasum);
                        break;


                    }
                case "cross-country":
                    {

                        double k = 8;
                        double t = 9.50;
                        if (mladshi + starshi >= 50)
                        {
                            k = k - (k * 0.25);
                            t = t - (t * 0.25);
                        }
                        double summladshi = (double)k * mladshi;
                        double starshisum = (double)t * starshi;
                        double obshtasum = starshisum + summladshi;

                        obshtasum = obshtasum - (obshtasum * 0.05);
                        Console.WriteLine("{0:F2}", obshtasum);
                        break;
                    }
                case "downhill":
                    {
                        double summladshi = (double)12.25 * mladshi;
                        double starshisum = (double)13.75 * starshi;
                        double obshtasum = starshisum + summladshi;
                        obshtasum = obshtasum - (obshtasum * 0.05);
                        Console.WriteLine("{0:F2}", obshtasum);
                        break;
                    }
                case "road":
                    {
                        double summladshi = (double)20 * mladshi;
                        double starshisum = (double)21.50 * starshi;
                        double obshtasum = starshisum + summladshi;
                        obshtasum = obshtasum - (obshtasum * 0.05);
                        Console.WriteLine("{0:F2}", obshtasum);
                        break;
                    }
            }
        }
    }
}
