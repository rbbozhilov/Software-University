using System;

namespace Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int broihora = int.Parse(Console.ReadLine());
            double taksa = double.Parse(Console.ReadLine());
            double cenashezlong = double.Parse(Console.ReadLine());
            double cenachadur = double.Parse(Console.ReadLine());


            double taksavhod = taksa * broihora;
            double broishazlongi = broihora * 0.75;
            broishazlongi = Math.Ceiling(broishazlongi);
            double obshtocenashazlongi = broishazlongi * cenashezlong;
            double broichaduri = broihora * 0.5;
            broichaduri = Math.Ceiling(broichaduri);
            double obshtacenachaduri = broichaduri * cenachadur;

            double finalSum = taksavhod + obshtocenashazlongi + obshtacenachaduri;

            Console.WriteLine("{0:F2} lv.", finalSum);
        }
    }
}
