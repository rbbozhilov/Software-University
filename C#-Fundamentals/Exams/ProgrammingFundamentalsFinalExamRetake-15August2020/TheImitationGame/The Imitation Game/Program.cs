using System;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Decode")
            {

                string[] tokens = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "Move")
                {

                    int numberOfLetters = int.Parse(tokens[1]);

                    string sub = text.Substring(0, numberOfLetters);

                    text = text.Remove(0, numberOfLetters);
                    text = text.Insert(text.Length, sub);

                }

                else if (currentCommand == "Insert")
                {

                    int index = int.Parse(tokens[1]);
                    string value = tokens[2];



                    if (index >= 0 && index <= text.Length)
                    {

                        text = text.Insert(index, value);

                    }


                }

                else if (currentCommand == "ChangeAll")
                {

                    string old = tokens[1];
                    string newest = tokens[2];

                    if (text.Contains(old))
                    {
                        text = text.Replace(old, newest);
                    }

                }

            }


            Console.WriteLine("The decrypted message is: {0}", text);
        }
    }
}
