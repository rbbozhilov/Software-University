using System;

namespace Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());
            double average = 0;
            double maxReiting = double.MinValue;
            double minReiting = double.MaxValue;
            string hightReiting = null;
            string lowerReiting = null;

            for (int i = 0; i < movies; i++)
            {

                string name = Console.ReadLine();
                double reiting = double.Parse(Console.ReadLine());



                if (reiting > maxReiting)
                {
                    maxReiting = reiting;
                    hightReiting = name;
                }


                if (reiting < minReiting)
                {
                    minReiting = reiting;
                    lowerReiting = name;
                }

                average += reiting;

            }

            average = average / (double)movies;


            Console.WriteLine("{0} is with highest rating: {1:F1}\n{2} is with lowest rating: {3:F1}\nAverage rating: {4:F1}", hightReiting, maxReiting, lowerReiting, minReiting, average);
        }
    }
}
