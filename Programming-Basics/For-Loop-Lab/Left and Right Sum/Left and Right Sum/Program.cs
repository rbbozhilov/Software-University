using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;

            int numbers = int.Parse(Console.ReadLine());
            int delenie = 0;
            int numbers2 = numbers * 2;
            delenie = numbers2 / 2;

            for (int i = 0; i < delenie; i++)
            {

                sum1 += numbers = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < delenie; i++)
            {

                sum2 += numbers = int.Parse(Console.ReadLine());
            }

            if (sum1 != sum2)
            {
                if (sum1 > sum2)
                {
                    sum1 -= sum2;
                    Console.WriteLine("No, diff = {0}", sum1);
                }
                else
                {
                    sum2 -= sum1;
                    Console.WriteLine("No, diff = {0}", sum2);
                }

            }
            else
            {

                Console.WriteLine("Yes, sum = {0}", sum1);

            }
        }
    }
}
