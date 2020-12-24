using System;

namespace Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());



            string text = null;


            while ((text = Console.ReadLine()) != "ACTION")
            {

                int length = text.Length;


                if (length <= 15)
                {

                    double zaplata = double.Parse(Console.ReadLine());
                    budjet = budjet - zaplata;

                }
                else
                {

                    budjet = budjet - (budjet * 0.2);


                }

                if (budjet <= 0)
                {
                    break;
                }

            }


            if (budjet < 0)
            {
                Console.WriteLine("We need {0:F2} leva for our actors.", budjet * -1);
            }
            else
            {
                Console.WriteLine("We are left with {0:F2} leva.", budjet);
            }
        }
    }
}
