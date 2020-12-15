using System;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaprodajbi = int.Parse(Console.ReadLine());

            int broach = 0;
            int plashtanevbroi = 0;
            int plashtaneskarta = 0;
            int helper = 0;
            string text = null;
            int obshtasum = 0;
            int broi = 0;
            while ((text = Console.ReadLine()) != "End")
            {

                int produkt = int.Parse(text);

                if (broach % 2 == 0)
                {
                    if (produkt > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                        broach++;
                        continue;
                    }

                    plashtanevbroi += produkt;
                    broi++;
                    Console.WriteLine("Product sold!");

                }
                else if (broach % 2 == 1)
                {
                    if (produkt < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                        broach++;
                        continue;
                    }
                    plashtaneskarta += produkt;
                    helper++;


                    Console.WriteLine("Product sold!");
                }



                obshtasum = plashtaneskarta + plashtanevbroi;

                if (obshtasum >= sumaprodajbi)
                {
                    break;
                }
                broach++;
            }

            if (obshtasum >= sumaprodajbi)
            {
                double averagebroi = (double)plashtanevbroi / broi;
                double averagekarta = (double)plashtaneskarta / helper;

                Console.WriteLine("Average CS: {0:F2}\nAverage CC: {1:F2}", averagebroi, averagekarta);
            }
            else
            {

                Console.WriteLine("Failed to collect required money for charity.");

            }
        }
    }
}
