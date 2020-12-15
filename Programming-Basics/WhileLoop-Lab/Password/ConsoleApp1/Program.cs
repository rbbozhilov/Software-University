using System;

namespace ConsoleApp1
{
    class Program
    {
        static bool Password(string a, string b)
        {
            bool check = false;


            if (a.Length != b.Length)
            {
                check = false;


            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[i])
                    {
                        check = true;
                    }
                }

            }
            return check;
        }
        static void Main(string[] args)
        {


            string ime = Console.ReadLine();
            string parola = Console.ReadLine();

            string parolavhod = Console.ReadLine();

            if (Password(parola, parolavhod) == true)
            {

                Console.WriteLine("Welcome {0}!", ime);
            }
            else
            {
                while (Password(parola, parolavhod) != true)
                {
                    parolavhod = Console.ReadLine();


                }

                Console.WriteLine("Welcome {0}!", ime);

            }

        }
    }
}
