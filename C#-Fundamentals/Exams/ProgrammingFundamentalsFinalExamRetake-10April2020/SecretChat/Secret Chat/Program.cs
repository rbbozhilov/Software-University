using System;
using System.Linq;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Reveal")
            {

                string[] tokens = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "InsertSpace")
                {

                    int index = int.Parse(tokens[1]);

                    text = text.Insert(index, " ");


                }

                else if (currentCommand == "Reverse")
                {

                    string substring = tokens[1];

                    if (text.Contains(substring))
                    {

                        int index = text.IndexOf(substring);
                        text = text.Remove(index, substring.Length);
                        char[] chars = substring.Reverse().ToArray();
                        substring = string.Join("", chars);

                        text = text.Insert(text.Length, substring);
                    }

                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }


                }

                else if (currentCommand == "ChangeAll")
                {

                    string substring = tokens[1];
                    string replacement = tokens[2];
                    if (text.Contains(substring))
                    {
                        text = text.Replace(substring, replacement);
                    }


                }

                Console.WriteLine(text);

            }

            Console.WriteLine("You have a new text message: {0}", text);
        }
    }
}
