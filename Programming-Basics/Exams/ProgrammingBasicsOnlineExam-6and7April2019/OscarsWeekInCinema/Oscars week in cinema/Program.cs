using System;

namespace Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameMovie = Console.ReadLine();
            string typeHall = Console.ReadLine();
            int soledTickets = int.Parse(Console.ReadLine());

            double price = 0;

            switch (nameMovie)
            {

                case "A Star Is Born":
                    {

                        if (typeHall == "normal")
                        {
                            price = 7.50;

                        }


                        else if (typeHall == "luxury")
                        {
                            price = 10.50;

                        }
                        else if (typeHall == "ultra luxury")
                        {
                            price = 13.50;

                        }

                        break;
                    }





                case "Bohemian Rhapsody":
                    {
                        if (typeHall == "normal")
                        {
                            price = 7.35;

                        }


                        else if (typeHall == "luxury")
                        {
                            price = 9.45;

                        }
                        else if (typeHall == "ultra luxury")
                        {
                            price = 12.75;

                        }

                        break;
                    }

                case "Green Book":
                    {

                        if (typeHall == "normal")
                        {
                            price = 8.15;

                        }


                        else if (typeHall == "luxury")
                        {
                            price = 10.25;

                        }
                        else if (typeHall == "ultra luxury")
                        {
                            price = 13.25;

                        }

                        break;
                    }

                case "The Favourite":
                    {
                        if (typeHall == "normal")
                        {
                            price = 8.75;

                        }


                        else if (typeHall == "luxury")
                        {
                            price = 11.55;

                        }
                        else if (typeHall == "ultra luxury")
                        {
                            price = 13.95;

                        }

                        break;
                    }

            }


            double finalPrice = price * (double)soledTickets;


            Console.WriteLine("{1} -> {0:F2} lv.", finalPrice, nameMovie);
        }
    }
}
