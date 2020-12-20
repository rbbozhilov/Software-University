using System;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());

            string text = Console.ReadLine();
            int broi = int.Parse(Console.ReadLine());
         
            switch (text)
            {
                case "VIP":
                    {

                        double obshtasuma = 0;
                        obshtasuma = (double)499.99 * broi;

                        if (broi >= 1 && broi <= 4)
                        {
                            budjet = budjet - (budjet * 0.75);

                            if (obshtasuma <= budjet)
                            {
                                Console.WriteLine("Yes! You have {0:F2} leva left.", Math.Abs(obshtasuma - budjet));
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need {0:F2} leva.", (obshtasuma - budjet));
                            }
                        }

                        else if (broi >= 5 && broi <= 9)
                        {
                            budjet = budjet - (budjet * 0.6);

                            if (obshtasuma <= budjet)
                            {
                                Console.WriteLine("Yes! You have {0:F2} leva left.", Math.Abs(obshtasuma - budjet));
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need {0:F2} leva.", (obshtasuma - budjet));
                            }


                        }

                        else if (broi >= 10 && broi <= 24)
                        {
                            budjet = budjet - (budjet * 0.5);

                            if (obshtasuma <= budjet)
                            {
                                Console.WriteLine("Yes! You have {0:F2} leva left.", Math.Abs(obshtasuma - budjet));
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need {0:F2} leva.", (obshtasuma - budjet));
                            }
                        }

                        else if (broi >= 25 && broi <= 49)
                        {
                            budjet = budjet - (budjet * 0.4);

                            if (obshtasuma <= budjet)
                            {
                                Console.WriteLine("Yes! You have {0:F2} leva left.", Math.Abs(obshtasuma - budjet));
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need {0:F2} leva.", (obshtasuma - budjet));
                            }
                        }
                        else if (broi >= 50)
                        {
                            budjet = budjet - (budjet * 0.25);

                            if (obshtasuma <= budjet)
                            {
                                Console.WriteLine("Yes! You have {0:F2} leva left.", Math.Abs(obshtasuma - budjet));
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need {0:F2} leva.", (obshtasuma - budjet));
                            }
                        }
                        break;
                    }

                case "Normal":
                    {


                        double obshtasuma = 0;
                        obshtasuma = (double)249.99 * broi;

                        if (broi >= 1 && broi <= 4)
                        {
                            budjet = budjet - (budjet * 0.75);

                            if (obshtasuma <= budjet)
                            {
                                Console.WriteLine("Yes! You have {0:F2} leva left.", Math.Abs(obshtasuma - budjet));
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need {0:F2} leva.", (obshtasuma - budjet));
                            }
                        }

                        else if (broi >= 5 && broi <= 9)
                        {
                            budjet = budjet - (budjet * 0.6);

                            if (obshtasuma <= budjet)
                            {
                                Console.WriteLine("Yes! You have {0:F2} leva left.", Math.Abs(obshtasuma - budjet));
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need {0:F2} leva.", (obshtasuma - budjet));
                            }


                        }

                        else if (broi >= 10 && broi <= 24)
                        {
                            budjet = budjet - (budjet * 0.5);

                            if (obshtasuma <= budjet)
                            {
                                Console.WriteLine("Yes! You have {0:F2} leva left.", Math.Abs(obshtasuma - budjet));
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need {0:F2} leva.", (obshtasuma - budjet));
                            }
                        }

                        else if (broi >= 25 && broi <= 49)
                        {
                            budjet = budjet - (budjet * 0.4);

                            if (obshtasuma <= budjet)
                            {
                                Console.WriteLine("Yes! You have {0:F2} leva left.", Math.Abs(obshtasuma - budjet));
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need {0:F2} leva.", (obshtasuma - budjet));
                            }
                        }
                        else if (broi >= 50)
                        {
                            budjet = budjet - (budjet * 0.25);

                            if (obshtasuma <= budjet)
                            {
                                Console.WriteLine("Yes! You have {0:F2} leva left.", Math.Abs(obshtasuma - budjet));
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need {0:F2} leva.", (obshtasuma - budjet));
                            }
                        }






                        break;
                    }

            }
        }
    }
}
