using System;

namespace Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int totalPoints = 301;
            int counterNotSuccess = 0;
            int counterSuccess = 0;

            string text = null;


            while ((text = Console.ReadLine()) != "Retire")
            {

                int points = int.Parse(Console.ReadLine());


                if (text == "Triple")
                {


                    if (totalPoints >= points * 3)
                    {
                        totalPoints -= points * 3;
                        counterSuccess++;
                    }
                    else
                    {
                        counterNotSuccess++;
                    }
                }
                else if (text == "Double")
                {

                    if (totalPoints >= points * 2)
                    {
                        totalPoints -= points * 2;
                        counterSuccess++;
                    }
                    else
                    {
                        counterNotSuccess++;
                    }

                }
                else if (text == "Single")
                {
                    if (totalPoints >= points)
                    {
                        totalPoints -= points;
                        counterSuccess++;
                    }
                    else
                    {
                        counterNotSuccess++;
                    }
                }

                if (totalPoints == 0)
                {
                    break;
                }

            }



            if (totalPoints > 0)
            {
                Console.WriteLine("{0} retired after {1} unsuccessful shots.", name, counterNotSuccess);
            }
            else
            {
                Console.WriteLine("{0} won the leg with {1} shots.", name, counterSuccess);
            }
        }
    }
}
