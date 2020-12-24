using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int kapacitet = int.Parse(Console.ReadLine());
            string text = null;
            int sumPeople = 0;
            int sum = 0;
            bool checker = false;
            while ((text = Console.ReadLine()) != "Movie time!")
            {

                int broiHora = int.Parse(text);
                sumPeople += broiHora;

                if (sumPeople > kapacitet)
                {
                    Console.WriteLine("The cinema is full.");
                    checker = true;
                    break;
                }


                if (broiHora % 3 == 0)
                {

                    sum += (broiHora * 5) - 5;


                }
                else
                {
                    sum += broiHora * 5;
                }
            }


            if (checker == true)
            {

                Console.WriteLine("Cinema income - {0} lv.", sum);
            }
            else
            {

                sumPeople = kapacitet - sumPeople;
                Console.WriteLine("There are {0} seats left in the cinema.\nCinema income - {1} lv.", sumPeople, sum);

            }
        }
    }
}
