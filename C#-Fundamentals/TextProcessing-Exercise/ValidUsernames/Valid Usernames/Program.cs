using System;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] tokens = input.Split(", ");

            bool flag = true;



            for (int i = 0; i < tokens.Length; i++)
            {
                flag = true;
                if (tokens[i].Length >= 3 && tokens[i].Length <= 16)
                {



                    foreach (var items in tokens[i])
                    {

                        if (!char.IsDigit(items) && !char.IsLetter(items) && !(items == 95 || items == 45))
                        {
                            flag = false;

                            break;
                        }


                    }

                    if (flag)
                    {
                        Console.WriteLine(tokens[i]);

                    }
                }

            }
        }
    }
}
