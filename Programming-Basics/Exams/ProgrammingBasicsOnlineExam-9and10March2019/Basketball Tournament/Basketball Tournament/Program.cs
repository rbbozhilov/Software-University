using System;

namespace Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = null;
            double counterWin = 0;
            double counterLose = 0;
            double percentWin = 0;
            double percentLose = 0;
            int losepoints = 0;
            double countmatches = 0;

            while ((text = Console.ReadLine()) != "End of tournaments")
            {


                int matches = int.Parse(Console.ReadLine());
                countmatches += matches;

                for (int i = 0; i < matches; i++)
                {


                    int pointsDesi = int.Parse(Console.ReadLine());
                    int pointsOtherTeam = int.Parse(Console.ReadLine());


                    if (pointsDesi > pointsOtherTeam)
                    {
                        Console.WriteLine("Game {0} of tournament {1}: win with {2} points.", i + 1, text, pointsDesi - pointsOtherTeam);
                        counterWin++;
                    }
                    else if (pointsDesi < pointsOtherTeam)
                    {
                        Console.WriteLine("Game {0} of tournament {1}: lost with {2} points.", i + 1, text, pointsOtherTeam - pointsDesi);
                        counterLose++;
                    }


                }


            }


            percentWin = (counterWin / countmatches * 100);
            percentLose = (counterLose / countmatches * 100);

            Console.WriteLine("{0:F2}% matches win\n{1:F2}% matches lost", percentWin, percentLose);

        }
    }
}
