using System;

namespace Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string text = null;
            int counterwin = 0;
            int counterlose = 0;
            double moneyWin = 0;
            int counterdaywin = 0;
            int counterdaylose = 0;
            double helper = 0;
            double helper2 = 0;
            double money = 0;
            double helper3 = 0;
            double helper4 = 0;
            for (int i = 0; i < days; i++)
            {


                while ((text = Console.ReadLine()) != "Finish")
                {

                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        moneyWin += 20;
                        counterwin++;
                        money += 20;
                    }
                    else if (result == "lose")
                    {
                        counterlose++;
                    }




                }

                if (counterwin > counterlose)
                {
                    helper = moneyWin + (moneyWin * 0.1);
                    helper2 += helper;
                    helper3 = money + (money * 0.1);
                    helper4 += helper3;
                    counterdaywin++;

                }
                else
                {
                    helper = moneyWin;
                    helper2 += helper;
                    helper3 = money;
                    helper4 += helper3;
                    counterdaylose++;
                }

                counterwin = 0;
                counterlose = 0;
                moneyWin = 0;
                money = 0;
            }

            if (counterdaywin > counterdaylose)
            {

                helper2 = helper2 + (helper2 * 0.2);

                Console.WriteLine("You won the tournament! Total raised money: {0:F2}", helper2);

            }
            else
            {
                Console.WriteLine("You lost the tournament! Total raised money: {0:F2}", helper4);
            }
        }
    }
}
