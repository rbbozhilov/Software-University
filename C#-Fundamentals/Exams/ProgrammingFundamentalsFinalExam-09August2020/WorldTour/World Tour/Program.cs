using System;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Travel")
            {

                string[] tokens = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string currentCommand = tokens[0];

                if (currentCommand == "Add Stop")
                {

                    int index = int.Parse(tokens[1]);
                    string stringer = tokens[2];

                    if (index >= 0 && index < text.Length)
                    {
                        text = text.Insert(index, stringer);
                    }


                }

                else if (currentCommand == "Remove Stop")
                {

                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (startIndex >= 0 && startIndex < text.Length && endIndex >= 0 && endIndex < text.Length)
                    {
                        text = text.Remove(startIndex, endIndex - startIndex + 1);
                    }


                }

                else if (currentCommand == "Switch")
                {
                    string currentString = tokens[1];
                    string newString = tokens[2];

                    if (text.Contains(currentString))
                    {
                        text = text.Replace(currentString, newString);
                    }

                }

                Console.WriteLine(text);

            }

            Console.WriteLine("Ready for world tour! Planned stops: {0}", text);
        }
    }
}
