using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameMovie = null;
            double percentFullHall = 0;
            int totalTickets = 0;
            double percentStudent = 0;
            double percentStandard = 0;
            double percentKid = 0;
            int counter = 0;


            while ((nameMovie = Console.ReadLine()) != "Finish")
            {

                int places = int.Parse(Console.ReadLine());


                for (int i = 0; i < places; i++)
                {


                    string typeTicket = Console.ReadLine();
                    if (typeTicket == "End")
                    {
                        break;
                    }

                    else if (typeTicket == "standard")
                    {
                        percentStandard++;
                    }
                    else if (typeTicket == "student")
                    {
                        percentStudent++;
                    }
                    else if (typeTicket == "kid")
                    {
                        percentKid++;
                    }
                    totalTickets++;


                    counter++;

                }

                percentFullHall = (double)counter / (double)places * 100.0;

                Console.WriteLine("{0} - {1:F2}% full.", nameMovie, percentFullHall);


                percentFullHall = 0;
                counter = 0;

            }


            percentStudent = percentStudent / (double)totalTickets * 100.0;
            percentStandard = percentStandard / (double)totalTickets * 100.0;
            percentKid = percentKid / (double)totalTickets * 100.0;

            Console.WriteLine("Total tickets: {0}\n{1:F2}% student tickets.\n{2:F2}% standard tickets.\n{3:F2}% kids tickets.", totalTickets, percentStudent, percentStandard, percentKid);

        }
    }
}
