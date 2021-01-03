using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string day = Console.ReadLine();
            double cena = 0;

            switch (typeOfPeople)
            {

                case "Students":
                    {
                        if (day == "Friday")
                        {

                            cena = 8.45;

                        }

                        else if (day == "Saturday")
                        {

                            cena = 9.80;

                        }

                        else if (day == "Sunday")
                        {

                            cena = 10.46;

                        }

                        cena *= people;

                        if (people >= 30)
                        {
                            cena = cena - (cena * 0.15);
                        }

                        break;
                    }

                case "Business":
                    {


                        if (day == "Friday")
                        {

                            cena = 10.90;

                        }

                        else if (day == "Saturday")
                        {

                            cena = 15.60;

                        }

                        else if (day == "Sunday")
                        {

                            cena = 16;

                        }

                        if (people >= 100)
                        {
                            people = people - 10;
                            cena *= people;

                        }
                        else
                        {
                            cena *= people;
                        }



                        break;
                    }
                case "Regular":
                    {


                        if (day == "Friday")
                        {

                            cena = 15;


                        }

                        else if (day == "Saturday")
                        {

                            cena = 20;

                        }

                        else if (day == "Sunday")
                        {

                            cena = 22.50;

                        }

                        cena *= people;

                        if (people >= 10 && people <= 20)
                        {
                            cena = cena - (cena * 0.05);
                        }

                        break;
                    }
            }
            Console.WriteLine("Total price: {0:F2}", cena);
        }
    }
}
