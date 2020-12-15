using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int etaja = int.Parse(Console.ReadLine());
            int stai = int.Parse(Console.ReadLine());
            string l = "L";
            string o = "O";
            string A = "A";
            for (int i = etaja; i >= 1; i--)
            {
                for (int j = stai; j > 0; j--)
                {

                    if (i == etaja)
                    {

                        Console.Write("{2}{0}{1}", i, stai - j, l);
                        if (j > 1)
                        {
                            Console.Write(" ");

                        }
                        continue;
                    }


                    if (i % 2 == 0)
                    {
                        Console.Write("O{0}{1}", i, stai - j);
                        if (j > 1)
                        {
                            Console.Write(" ");

                        }

                    }
                    else if (i % 2 == 1)
                    {
                        Console.Write("{2}{0}{1}", i, stai - j, A);
                        if (j > 1)
                        {
                            Console.Write(" ");

                        }
                    }


                }
                Console.WriteLine();
            }
        }
    }
}
