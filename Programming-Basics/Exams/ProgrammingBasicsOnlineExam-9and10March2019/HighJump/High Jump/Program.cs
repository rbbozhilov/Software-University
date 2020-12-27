using System;

namespace High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int wantedHeight = int.Parse(Console.ReadLine());
            int currentHeight = wantedHeight - 30;
            int counter = 0;
            bool flag = false;
            int loseHeight = 0;
            while (true)
            {


                int jumpHeigh = int.Parse(Console.ReadLine());
                counter++;

                if (jumpHeigh > currentHeight)
                {

                    currentHeight += 5;

                    flag = true;

                }

                else
                {

                    for (int i = 0; i < 2; i++)
                    {

                        jumpHeigh = int.Parse(Console.ReadLine());
                        counter++;

                        if (jumpHeigh > currentHeight)
                        {
                            currentHeight += 5;

                            flag = true;
                            break;
                        }
                        else
                        {

                            flag = false;
                            loseHeight = currentHeight;

                        }


                    }


                }


                if (!flag)
                {
                    break;
                }


                if (currentHeight > wantedHeight)
                {
                    break;
                }


            }



            if (flag)
            {


                Console.WriteLine("Tihomir succeeded, he jumped over {0}cm after {1} jumps.", wantedHeight, counter);

            }
            else
            {
                Console.WriteLine("Tihomir failed at {0}cm after {1} jumps.", loseHeight, counter);
            }
        }
    }
}
