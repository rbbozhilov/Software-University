using System;

namespace Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            int counterWin = 0;
            int counterLose = 0;
            int counterDraw = 0;


            if (games <= 0)
            {
                Console.WriteLine("{0} hasn't played any games during this season.", teamName);
            }
            else
            {

                for (int i = 0; i < games; i++)
                {

                    string result = Console.ReadLine();


                    if (result == "W")
                    {
                        counterWin++;
                    }
                    else if (result == "L")
                    {
                        counterLose++;
                    }
                    else if (result == "D")
                    {
                        counterDraw++;
                    }



                }

                int totalPoints = (counterWin * 3) + (counterDraw * 1);

                double percentWin = ((double)counterWin / (double)games) * 100.0;



                Console.WriteLine("{0} has won {1} points during this season.\nTotal stats:\n## W: {2}\n## D: {3}\n## L: {4}\nWin rate: {5:F2}%", teamName, totalPoints, counterWin, counterDraw, counterLose, percentWin);



            }
        }
    }
}
