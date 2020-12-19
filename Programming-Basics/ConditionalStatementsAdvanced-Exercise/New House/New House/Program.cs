using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string cvete = Console.ReadLine();
            int broi = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());
            double sum = 0;
            double povishen = 0;

            switch (cvete)
            {
                case "Roses":
                    {

                        sum = broi * 5;
                        if (broi > 80)
                        {
                            sum -= sum * 0.10;

                        }

                        break;
                    }

                case "Dahlias":
                    {
                        sum = broi * 3.80;

                        if (broi > 90)
                        {
                            sum -= (sum * 15 / 100);
                        }


                        break;
                    }
                case "Tulips":
                    {
                        sum = broi * 2.80;

                        if (broi > 80)
                        {
                            sum -= (sum * 15 / 100);
                        }


                        break;
                    }
                case "Narcissus":
                    {

                        sum = broi * 3;
                        if (broi < 120)
                        {
                            povishen = 3;
                            povishen += (3 * 0.15);
                            sum = povishen * broi;
                        }

                        break;
                    }
                case "Gladiolus":
                    {

                        sum = broi * 2.50;
                        if (broi < 80)
                        {
                            povishen = 2.50;
                            povishen += 2.50 * 0.2;
                            sum = povishen * broi;


                        }

                        break;
                    }
            }

            double sum1 = 0;
            sum1 = budjet - sum;

            if (sum1 >= 0)
            {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", broi, cvete, sum1);
            }
            else
            {
                sum1 *= -1;
                Console.WriteLine("Not enough money, you need {0:F2} leva more.", sum1);

            }
        }
    }
}
