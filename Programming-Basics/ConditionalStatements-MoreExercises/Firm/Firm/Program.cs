using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neobchasove = int.Parse(Console.ReadLine());
            int dni = int.Parse(Console.ReadLine());
            int broiSlujiteli = int.Parse(Console.ReadLine());

            double sumchasove = (double)(dni - (dni * 0.1)) * 8;
            double izvunredno = (double)broiSlujiteli * 2 * dni;
            double sumobshtochasove = (int)sumchasove + izvunredno;

            if (sumobshtochasove >= neobchasove)
            {
                double sum1 = (int)sumobshtochasove - neobchasove;
                Console.WriteLine("Yes!{0} hours left.", sum1);
            }
            else
            {
                double sum1 = (int)Math.Abs(sumobshtochasove - neobchasove);
                Console.WriteLine("Not enough time!{0} hours needed.", sum1);
            }
        }
    }
}
