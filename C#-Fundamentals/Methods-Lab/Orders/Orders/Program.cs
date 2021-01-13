using System;

namespace Orders
{
    class Program
    {
        static void PriceOfDrink(string drink, int number)
        {
            double price = 0;
            switch (drink)
            {

                case "coffee":
                    {
                        price = 1.50;
                        break;
                    }
                case "water":
                    {
                        price = 1;
                        break;
                    }
                case "coke":
                    {
                        price = 1.40;
                        break;
                    }
                case "snacks":
                    {
                        price = 2;
                        break;
                    }
            }

            price = price * number;

            Console.WriteLine("{0:F2}", price);

        }

        static void Main(string[] args)
        {


            string choice = Console.ReadLine();

            int number = int.Parse(Console.ReadLine());

            PriceOfDrink(choice, number);


        }
    }
}
