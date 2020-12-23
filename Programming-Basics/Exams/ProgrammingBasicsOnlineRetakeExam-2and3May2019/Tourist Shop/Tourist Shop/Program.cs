using System;

namespace Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterProducts = 0;

            double budjet = double.Parse(Console.ReadLine());

            string text = string.Empty;
            bool flag = false;
            double sum = 0;

            while ((text = Console.ReadLine()) != "Stop")
            {

                double price = double.Parse(Console.ReadLine());

                counterProducts++;


                if (counterProducts % 3 == 0)
                {

                    price = price / 2.0;


                    sum += price;
                    budjet -= price;


                }
                else
                {
                    sum += price;
                    budjet -= price;
                }



                if (budjet < 0)
                {

                    flag = true;




                    break;


                }

            }


            if (flag)
            {

                Console.WriteLine("You don't have enough money!\nYou need {0:F2} leva!", Math.Abs(budjet));

            }
            else
            {
                Console.WriteLine("You bought {0} products for {1:F2} leva.", counterProducts, sum);
            }

        }
    }
}
