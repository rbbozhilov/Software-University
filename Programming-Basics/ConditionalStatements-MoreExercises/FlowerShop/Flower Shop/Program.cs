using System;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int broimagnoli = int.Parse(Console.ReadLine());
            int broiziombioli = int.Parse(Console.ReadLine());
            int broirozi = int.Parse(Console.ReadLine());
            int broikaktusi = int.Parse(Console.ReadLine());
            double cenapodaruk = double.Parse(Console.ReadLine());

            double sum = (double)(broimagnoli * 3.25) + (broiziombioli * 4) + (broirozi * 3.5) + (broikaktusi * 8);

            sum = sum - (sum * 0.05);

            if (sum >= cenapodaruk)
            {
                double finalsum = sum - cenapodaruk;

                Console.WriteLine("She is left with {0} leva.", Math.Floor(finalsum));
            }
            else
            {
                double finalsum = Math.Abs(sum - cenapodaruk);
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(finalsum));
            }
        }
    }
}
