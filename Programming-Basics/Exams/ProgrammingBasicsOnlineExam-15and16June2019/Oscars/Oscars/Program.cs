using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double tochkiotakademia = double.Parse(Console.ReadLine());
            int broi = int.Parse(Console.ReadLine());
            double sum = tochkiotakademia;
            double tochki = 0;

            for (int i = 0; i < broi; i++)
            {


                string nameocen = Console.ReadLine();

                double ocenka = double.Parse(Console.ReadLine());

                int length = nameocen.Length;


                tochki = (double)length * ocenka / 2;
                sum += tochki;


                if (sum > 1250.50)
                {
                    break;
                }


            }


            if (sum >= 1250.50)
            {
                Console.WriteLine("Congratulations, {0} got a nominee for leading role with {1:F1}!", name, sum);
            }
            else
            {
                Console.WriteLine("Sorry, {0} you need {1:F1} more!", name, 1250.50 - sum);
            }
        }
    }
}
