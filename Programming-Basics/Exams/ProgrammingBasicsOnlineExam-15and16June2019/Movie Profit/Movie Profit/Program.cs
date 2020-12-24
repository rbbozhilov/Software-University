using System;

namespace Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double priceticket = double.Parse(Console.ReadLine());
            int procentKino = int.Parse(Console.ReadLine());


            double cenaDen = priceticket * tickets;

            double prihod = cenaDen * days;

            double izprocent = (double)prihod * procentKino / 100;
            double finalResult = prihod - izprocent;

            Console.WriteLine("The profit from the movie {0} is {1:F2} lv.", name, finalResult);
        }
    }
}
