using System;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalSum = 0;

            while (true)
            {

                if (command == "special" || command == "regular")
                {
                    break;
                }

                double currentPrice = double.Parse(command);

                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;

                }
                totalSum += currentPrice;

                command = Console.ReadLine();
            }

            if (totalSum == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                double finalPrice = totalSum;
                finalPrice += finalPrice * 0.2;
                double taxes = totalSum * 0.2;

                if (command == "special")
                {
                    finalPrice -= finalPrice * 0.1;
                }

                Console.WriteLine("Congratulations you've just bought a new computer!\nPrice without taxes: {0:F2}$\nTaxes: {1:F2}$\n-----------\nTotal price: {2:F2}$", totalSum, taxes, finalPrice);

            }

        }
    }
}
