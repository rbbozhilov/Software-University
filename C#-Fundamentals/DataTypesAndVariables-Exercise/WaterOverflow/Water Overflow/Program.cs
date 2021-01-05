using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;

            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int helper = 0;
            for (int i = 0; i < number; i++)
            {

                int input = int.Parse(Console.ReadLine());

                if (input > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }


                sum += input;

                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= input;
                }


            }


            Console.WriteLine(sum);
        }
    }
}
