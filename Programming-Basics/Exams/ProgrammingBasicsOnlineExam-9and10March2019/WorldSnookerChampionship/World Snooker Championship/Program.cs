using System;

namespace World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string etap = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            string picture = Console.ReadLine();
            double Price = 0;

            switch (typeTicket)
            {

                case "Standard":
                    {

                        if (etap == "Quarter final")
                        {
                            Price = 55.50;


                        }

                        else if (etap == "Semi final")
                        {
                            Price = 75.88;
                        }
                        else if (etap == "Final")
                        {
                            Price = 110.10;
                        }


                        break;
                    }


                case "Premium":
                    {

                        if (etap == "Quarter final")
                        {
                            Price = 105.20;


                        }

                        else if (etap == "Semi final")
                        {
                            Price = 125.22;
                        }
                        else if (etap == "Final")
                        {
                            Price = 160.66;
                        }



                        break;
                    }



                case "VIP":
                    {

                        if (etap == "Quarter final")
                        {
                            Price = 118.90;


                        }

                        else if (etap == "Semi final")
                        {
                            Price = 300.40;
                        }
                        else if (etap == "Final")
                        {
                            Price = 400;
                        }



                        break;
                    }



            }


            double totalPriceTickets = tickets * Price;

            if (totalPriceTickets > 4000)
            {
                totalPriceTickets = totalPriceTickets - (totalPriceTickets * 0.25);
            }
            else if (totalPriceTickets > 2500 && totalPriceTickets <= 4000)
            {


                totalPriceTickets = totalPriceTickets - (totalPriceTickets * 0.1);


                if (picture == "Y")
                {
                    totalPriceTickets += tickets * 40;
                }

            }

            else
            {

                if (picture == "Y")
                {

                    totalPriceTickets += tickets * 40;
                }


            }



            Console.WriteLine("{0:F2}", totalPriceTickets);
        }
    }
}
