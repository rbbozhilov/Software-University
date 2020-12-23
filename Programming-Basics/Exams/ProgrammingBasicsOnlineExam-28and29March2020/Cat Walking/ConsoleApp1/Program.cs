using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int broirazhodki = int.Parse(Console.ReadLine());
            int kalorii = int.Parse(Console.ReadLine());


            double broiminuti = min * broirazhodki;
            double obshtoizgorenkalorii = broiminuti * 5;
            double izgorenikalorii = kalorii * 0.5;

            if (obshtoizgorenkalorii >= izgorenikalorii)
            {
                Console.WriteLine("Yes, the walk for your cat is enough. Burned calories per day: {0}.", obshtoizgorenkalorii);

            }
            else
            {
                Console.WriteLine("No, the walk for your cat is not enough. Burned calories per day: {0}.", obshtoizgorenkalorii);
            }
        }
    }
}
