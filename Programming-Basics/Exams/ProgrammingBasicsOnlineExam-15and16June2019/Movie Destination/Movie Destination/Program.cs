using System;

namespace Movie_Destination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());

            string destinacia = Console.ReadLine();

            string season = Console.ReadLine();
            int dni = int.Parse(Console.ReadLine());
            double cena = 0;


            switch (season)
            {

                case "Winter":
                    {

                        if (destinacia == "Dubai")
                        {

                            cena = dni * 45000;

                            cena = cena - (cena * 0.3);

                        }
                        else if (destinacia == "Sofia")
                        {
                            cena = dni * 17000;
                            cena = cena + (cena * 0.25);


                        }
                        else if (destinacia == "London")
                        {
                            cena = dni * 24000;
                        }

                        break;
                    }


                case "Summer":
                    {
                        if (destinacia == "Dubai")
                        {

                            cena = dni * 40000;

                            cena = cena - (cena * 0.3);

                        }
                        else if (destinacia == "Sofia")
                        {
                            cena = dni * 12500;
                            cena = cena + (cena * 0.25);


                        }
                        else if (destinacia == "London")
                        {
                            cena = dni * 20250;
                        }

                        break;
                    }
            }




            if (budjet >= cena)
            {
                Console.WriteLine("The budget for the movie is enough! We have {0:F2} leva left!", budjet - cena);
            }
            else
            {
                Console.WriteLine("The director needs {0:F2} leva more!", Math.Abs(budjet - cena));
            }
        }
    }
}
