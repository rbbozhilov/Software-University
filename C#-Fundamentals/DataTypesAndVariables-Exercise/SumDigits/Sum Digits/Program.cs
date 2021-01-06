using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());

            int sum = 0;
            while (digits != 0)
            {


                sum += digits % 10;

                digits /= 10;



            }

            Console.WriteLine(sum);

        }
    }
}
