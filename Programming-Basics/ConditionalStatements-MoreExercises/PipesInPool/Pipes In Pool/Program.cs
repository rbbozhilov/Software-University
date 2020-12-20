using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            double obem = double.Parse(Console.ReadLine());
            double purvatraba = double.Parse(Console.ReadLine());
            double vtoratraba = double.Parse(Console.ReadLine());
            double chasove = double.Parse(Console.ReadLine());


            double litrapulni = (purvatraba * chasove) + (vtoratraba * chasove);

            double procentzapulnenbasein = (litrapulni / obem) * 100;
            double sumatrabi = (purvatraba * chasove) + (vtoratraba * chasove);
            double procentpurvatraba = (purvatraba * chasove) / sumatrabi * 100;
            double procentvtoratraba = (vtoratraba * chasove) / sumatrabi * 100;


            if (obem >= litrapulni)
            {

                Console.WriteLine("The pool is {0:F2}% full. Pipe 1: {1:F2}%. Pipe 2: {2:F2}%.", procentzapulnenbasein, procentpurvatraba, procentvtoratraba);
            }
            else
            {
                double sumer = obem - litrapulni;
                Console.WriteLine("For {0:F2} hours the pool overflows with {1:F2} liters.", chasove, Math.Abs(sumer));
            }
        }
    }
}
