using System;

namespace Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int currentLetter = 0;
            int maxPoints = 0;
            string bestMovie = null;
            int i = 0;


            for (i = 0; i < 7; i++)
            {




                string name = Console.ReadLine();
                if (name == "STOP")
                {
                    break;
                }
                int length = name.Length;

                for (int j = 0; j < name.Length; j++)
                {

                    currentLetter = (int)name[j];


                    if (currentLetter >= 65 && currentLetter <= 90)
                    {

                        sum += currentLetter - length;


                    }
                    else if (currentLetter >= 97 && currentLetter <= 122)
                    {


                        sum += currentLetter - (2 * length);


                    }
                    else
                    {
                        sum += currentLetter;
                    }





                }

                if (sum > maxPoints)
                {
                    maxPoints = sum;
                    bestMovie = name;
                }
                sum = 0;


            }

            if (i == 7)
            {

                Console.WriteLine("The limit is reached.\nThe best movie for you is {0} with {1} ASCII sum.", bestMovie, maxPoints);
            }

            else
            {
                Console.WriteLine("The best movie for you is {0} with {1} ASCII sum.", bestMovie, maxPoints);
            }
        }
    }
}
