using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            int broach = 1;
            double sum = 1;
            double helper = 0;
            double sum1 = 0;
            int broach1 = 1;
            double helper1 = 0;
            double mesta = 0;
            if (3 <= h && h <= w && w <= 100)
            {

                double shirochinazala = (h * 100) - 100;

                double dulgazala = w * 100;

                while (sum1 < shirochinazala)
                {
                    sum1 = broach1 * 70;
                    helper1 = (broach1 + 1) * 70;
                    if (helper1 > shirochinazala)
                    {
                        break;
                    }
                    broach1++;

                }


                while (sum < dulgazala)
                {
                    sum = broach * 120;
                    helper = (broach + 1) * 120;
                    if (helper > dulgazala)
                    {
                        break;
                    }
                    broach++;

                }





                mesta = (broach1 * broach) - 3;

                Console.WriteLine("{0}", mesta);
            }
        }
    }
}
