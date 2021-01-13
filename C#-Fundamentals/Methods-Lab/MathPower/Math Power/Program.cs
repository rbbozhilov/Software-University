using System;

namespace Math_Power
{
    class Program
    {
        static double MathPower(double number, int power)
        {

            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;


        }


        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(number, power));


        }
    }
}
