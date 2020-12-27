using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int counterWon = 0;
            double average = 0;
            double percent = 0;

            for (int i = 0; i < tournaments; i++)
            {

                string etap = Console.ReadLine();


                if (etap == "W")
                {
                    counterWon++;

                    startPoints += 2000;
                    average += 2000;

                }
                else if (etap == "F")
                {
                    startPoints += 1200;
                    average += 1200;
                }
                else if (etap == "SF")
                {
                    startPoints += 720;
                    average += 720;
                }


            }


            average = Math.Floor((double)average / tournaments);

            percent = (double)counterWon / tournaments * 100;


            Console.WriteLine("Final points: {0}\nAverage points: {1}\n{2:F2}%", startPoints, average, percent);
        }
    }
}
