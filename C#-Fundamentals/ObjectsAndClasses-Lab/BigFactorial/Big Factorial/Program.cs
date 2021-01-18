using System;
using System.Numerics;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger factorial = 1;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {


                factorial *= i;



            }


            Console.WriteLine(factorial);
        }
    }
}
