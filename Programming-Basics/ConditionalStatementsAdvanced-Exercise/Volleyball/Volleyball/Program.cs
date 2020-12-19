using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string godina = Console.ReadLine();

            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int weekends = 48 - h;
            double obshtoigri = 0;
            switch (godina)
            {

                case "leap":
                    {

                        double weekendSofia = 0;

                        weekendSofia = (double)weekends * 3 / 4;


                        double praznikigri = 0;
                        praznikigri = (double)p * 2 / 3;

                        obshtoigri = (double)weekendSofia + h + praznikigri;

                        obshtoigri += obshtoigri * 0.15;




                        break;
                    }

                case "normal":
                    {
                        double weekendSofia = 0;

                        weekendSofia = (double)weekends * 3 / 4;


                        double praznikigri = 0;
                        praznikigri = (double)p * 2 / 3;

                        obshtoigri = (double)weekendSofia + h + praznikigri;

                        break;
                    }

            }

            Console.WriteLine(Math.Floor(obshtoigri));
        }
    }
}
