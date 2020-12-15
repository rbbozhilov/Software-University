using System;

namespace Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int broach = 0;
            int sum = 0;


            while (broach < number)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                sum += inputNumber;


                broach++;
            }

            double average = (double)sum / number;
            Console.WriteLine("{0:F2}", average);
        }
    }
}
