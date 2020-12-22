using System;

namespace Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordseconds = double.Parse(Console.ReadLine());
            double razmetri = double.Parse(Console.ReadLine());
            double vremesekundi = double.Parse(Console.ReadLine());


            double vreme = razmetri * vremesekundi;
            double dobavenovreme = Math.Floor((razmetri / 50)) * 30;
            double obshtovreme = vreme + dobavenovreme;


            if (recordseconds <= obshtovreme)
            {
                Console.WriteLine("No! He was {0:F2} seconds slower.", Math.Abs(recordseconds - obshtovreme));
            }
            else
            {
                Console.WriteLine("Yes! The new record is {0:F2} seconds.", obshtovreme);
            }
        }
    }
}
