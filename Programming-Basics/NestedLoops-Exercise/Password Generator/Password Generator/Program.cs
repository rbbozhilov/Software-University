using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, L;
            n = int.Parse(Console.ReadLine());
            L = int.Parse(Console.ReadLine());


            for (int i = 1; i < n; i++)
            {
                for (int k = 1; k < n; k++)
                {
                    for (int j = 'a'; j < 'a' + L; j++)
                    {
                        for (int t = 'a'; t < 'a' + L; t++)
                        {
                            for (int d = 1; d <= n; d++)
                            {
                                if (d > i && d > k)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, k, (char)j, (char)t, d);

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
