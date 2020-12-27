using System;

namespace Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double winPrice = double.Parse(Console.ReadLine());

            string name = string.Empty;
            double sum = 0;
            double currentPrice = 0;
            bool flag = false;
            while ((name = Console.ReadLine()) != "Party!")
            {

                int cockteils = int.Parse(Console.ReadLine());

                currentPrice = name.Length * cockteils;

                if (currentPrice % 2 == 1)
                {
                    currentPrice = currentPrice - (currentPrice * 0.25);

                }

                sum += currentPrice;

                currentPrice = 0;

                if (sum >= winPrice)
                {
                    flag = true;
                    break;


                }


            }

            if (flag)
            {
                Console.WriteLine("Target acquired.\nClub income - {0:F2} leva.", sum);
            }
            else
            {
                Console.WriteLine("We need {0:F2} leva more.\nClub income - {1:F2} leva.", winPrice - sum, sum);
            }
        }
    }
}
