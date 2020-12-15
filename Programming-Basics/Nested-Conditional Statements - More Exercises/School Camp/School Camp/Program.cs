using System;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string gender = Console.ReadLine();
            int uchenici = int.Parse(Console.ReadLine());
            int noshtuvki = int.Parse(Console.ReadLine());

            switch (season)
            {

                case "Spring":
                    {

                        if (gender == "girls")
                        {

                            double cena = (double)noshtuvki * 7.20 * uchenici;

                            if (uchenici >= 10 && uchenici < 20)
                            {
                                cena = cena - (cena * 0.05);
                            }
                            else if (uchenici >= 20 && uchenici < 50)
                            {
                                cena = cena - (cena * 0.15);
                            }
                            else if (uchenici >= 50)
                            {
                                cena = cena - (cena * 0.5);
                            }


                            Console.WriteLine("Athletics {0:F2} lv.", cena);
                        }
                        else if (gender == "boys")
                        {

                            double cena = (double)noshtuvki * 7.20 * uchenici;

                            if (uchenici >= 10 && uchenici < 20)
                            {
                                cena = cena - (cena * 0.05);
                            }
                            else if (uchenici >= 20 && uchenici < 50)
                            {
                                cena = cena - (cena * 0.15);
                            }
                            else if (uchenici >= 50)
                            {
                                cena = cena - (cena * 0.5);
                            }

                            Console.WriteLine("Tennis {0:F2} lv.", cena);
                        }

                        else if (gender == "mixed")
                        {

                            double cena = (double)noshtuvki * 9.50 * uchenici;

                            if (uchenici >= 10 && uchenici < 20)
                            {
                                cena = cena - (cena * 0.05);
                            }
                            else if (uchenici >= 20 && uchenici < 50)
                            {
                                cena = cena - (cena * 0.15);
                            }
                            else if (uchenici >= 50)
                            {
                                cena = cena - (cena * 0.5);
                            }




                            Console.WriteLine("Cycling {0:F2} lv.", cena);
                        }

                        break;
                    }

                case "Summer":
                    {


                        if (gender == "girls")
                        {

                            double cena = (double)noshtuvki * 15 * uchenici;

                            if (uchenici >= 10 && uchenici < 20)
                            {
                                cena = cena - (cena * 0.05);
                            }
                            else if (uchenici >= 20 && uchenici < 50)
                            {
                                cena = cena - (cena * 0.15);
                            }
                            else if (uchenici >= 50)
                            {
                                cena = cena - (cena * 0.5);
                            }


                            Console.WriteLine("Volleyball {0:F2} lv.", cena);
                        }
                        else if (gender == "boys")
                        {

                            double cena = (double)noshtuvki * 15 * uchenici;

                            if (uchenici >= 10 && uchenici < 20)
                            {
                                cena = cena - (cena * 0.05);
                            }
                            else if (uchenici >= 20 && uchenici < 50)
                            {
                                cena = cena - (cena * 0.15);
                            }
                            else if (uchenici >= 50)
                            {
                                cena = cena - (cena * 0.5);
                            }

                            Console.WriteLine("Football {0:F2} lv.", cena);
                        }

                        else if (gender == "mixed")
                        {

                            double cena = (double)noshtuvki * 20 * uchenici;

                            if (uchenici >= 10 && uchenici < 20)
                            {
                                cena = cena - (cena * 0.05);
                            }
                            else if (uchenici >= 20 && uchenici < 50)
                            {
                                cena = cena - (cena * 0.15);
                            }
                            else if (uchenici >= 50)
                            {
                                cena = cena - (cena * 0.5);
                            }




                            Console.WriteLine("Swimming {0:F2} lv.", cena);
                        }

                        break;
                    }


                case "Winter":
                    {

                        if (gender == "girls")
                        {

                            double cena = (double)noshtuvki * 9.60 * uchenici;

                            if (uchenici >= 10 && uchenici < 20)
                            {
                                cena = cena - (cena * 0.05);
                            }
                            else if (uchenici >= 20 && uchenici < 50)
                            {
                                cena = cena - (cena * 0.15);
                            }
                            else if (uchenici >= 50)
                            {
                                cena = cena - (cena * 0.5);
                            }


                            Console.WriteLine("Gymnastics {0:F2} lv.", cena);
                        }
                        else if (gender == "boys")
                        {

                            double cena = (double)noshtuvki * 9.60 * uchenici;

                            if (uchenici >= 10 && uchenici < 20)
                            {
                                cena = cena - (cena * 0.05);
                            }
                            else if (uchenici >= 20 && uchenici < 50)
                            {
                                cena = cena - (cena * 0.15);
                            }
                            else if (uchenici >= 50)
                            {
                                cena = cena - (cena * 0.5);
                            }

                            Console.WriteLine("Judo {0:F2} lv.", cena);
                        }

                        else if (gender == "mixed")
                        {

                            double cena = (double)noshtuvki * 10 * uchenici;

                            if (uchenici >= 10 && uchenici < 20)
                            {
                                cena = cena - (cena * 0.05);
                            }
                            else if (uchenici >= 20 && uchenici < 50)
                            {
                                cena = cena - (cena * 0.15);
                            }
                            else if (uchenici >= 50)
                            {
                                cena = cena - (cena * 0.5);
                            }




                            Console.WriteLine("Ski {0:F2} lv.", cena);
                        }


                        break;
                    }


            }
        }
    }
}
