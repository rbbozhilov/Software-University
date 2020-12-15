using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string imeprojek;
            int broistudent = 0;
            int broistandart = 0;
            int broikid = 0;
            int broistudentt = 0;
            int broistandartt = 0;
            int broikidd = 0;
            int broitickets = 0;
            double sumkid = 0;
            double sumstandard = 0;
            double sumstudent = 0;
            double sum = 0;
            double fullzala = 0;



            while ((imeprojek = Console.ReadLine()) != "Finish")
            {



                int svobodnimesta = int.Parse(Console.ReadLine());

                for (int i = 0; i < svobodnimesta; i++)
                {
                    string tip = Console.ReadLine();
                    if (tip == "kid")
                    {
                        broikid++;
                        broikidd++;
                    }
                    else if (tip == "standard")
                    {
                        broistandart++;
                        broistandartt++;
                    }
                    else if (tip == "student")
                    {
                        broistudent++;
                        broistudentt++;
                    }
                    else if (tip == "End")
                    {
                        break;
                    }



                    broitickets++;



                }




                sum = broistudent + broikid + broistandart;

                fullzala = sum / svobodnimesta * 100;

                Console.WriteLine("{0} - {1:F2}% full.", imeprojek, fullzala);

                fullzala = 0;
                sum = 0;
                broistudent = 0;
                broikid = 0;
                broistandart = 0;




            }

            if (broitickets == 0)
            {

                Console.WriteLine("Total tickets: {0}\n{1:F2}% student tickets.\n{2:F2}% standard tickets.\n{3:F2}% kids tickets.", broitickets, sumstudent, sumstandard, sumkid);
                System.Environment.Exit(1);
            }



            sumkid = (double)broikidd / broitickets * 100;
            sumstandard = (double)broistandartt / broitickets * 100;
            sumstudent = (double)broistudentt / broitickets * 100;

            Console.WriteLine("Total tickets: {0}\n{1:F2}% student tickets.\n{2:F2}% standard tickets.\n{3:F2}% kids tickets.", broitickets, sumstudent, sumstandard, sumkid);
        }
    }
}
