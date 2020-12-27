using System;

namespace PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countHearthstone = 0;
            int countFornite = 0;
            int countOverwatch = 0;
            int countOther = 0;

            int soledGames = int.Parse(Console.ReadLine());


            for (int i = 0; i < soledGames; i++)
            {

                string nameGame = Console.ReadLine();

                if (nameGame == "Hearthstone")
                {
                    countHearthstone++;
                }
                else if (nameGame == "Fornite")
                {
                    countFornite++;
                }
                else if (nameGame == "Overwatch")
                {
                    countOverwatch++;
                }
                else
                {
                    countOther++;
                }



            }

            double percentOverwatch = (double)countOverwatch / (double)soledGames;
            double percentOther = (double)countOther / (double)soledGames;
            double percentFornite = (double)countFornite / (double)soledGames;
            double percentHearthStone = (double)countHearthstone / (double)soledGames;


            Console.WriteLine("Hearthstone - {0:F2}%\nFornite - {1:F2}%\nOverwatch - {2:F2}%\nOthers - {3:F2}%", percentHearthStone * 100, percentFornite * 100, percentOverwatch * 100, percentOther * 100);
        }
    }
}
