using System;

namespace Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string packet = Console.ReadLine();
            string otstupka = Console.ReadLine();
            int dni = int.Parse(Console.ReadLine());
            double cena = 0;
            double obshto = 0;
            if (dni < 1)
            {
                Console.WriteLine("Days must be positive number!");
                System.Environment.Exit(1);
            }


            if ((packet == "noEquipment" || packet == "withEquipment" || packet == "noBreakfast" || packet == "withBreakfast") && (town == "Bansko" || town == "Borovets" || town == "Varna" || town == "Burgas"))
            {


                switch (town)
                {

                    case "Bansko":
                        {

                            if (packet == "noEquipment")
                            {

                                cena = 80;

                                if (otstupka == "yes")
                                {
                                    cena = cena - (cena * 0.05);
                                }




                            }
                            else if (packet == "withEquipment")
                            {
                                cena = 100;

                                if (otstupka == "yes")
                                {
                                    cena = cena - (cena * 0.1);


                                }


                            }

                            if (dni > 7)
                            {
                                dni--;
                            }

                            obshto = cena * dni;



                            break;
                        }

                    case "Borovets":
                        {

                            if (packet == "noEquipment")
                            {

                                cena = 80;

                                if (otstupka == "yes")
                                {
                                    cena = cena - (cena * 0.05);
                                }




                            }
                            else if (packet == "withEquipment")
                            {
                                cena = 100;

                                if (otstupka == "yes")
                                {
                                    cena = cena - (cena * 0.1);


                                }


                            }

                            if (dni > 7)
                            {
                                dni--;
                            }

                            obshto = cena * dni;



                            break;
                        }


                    case "Varna":
                        {

                            if (packet == "withBreakfast")
                            {

                                cena = 130;

                                if (otstupka == "yes")
                                {
                                    cena = cena - (cena * 0.12);
                                }




                            }
                            else if (packet == "noBreakfast")
                            {
                                cena = 100;

                                if (otstupka == "yes")
                                {
                                    cena = cena - (cena * 0.07);


                                }


                            }

                            if (dni > 7)
                            {
                                dni--;
                            }

                            obshto = cena * dni;



                            break;
                        }

                    case "Burgas":
                        {

                            if (packet == "withBreakfast")
                            {

                                cena = 130;

                                if (otstupka == "yes")
                                {
                                    cena = cena - (cena * 0.12);
                                }




                            }
                            else if (packet == "noBreakfast")
                            {
                                cena = 100;

                                if (otstupka == "yes")
                                {
                                    cena = cena - (cena * 0.07);


                                }


                            }

                            if (dni > 7)
                            {
                                dni--;
                            }

                            obshto = cena * dni;



                            break;
                        }

                }

                Console.WriteLine("The price is {0:F2}lv! Have a nice time!", obshto);

            }

            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
