using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = 0;
            string comand = null;
            double coke = 1;
            double nuts = 2;
            double soda = 0.8;
            double Water = 0.7;
            double crisps = 1.5;
            while ((comand = Console.ReadLine()) != "Start")
            {


                double inputMoney = double.Parse(comand);

                if (inputMoney == 0.1)
                {
                    totalMoney += 0.1;
                }
                else if (inputMoney == 0.2)
                {
                    totalMoney += 0.2;
                }
                else if (inputMoney == 0.5)
                {
                    totalMoney += 0.5;
                }
                else if (inputMoney == 1)
                {
                    totalMoney += 1;
                }
                else if (inputMoney == 2)
                {
                    totalMoney += 2;
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", inputMoney);
                }



            }


            string product = null;
            double helper = 0;

            while ((product = Console.ReadLine()) != "End")
            {

                if (product == "Soda")
                {
                    helper = totalMoney;

                    if (totalMoney < soda)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Purchased soda");
                        totalMoney -= 0.8;
                    }



                }
                else if (product == "Nuts")
                {

                    if (totalMoney < nuts)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    else
                    {

                        Console.WriteLine("Purchased nuts");
                        totalMoney -= 2;
                    }



                }
                else if (product == "Water")
                {

                    if (totalMoney < Water)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    else
                    {

                        Console.WriteLine("Purchased water");
                        totalMoney -= 0.7;
                    }
                }
                else if (product == "Crisps")
                {


                    if (totalMoney < crisps)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    else
                    {

                        Console.WriteLine("Purchased crisps");
                        totalMoney -= 1.5;
                    }
                }
                else if (product == "Coke")
                {

                    if (totalMoney < coke)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        continue;
                    }
                    else
                    {

                        Console.WriteLine("Purchased coke");

                        totalMoney -= 1;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid product");
                }

            }

            Console.WriteLine("Change: {0:F2}", totalMoney);
        }
    }
}
