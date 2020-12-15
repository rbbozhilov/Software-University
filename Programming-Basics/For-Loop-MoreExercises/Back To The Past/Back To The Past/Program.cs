using System;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int broach = 18;

            for (int i = 1800; i <= year; i++)
            {

                if (i % 2 == 0)
                {
                    budjet -= 12000;

                }

                else
                {
                    budjet -= 12000 + (50 * broach);


                }


                broach++;

            }


            if (budjet >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", budjet);
            }
            else
            {

                Console.WriteLine("He will need {0:F2} dollars to survive.", budjet * -1);
            }
        }
    }
}
