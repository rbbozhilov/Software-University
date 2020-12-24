using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int broi = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < broi; i++)
            {

                string name = Console.ReadLine();
                double cena = double.Parse(Console.ReadLine());

                if (name == "Thrones")
                {
                    cena = cena - (cena * 0.5);

                    sum += cena;

                }
                else if (name == "Lucifer")
                {
                    cena = cena - (cena * 0.4);
                    sum += cena;
                }
                else if (name == "Protector")
                {
                    cena = cena - (cena * 0.3);
                    sum += cena;
                }
                else if (name == "TotalDrama")
                {
                    cena = cena - (cena * 0.2);
                    sum += cena;
                }
                else if (name == "Area")
                {
                    cena = cena - (cena * 0.1);
                    sum += cena;
                }
                else
                {
                    sum += cena;
                }

            }


            if (budjet >= sum)
            {
                Console.WriteLine("You bought all the series and left with {0:F2} lv.", budjet - sum);
            }
            else
            {
                Console.WriteLine("You need {0:F2} lv. more to buy the series!", Math.Abs(budjet - sum));
            }

        }
    }
}
