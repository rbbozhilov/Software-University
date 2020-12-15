using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int broibutilki = int.Parse(Console.ReadLine());
            int kolichestvopreparat = broibutilki * 750;
            int broach = 1;
            int broichinii = 0;
            int broitendjeri = 0;
            int sumchinii = kolichestvopreparat;
            string text = null;
            int helper = 3;
            int sumtendjera = 0;
            int sum = kolichestvopreparat;
            while ((text = Console.ReadLine()) != "End")
            {


                int number = int.Parse(text);

                if (broach == helper)
                {

                    sumtendjera = number * 15;
                    helper *= 2;
                    broitendjeri += number;
                    sum -= sumtendjera;
                }

                else
                {
                    sumchinii = number * 5;
                    broichinii += number;
                    sum -= sumchinii;
                }

                if (sum < 0)
                {
                    break;
                }

                broach++;
            }


            if (sum >= 0)
            {
                Console.WriteLine("Detergent was enough!\n{0} dishes and {1} pots were washed.\nLeftover detergent {2} ml.", broichinii, broitendjeri, sum);
            }
            else
            {
                Console.WriteLine("Not enough detergent, {0} ml. more necessary!", Math.Abs(sum));
            }
        }
    }
}
