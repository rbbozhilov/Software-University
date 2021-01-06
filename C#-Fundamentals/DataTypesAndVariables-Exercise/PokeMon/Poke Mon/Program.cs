using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int k = n;
            int count = 0;
            decimal percent = 0;
            int helper = 0;



            if (m == 0 && y == 0)
            {
                Console.WriteLine("{0}\n{1}", helper, count);
            }
            else
            {
                while (true)
                {

                    n -= m;

                    if (n < m)
                    {
                        helper = n;
                        count++;
                        break;
                    }
                    percent = ((decimal)n / (decimal)k * (decimal)100);





                    if (percent == 50 && y > 0)
                    {

                        n /= y;

                        if (n < m)
                        {
                            helper = n;
                            count++;
                            break;
                        }

                    }

                    count++;
                    helper = n;
                }


                Console.WriteLine("{0}\n{1}", helper, count);
            }
        }
    }
}
