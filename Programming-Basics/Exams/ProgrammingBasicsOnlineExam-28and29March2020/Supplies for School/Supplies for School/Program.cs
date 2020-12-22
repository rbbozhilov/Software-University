using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            double paketxim = 5.80;
            double paketmarkeri = 7.20;
            double preparat = 1.20;


            int broihimikai = int.Parse(Console.ReadLine());
            int broimarkeri = int.Parse(Console.ReadLine());
            double litarpreparat = double.Parse(Console.ReadLine());
            int procentnamalenie = int.Parse(Console.ReadLine());

            double cenahimikalki = paketxim * broihimikai;
            double cenamarkeri = paketmarkeri * broimarkeri;
            double cenapreparat = preparat * litarpreparat;
            double obshtasum = cenahimikalki + cenamarkeri + cenapreparat;

            double obshtonamalenie = obshtasum - (obshtasum * procentnamalenie / 100);


            Console.WriteLine("{0:F3}", obshtonamalenie);
        }
    }
}
