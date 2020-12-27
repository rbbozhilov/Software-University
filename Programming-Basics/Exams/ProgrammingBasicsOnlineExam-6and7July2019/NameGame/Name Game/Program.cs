using System;

namespace Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string winnerName = string.Empty;
            int currentPoints = 0;
            int winnerPoints = int.MinValue;


            while ((name = Console.ReadLine()) != "Stop")
            {


                for (int i = 0; i < name.Length; i++)
                {

                    int number = int.Parse(Console.ReadLine());

                    if (number == (int)name[i])
                    {

                        currentPoints += 10;

                    }
                    else
                    {
                        currentPoints += 2;
                    }




                }


                if (currentPoints >= winnerPoints)
                {
                    winnerPoints = currentPoints;
                    winnerName = name;
                }

                currentPoints = 0;
            }


            Console.WriteLine("The winner is {0} with {1} points!", winnerName, winnerPoints);
        }
    }
}
