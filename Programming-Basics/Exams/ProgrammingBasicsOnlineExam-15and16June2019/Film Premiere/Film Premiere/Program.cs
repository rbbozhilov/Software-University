using System;

namespace Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string packet = Console.ReadLine();
            int broiTickets = int.Parse(Console.ReadLine());
            double cena = 0;



            switch (packet)
            {

                case "Drink":
                    {

                        if (name == "John Wick")
                        {

                            cena = 12 * broiTickets;

                        }
                        else if (name == "Star Wars")
                        {

                            cena = 18 * broiTickets;
                            if (broiTickets >= 4)
                            {

                                cena = cena - (cena * 0.3);

                            }
                        }

                        else if (name == "Jumanji")
                        {


                            cena = 9 * broiTickets;

                            if (broiTickets == 2)
                            {
                                cena = cena - (cena * 0.15);
                            }

                        }


                        break;
                    }

                case "Popcorn":
                    {

                        if (name == "John Wick")
                        {

                            cena = 15 * broiTickets;

                        }
                        else if (name == "Star Wars")
                        {

                            cena = 25 * broiTickets;
                            if (broiTickets >= 4)
                            {

                                cena = cena - (cena * 0.3);

                            }
                        }

                        else if (name == "Jumanji")
                        {


                            cena = 11 * broiTickets;

                            if (broiTickets == 2)
                            {
                                cena = cena - (cena * 0.15);
                            }

                        }

                        break;



                    }


                case "Menu":
                    {



                        if (name == "John Wick")
                        {

                            cena = 19 * broiTickets;

                        }
                        else if (name == "Star Wars")
                        {

                            cena = 30 * broiTickets;
                            if (broiTickets >= 4)
                            {

                                cena = cena - (cena * 0.3);

                            }
                        }

                        else if (name == "Jumanji")
                        {


                            cena = 14 * broiTickets;

                            if (broiTickets == 2)
                            {
                                cena = cena - (cena * 0.15);
                            }

                        }

                        break;
                    }


            }


            Console.WriteLine("Your bill is {0:F2} leva.", cena);
        }
    }
}
