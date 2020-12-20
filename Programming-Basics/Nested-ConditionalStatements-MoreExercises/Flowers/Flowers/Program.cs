using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string praznik = Console.ReadLine();

            double cenahrizntelproletleto = 2;
            double cenaroziproletleto = 4.10;
            double cenalaletaproletleto = 2.50;

            double cenahrizntelzimaesen = 3.75;
            double cenarozizimaesen = 4.50;
            double cenalaletazimaesen = 4.15;


            switch (praznik)
            {
                case "Y":
                    {

                        if (season == "Spring")
                        {
                            double obshtacena = (double)(hrizantemi * cenahrizntelproletleto) + (rozi * cenaroziproletleto) + (laleta * cenalaletaproletleto);

                            obshtacena = obshtacena + (obshtacena * 0.15);

                            if (laleta > 7)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.05);
                            }


                            if (laleta + hrizantemi + rozi > 20)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.2);
                            }

                            Console.WriteLine("{0:F2}", obshtacena + 2.0);

                        }


                        else if (season == "Summer")
                        {

                            double obshtacena = (double)(hrizantemi * cenahrizntelproletleto) + (rozi * cenaroziproletleto) + (laleta * cenalaletaproletleto);

                            obshtacena = obshtacena + (obshtacena * 0.15);




                            if (laleta + hrizantemi + rozi > 20)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.2);
                            }

                            Console.WriteLine("{0:F2}", obshtacena + 2.0);


                        }

                        else if (season == "Autumn")
                        {
                            double obshtacena = (double)(hrizantemi * cenahrizntelzimaesen) + (rozi * cenarozizimaesen) + (laleta * cenalaletazimaesen);

                            obshtacena = obshtacena + (obshtacena * 0.15);




                            if (laleta + hrizantemi + rozi > 20)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.2);
                            }

                            Console.WriteLine("{0:F2}", obshtacena + 2.0);


                        }

                        else if (season == "Winter")
                        {
                            double obshtacena = (double)(hrizantemi * cenahrizntelzimaesen) + (rozi * cenarozizimaesen) + (laleta * cenalaletazimaesen);

                            obshtacena = obshtacena + (obshtacena * 0.15);

                            if (rozi >= 10)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.1);
                            }


                            if (laleta + hrizantemi + rozi > 20)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.2);
                            }

                            Console.WriteLine("{0:F2}", obshtacena + 2.0);
                        }



                        break;
                    }

                case "N":
                    {
                        if (season == "Spring")
                        {
                            double obshtacena = (double)(hrizantemi * cenahrizntelproletleto) + (rozi * cenaroziproletleto) + (laleta * cenalaletaproletleto);



                            if (laleta > 7)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.05);
                            }


                            if (laleta + hrizantemi + rozi > 20)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.2);
                            }

                            Console.WriteLine("{0:F2}", obshtacena + 2.0);

                        }


                        else if (season == "Summer")
                        {

                            double obshtacena = (double)(hrizantemi * cenahrizntelproletleto) + (rozi * cenaroziproletleto) + (laleta * cenalaletaproletleto);






                            if (laleta + hrizantemi + rozi > 20)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.2);
                            }

                            Console.WriteLine("{0:F2}", obshtacena + 2.0);


                        }

                        else if (season == "Autumn")
                        {
                            double obshtacena = (double)(hrizantemi * cenahrizntelzimaesen) + (rozi * cenarozizimaesen) + (laleta * cenalaletazimaesen);






                            if (laleta + hrizantemi + rozi > 20)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.2);
                            }

                            Console.WriteLine("{0:F2}", obshtacena + 2.0);


                        }

                        else if (season == "Winter")
                        {
                            double obshtacena = (double)(hrizantemi * cenahrizntelzimaesen) + (rozi * cenarozizimaesen) + (laleta * cenalaletazimaesen);



                            if (rozi >= 10)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.1);
                            }


                            if (laleta + hrizantemi + rozi > 20)
                            {
                                obshtacena = obshtacena - (obshtacena * 0.2);
                            }

                            Console.WriteLine("{0:F2}", obshtacena + 2.0);
                        }
                        break;
                    }

            }
        }
    }
}
