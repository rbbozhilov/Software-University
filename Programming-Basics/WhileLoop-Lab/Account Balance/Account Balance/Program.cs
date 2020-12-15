using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalsum = 0;

            string a = null;
            while ((a = Console.ReadLine()) != "NoMoreMoney")
            {
                double number = double.Parse(a);

                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                totalsum += number;

                Console.WriteLine("Increase: {0:F2}", number);


            }
            Console.WriteLine("Total: {0:F2}", totalsum);
        }
    }
}
