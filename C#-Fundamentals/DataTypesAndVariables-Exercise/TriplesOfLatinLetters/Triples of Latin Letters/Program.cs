using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int j = 97; j < 97 + n; j++)
            {

                for (int k = 97; k < 97 + n; k++)
                {

                    for (int g = 97; g < 97 + n; g++)
                    {

                        Console.WriteLine("{0}{1}{2}", (char)j, (char)k, (char)g);

                    }

                }


            }
        }
    }
}
