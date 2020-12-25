using System;

namespace Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstGamer = Console.ReadLine();
            string secondGamer = Console.ReadLine();

            string text = null;

            int pointsFirstPlayer = 0;
            int pointsSecondPlayer = 0;
            string winnerName = null;
            bool flag = false;
            int winnerPoints = 0;

            while ((text = Console.ReadLine()) != "End of game")
            {

                int cardFirstPlayer = int.Parse(text);
                int cardSecondPlayer = int.Parse(Console.ReadLine());


                if (cardFirstPlayer == cardSecondPlayer)
                {
                    flag = true;
                    cardFirstPlayer = int.Parse(Console.ReadLine());
                    cardSecondPlayer = int.Parse(Console.ReadLine());


                    if (cardFirstPlayer > cardSecondPlayer)
                    {
                        winnerName = firstGamer;
                        winnerPoints = pointsFirstPlayer;
                    }
                    else
                    {
                        winnerName = secondGamer;
                        winnerPoints = pointsSecondPlayer;
                    }


                    break;

                }


                else if (cardFirstPlayer > cardSecondPlayer)
                {


                    pointsFirstPlayer += cardFirstPlayer - cardSecondPlayer;


                }


                else if (cardFirstPlayer < cardSecondPlayer)
                {

                    pointsSecondPlayer += cardSecondPlayer - cardFirstPlayer;

                }



            }


            if (flag)
            {

                Console.WriteLine("Number wars!\n{0} is winner with {1} points", winnerName, winnerPoints);


            }
            else
            {


                Console.WriteLine("{0} has {1} points\n{2} has {3} points", firstGamer, pointsFirstPlayer, secondGamer, pointsSecondPlayer);


            }
        }
    }
}
