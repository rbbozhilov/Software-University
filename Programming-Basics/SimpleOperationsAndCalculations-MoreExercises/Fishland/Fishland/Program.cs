using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaskumria = double.Parse(Console.ReadLine());
            double cenacaca = double.Parse(Console.ReadLine());
            double kilogramipalamud = double.Parse(Console.ReadLine());
            double kilosafrid = double.Parse(Console.ReadLine());
            double kilomidi = double.Parse(Console.ReadLine());


            double cenapalamud = cenaskumria + (cenaskumria * 0.6);
            double cenasafrid = cenacaca + (cenacaca * 0.8);


            double summidi = kilomidi * 7.50;
            double sumsafrid = cenasafrid * kilosafrid;
            double sumpalamud = kilogramipalamud * cenapalamud;

            double obshtacena = summidi + sumsafrid + sumpalamud;

            Console.WriteLine("{0:F2}", (obshtacena));
        }
    }
}
