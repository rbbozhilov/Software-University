using System;

namespace Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal inputNumber = 0;

            for (int i = 0; i < n; i++)
            {

                inputNumber += decimal.Parse(Console.ReadLine());

            }

            Console.WriteLine(inputNumber);
        }
    }
}
