using System;

namespace Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double episodeTime = double.Parse(Console.ReadLine());

            double produljitelnost = episodeTime + (episodeTime * 0.2);
            double produljitelnostSpecialno = seasons * 10;

            double finalResult = episodes * produljitelnost * seasons + produljitelnostSpecialno;


            Console.WriteLine("Total time needed to watch the {0} series is {1} minutes.", name, Math.Floor(finalResult));
        }
    }
}
