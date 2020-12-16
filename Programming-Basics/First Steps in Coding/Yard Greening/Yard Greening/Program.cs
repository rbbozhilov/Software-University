using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double real = Double.Parse(Console.ReadLine());

            if (real >= 0 && real <= 10000)
            {
                double all;
                double other;
                double discount;
                all = real * 7.61;
                discount = all * 0.18;
                all -= discount;

                Console.WriteLine("The final price is:" + all + " lv.\nThe discount is: " + discount + " lv.");
            }
        }
    }
}
