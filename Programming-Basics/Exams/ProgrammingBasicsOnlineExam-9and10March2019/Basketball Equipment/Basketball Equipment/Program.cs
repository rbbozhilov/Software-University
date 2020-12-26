using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());
            double kec = yearTax - (yearTax * 0.4);
            double ekip = kec - (kec * 0.2);
            double ball = ekip / 4;
            double exs = ball / 5;
            double finalSum = kec + ekip + ball + exs + yearTax;

            Console.WriteLine("{0:F2}", finalSum);
        }
    }
}
