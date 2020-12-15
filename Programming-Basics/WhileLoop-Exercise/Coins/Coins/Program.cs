using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int count = 0;
            while (change > 0)
            {
                change -= change >= 2 ? 2 :
                          change >= 1 ? 1 :
                          change >= 0.50m ? 0.50m :
                          change >= 0.20m ? 0.20m :
                          change >= 0.10m ? 0.10m :
                          change >= 0.05m ? 0.05m :
                          change >= 0.02m ? 0.02m :
                          change == 0.01m ? 0.01m : 0m;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
