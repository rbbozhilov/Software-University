using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double voda = 20;
            double internet = 15;
            double obshtacena = 0;
            double average = 0;
            double sumtok = 0;
            for (int i = 0; i < months; i++)
            {

                double tok = double.Parse(Console.ReadLine());
                sumtok += tok;

                double obshto = (voda + tok + internet) + ((voda + tok + internet) * 0.2);

                obshtacena += obshto;

            }

            double sumvoda = 20 * months;
            double suminternet = 15 * months;

            average = (sumvoda + suminternet + obshtacena + sumtok) / months;
            Console.WriteLine("Electricity: {0:F2} lv\nWater: {1:F2} lv\nInternet: {2:F2} lv\nOther: {3:F2} lv\nAverage: {4:F2} lv", sumtok, sumvoda, suminternet, obshtacena, average);
        }
    }
}
