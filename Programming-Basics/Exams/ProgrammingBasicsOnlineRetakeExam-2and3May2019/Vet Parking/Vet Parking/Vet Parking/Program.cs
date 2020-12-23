using System;

namespace Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int pileMenu = int.Parse(Console.ReadLine());
            int ribaMenu = int.Parse(Console.ReadLine());
            int vegaMenu = int.Parse(Console.ReadLine());


            double sumPile = (double)pileMenu * 10.35;
            double sumRiba = (double)ribaMenu * 12.40;
            double sumVega = (double)vegaMenu * 8.15;

            double totalSum = sumPile + sumRiba + sumVega;

            totalSum = totalSum + (totalSum * 0.2) + 2.50;


            Console.WriteLine("Total: {0:F2}", totalSum);
        }
    }
}
