using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int broitovar = int.Parse(Console.ReadLine());
            double sum = 0;
            double obshtsum = 0;
            int broach3 = 0;
            int broach4 = 0;
            int broach5 = 0;
            for (int i = 0; i < broitovar; i++)
            {

                int tovar = int.Parse(Console.ReadLine());

                obshtsum += tovar;

                if (tovar <= 3)
                {
                    broach3 += tovar;


                }

                else if (tovar >= 4 && tovar <= 11)
                {
                    broach4 += tovar;
                }

                else if (tovar >= 12)
                {

                    broach5 += tovar;

                }
            }


            sum = ((broach3 * 200) + (broach4 * 175) + (broach5 * 120)) / obshtsum;

            double mikrobus = (double)(broach3 / obshtsum) * 100;
            double kamion = (double)(broach4 / obshtsum) * 100;
            double vlak = (double)(broach5 / obshtsum) * 100;


            Console.WriteLine("{0:F2}\n{1:F2}%\n{2:F2}%\n{3:F2}%", sum, mikrobus, kamion, vlak);
        }
    }
}
