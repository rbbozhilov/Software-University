using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadSet = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());


            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int specialCounter = 0;
            bool cer1 = false;
            bool cer2 = false;

            for (int i = 1; i <= lostGames; i++)
            {

                if (i % 2 == 0)
                {
                    counter1++;
                    cer1 = true;
                }

                if (i % 3 == 0)
                {
                    cer2 = true;
                    counter2++;

                }

                if (cer1 == true && cer2 == true)
                {


                    counter3++;
                    counter4++;

                    if (counter4 % 2 == 0)
                    {
                        specialCounter++;
                    }



                }


                cer1 = false;
                cer2 = false;
            }


            double totalSum = (double)(counter1 * priceHeadSet) + (double)(counter2 * priceMouse) + (double)(counter3 * priceKeyboard) + (double)(specialCounter * priceDisplay);






            Console.WriteLine("Rage expenses: {0:F2} lv.", totalSum);
        }
    }
}
