using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordConcored = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double vreme = double.Parse(Console.ReadLine());

            double timeDistance = vreme * distance;
            double late = Math.Floor(distance / 15) * 12.5;
            double fulltime = timeDistance + late;

            if (fulltime < recordConcored)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", fulltime);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", fulltime - recordConcored);

            }
        }
    }
}
