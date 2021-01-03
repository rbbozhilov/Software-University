using System;

namespace Login
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {

            string username = Console.ReadLine();

            string reverseUsername = Reverse(username);

            int counter = 0;

            while (true)
            {


                string input = Console.ReadLine();


                if (input == reverseUsername)
                {

                    Console.WriteLine("User {0} logged in.", username);
                    break;
                }
                else
                {

                    counter++;
                    if (counter == 4)
                    {
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");


                }

            }

            if (counter == 4)
            {
                Console.WriteLine("User {0} blocked!", username);
            }


        }
    }
}
