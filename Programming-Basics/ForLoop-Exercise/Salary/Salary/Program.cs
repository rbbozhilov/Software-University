using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());


            int facebook = 150;
            int instagram = 100;
            int Reddit = 50;
            int sum = 0;
            int zaplata = int.Parse(Console.ReadLine());


            for (int i = 0; i < numbers; i++)
            {

                string tabs = Console.ReadLine();

                switch (tabs)
                {

                    case "Facebook":
                        {
                            zaplata -= facebook;

                            break;
                        }
                    case "Instagram":
                        {
                            zaplata -= instagram;
                            break;
                        }
                    case "Reddit":
                        {
                            zaplata -= Reddit;
                            break;
                        }

                }

            }


            if (zaplata <= 0)
            {

                Console.WriteLine("You have lost your salary.");

            }
            else
            {
                Console.WriteLine(zaplata);
            }

        }
    }
}
