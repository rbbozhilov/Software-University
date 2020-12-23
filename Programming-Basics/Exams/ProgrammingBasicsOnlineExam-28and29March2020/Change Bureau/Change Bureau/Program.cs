using System;

namespace Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitkoin = 1168;
            double kitaiski = 0.15;
            double dolar = 1.76;
            double evro = 1.95;

            int broibitkoin = int.Parse(Console.ReadLine());
            double broikitaiski = double.Parse(Console.ReadLine());
            double komisionna = double.Parse(Console.ReadLine());

            komisionna = komisionna * 0.01;
            double bitkoinsum = (double)bitkoin * broibitkoin;
            double kitaisum = (double)kitaiski * broikitaiski;
            double dolarvlev = (double)kitaisum * dolar;

            double sum = (double)(bitkoinsum + dolarvlev);
            double sum1 = sum / evro;
            double komision1na = (double)sum1 * komisionna;

            double kraen = (double)sum1 - komision1na;


            Console.WriteLine("{0:F2}", (kraen));
        }
    }
}
