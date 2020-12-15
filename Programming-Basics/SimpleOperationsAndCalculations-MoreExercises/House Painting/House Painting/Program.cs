using System;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double heighthouse = double.Parse(Console.ReadLine());
            double longs = double.Parse(Console.ReadLine());
            double visochinanatriugulna = double.Parse(Console.ReadLine());

            double stranichnastena = heighthouse * longs;
            double prozorecplosht = 1.5 * 1.5;
            double dvestranici = 2 * stranichnastena - 2 * prozorecplosht;
            double zadnastena = heighthouse * heighthouse;
            double vhod = 1.2 * 2;
            double obshtoprednaizadna = 2 * zadnastena - vhod;
            double obshtaplosht = dvestranici + obshtoprednaizadna;
            double zelenaboa = obshtaplosht / 3.4;

            double dvapravougulnika = 2 * (heighthouse * longs);
            double triugulnici = 2 * (heighthouse * visochinanatriugulna / 2);
            double obshtaploshtred = dvapravougulnika + triugulnici;
            double chervenaboa = obshtaploshtred / 4.3;


            Console.WriteLine("{0:F2}\n{1:F2}", zelenaboa, chervenaboa);
        }
    }
}
