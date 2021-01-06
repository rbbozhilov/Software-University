using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int max = number;
            int worker = number;
            int total = 0;
            int counter = 0;


            if (number < 100)
            {
                Console.WriteLine("{0}\n{1}", counter, total);
            }
            else
            {
                while (true)
                {


                    if (max < 100)
                    {

                        total -= 26;
                        break;


                    }


                    worker -= 26;
                    total += worker;

                    max -= 10;

                    if (worker > max)
                    {
                        break;
                    }

                    counter++;
                    worker = max;
                }


                Console.WriteLine("{0}\n{1}", counter, total);
            }
        }
    }
}
