using System;

namespace Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterWon = 0;
            int counterLose = 0;
            int counterDraw = 0;


            for (int i = 0; i < 3; i++)
            {


                string score = Console.ReadLine();


                int scoreFirstTeam = 0;
                string firstTeamConvert = null;

                char a = Convert.ToChar(score[0]);
                firstTeamConvert = Convert.ToString(a);

                int scoreSecondTeam = 0;
                string secondTeamConvert = null;

                char b = Convert.ToChar(score[2]);
                secondTeamConvert = Convert.ToString(b);


                bool isValueFirst = int.TryParse(firstTeamConvert, out scoreFirstTeam);

                bool isValueSecond = int.TryParse(secondTeamConvert, out scoreSecondTeam);



                if (scoreFirstTeam > scoreSecondTeam)
                {
                    counterWon++;
                }
                else if (scoreFirstTeam < scoreSecondTeam)
                {
                    counterLose++;
                }
                else if (scoreFirstTeam == scoreSecondTeam)
                {
                    counterDraw++;
                }


            }


            Console.WriteLine("Team won {0} games.\nTeam lost {1} games.\nDrawn games: {2}", counterWon, counterLose, counterDraw);

        }
    }
}
