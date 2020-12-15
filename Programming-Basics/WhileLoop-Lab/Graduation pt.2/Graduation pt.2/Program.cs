using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int helper = 0;
            double sum = 0;
            int helper1 = 0;
            double average = 0;
            for (int i = 0; i < 12; i++)
            {
                double ocenka = double.Parse(Console.ReadLine());

                if (ocenka < 4)
                {
                    helper++;

                    if (helper == 2)
                    {
                        helper1 = i;
                        Console.WriteLine("{0} has been excluded at {1} grade", name, helper1);
                        break;

                    }
                }

                sum += ocenka;
            }

            average = sum / 12;
            if (helper < 2)
            {
                Console.WriteLine("{0} graduated. Average grade: {1:F2}", name, average);
            }
        }
    }
}
