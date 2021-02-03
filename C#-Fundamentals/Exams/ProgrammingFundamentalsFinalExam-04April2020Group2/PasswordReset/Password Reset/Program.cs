using System;
using System.Text;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Done")
            {

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);


                string currentCommand = tokens[0];

                if (currentCommand == "TakeOdd")
                {

                    for (int i = 0; i < password.Length; i++)
                    {

                        if (i % 2 == 1)
                        {
                            builder.Append(password[i]);
                        }


                    }

                    password = builder.ToString();

                    Console.WriteLine(password);

                }

                else if (currentCommand == "Cut")
                {

                    int index = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);


                    password = password.Remove(index, length);

                    Console.WriteLine(password);

                }

                else if (currentCommand == "Substitute")
                {

                    string subString = tokens[1];
                    string subStitute = tokens[2];

                    if (password.Contains(subString))
                    {
                        password = password.Replace(subString, subStitute);
                        Console.WriteLine(password);
                    }

                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }


                }


            }


            Console.WriteLine("Your password is: {0}", password);
        }
    }
}
