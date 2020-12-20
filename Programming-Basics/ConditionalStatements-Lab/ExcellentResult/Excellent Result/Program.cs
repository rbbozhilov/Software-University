using System;

namespace Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            float ocenka = float.Parse(Console.ReadLine());

            if (ocenka >= 2 && ocenka <= 6)
            {
                if (ocenka >= 5.50)
                {
                    Console.WriteLine("Excellent!");
                }
            }

        }
    }
}
