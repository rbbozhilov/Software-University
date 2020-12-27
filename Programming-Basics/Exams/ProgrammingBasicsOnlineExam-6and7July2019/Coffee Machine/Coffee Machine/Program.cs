using System;

namespace Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int totalDrinks = int.Parse(Console.ReadLine());
            double price = 0;

            switch (drink)
            {

                case "Espresso":
                    {

                        if (sugar == "Without")
                        {
                            price = 0.90 * totalDrinks;

                            price = price - (price * 0.35);



                        }
                        else if (sugar == "Normal")
                        {
                            price = 1 * totalDrinks;
                        }
                        else if (sugar == "Extra")
                        {
                            price = 1.20 * totalDrinks;

                        }


                        if (totalDrinks >= 5)
                        {
                            price = price - (price * 0.25);
                        }

                        break;
                    }

                case "Cappuccino":
                    {
                        if (sugar == "Without")
                        {
                            price = 1 * totalDrinks;
                            price = price - (price * 0.35);
                        }
                        else if (sugar == "Normal")
                        {
                            price = 1.20 * totalDrinks;
                        }
                        else if (sugar == "Extra")
                        {
                            price = 1.60 * totalDrinks;

                        }
                        break;
                    }



                case "Tea":
                    {
                        if (sugar == "Without")
                        {
                            price = 0.50 * totalDrinks;
                            price = price - (price * 0.35);
                        }
                        else if (sugar == "Normal")
                        {
                            price = 0.60 * totalDrinks;
                        }
                        else if (sugar == "Extra")
                        {
                            price = 0.70 * totalDrinks;

                        }
                        break;
                    }


            }



            if (price > 15)
            {
                price = price - (price * 0.2);
            }


            Console.WriteLine("You bought {0} cups of {1} for {2:F2} lv.", totalDrinks, drink, price);

        }
    }
}
