using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            for (int i = a1; i <= a2 - 1; i++)
            {
                char letter = (char)i;

                for (int symbol2 = 1; symbol2 <= n - 1; symbol2++)
                {

                    for (int symbol3 = 1; symbol3 <= (n / 2 - 1); symbol3++)
                    {

                        if (i % 2 == 1 && (symbol2 + symbol3 + i) % 2 == 1)
                        {
                            Console.WriteLine("{0}-{1}{2}{3}", letter, symbol2, symbol3, i);
                        }

                    }

                }

            }
        }
    }
}
