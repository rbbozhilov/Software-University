using System;

namespace Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Negative number!");
            }
            while (number >= 0)
            {

                number *= 2;

                Console.WriteLine("Result: {0:F2}", number);

                number = double.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Negative number!");
                }

            }
        }
    }
}
