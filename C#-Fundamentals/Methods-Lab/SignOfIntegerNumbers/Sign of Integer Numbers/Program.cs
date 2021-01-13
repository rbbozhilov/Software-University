using System;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void PrintSign(int number)
        {


            string result = string.Empty;

            if (number > 0)
            {
                result = "The number " + number + " is positive.";
            }
            else if (number == 0)
            {
                result = "The number " + number + " is zero.";
            }
            else
            {
                result = "The number " + number + " is negative.";
            }


            Console.WriteLine(result);

        }

        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());



            PrintSign(number);

        }
    }
}
