using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuzrast = int.Parse(Console.ReadLine());
            double cenaperalna = double.Parse(Console.ReadLine());
            double cenaigrachki = double.Parse(Console.ReadLine());

            double sumrojden = 0;
            double kraino = 0;
            double igrachki = 0;
            int sumichka = 10;
            for (int i = 1; i <= vuzrast; i++)
            {

                if (i % 2 == 0)
                {

                    sumrojden += sumichka;
                    sumrojden--;
                    sumichka += 10;
                }
                else
                {
                    igrachki++;
                }
            }


            igrachki *= cenaigrachki;
            sumrojden += igrachki;
            kraino = sumrojden - cenaperalna;

            if (kraino >= 0)
            {
                Console.WriteLine("Yes! {0:F2}", kraino);
            }
            else
            {
                kraino *= -1;

                Console.WriteLine("No! {0:F2}", kraino);
            }
        }
    }
}
