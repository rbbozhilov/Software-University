using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            const int prolet = 3000;
            const int esensummer = 4200;
            const int winter = 2600;

            int budjet = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            int ribari = int.Parse(Console.ReadLine());
            double sum = 0;

            if (ribari == 0)
            {

                if (sezon == "Spring")
                {
                    sum = budjet - prolet;

                    if (sum >= 0)
                    {

                        Console.WriteLine("Yes! You have {0:F2} leva left.", sum);
                    }
                    else
                    {
                        sum *= -1;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", sum);

                    }

                }
                else if (sezon == "Summer")
                {
                    sum = budjet - esensummer;
                    if (sum >= 0)
                    {

                        Console.WriteLine("Yes! You have {0:F2} leva left.", sum);
                    }
                    else
                    {
                        sum *= -1;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", sum);


                    }
                }
                else if (sezon == "Autumn")
                {
                    sum = budjet - esensummer;
                    if (sum >= 0)
                    {

                        Console.WriteLine("Yes! You have {0:F2} leva left.", sum);
                    }
                    else
                    {
                        sum *= -1;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", sum);


                    }
                }
                else if (sezon == "Winter")
                {
                    sum = budjet - winter;
                    if (sum >= 0)
                    {

                        Console.WriteLine("Yes! You have {0:F2} leva left.", sum);
                    }
                    else
                    {
                        sum *= -1;
                        Console.WriteLine("Not enough money! You need {0:F2} leva.", sum);


                    }
                }
            }

            else
            {

                switch (sezon)
                {

                    case "Spring":
                        {

                            sum = prolet;

                            if (ribari <= 6)
                            {
                                sum -= (sum * 0.10);
                                if (ribari % 2 == 0)
                                {
                                    sum -= (sum * 0.05);
                                }
                            }
                            else if (ribari > 6 && ribari <= 11)
                            {
                                sum -= (sum * 0.15);
                                if (ribari % 2 == 0)
                                {
                                    sum -= (sum * 0.05);
                                }
                            }
                            else if (ribari >= 12)
                            {
                                sum -= (sum * 0.25);
                                if (ribari % 2 == 0)
                                {
                                    sum -= (sum * 0.5);
                                }
                            }


                            break;
                        }

                    case "Summer":
                        {
                            sum = esensummer;

                            if (ribari <= 6)
                            {
                                sum -= (sum * 0.10);
                                if (ribari % 2 == 0)
                                {
                                    sum -= (sum * 0.5);
                                }
                            }
                            else if (ribari > 6 && ribari <= 11)
                            {
                                sum -= (sum * 0.15);
                                if (ribari % 2 == 0)
                                {
                                    sum -= (sum * 0.05);
                                }
                            }
                            else if (ribari >= 12)
                            {
                                sum -= (sum * 0.25);
                                if (ribari % 2 == 0)
                                {
                                    sum -= (sum * 0.5);
                                }
                            }

                            break;
                        }

                    case "Autumn":
                        {

                            sum = esensummer;

                            if (ribari <= 6)
                            {
                                sum -= (sum * 0.10);
                            }
                            else if (ribari > 6 && ribari <= 11)
                            {
                                sum -= (sum * 0.15);
                            }
                            else if (ribari >= 12)
                            {
                                sum -= (sum * 0.25);
                            }




                            break;
                        }

                    case "Winter":
                        {

                            sum = winter;




                            if (ribari <= 6)
                            {
                                sum -= (sum * 0.1);
                                if (ribari % 2 == 0)
                                {
                                    sum -= (sum * 0.05);
                                }
                            }
                            else if (ribari > 6 && ribari <= 11)
                            {
                                sum -= (sum * 0.15);
                                if (ribari % 2 == 0)
                                {
                                    sum -= (sum * 0.5);
                                }
                            }
                            else if (ribari >= 12)
                            {
                                sum -= (sum * 0.25);
                                if (ribari % 2 == 0)
                                {
                                    sum -= (sum * 0.5);
                                }
                            }



                            break;
                        }


                }

                double sum1 = 0;

                sum1 = budjet - sum;

                if (sum1 >= 0)
                {

                    Console.WriteLine("Yes! You have {0:F2} leva left.", sum1);
                }
                else
                {
                    sum1 *= -1;
                    Console.WriteLine("Not enough money! You need {0:F2} leva.", sum1);


                }

            }

        }
    }
}
