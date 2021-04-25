using BorderControl;
using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            List<Checker> list = new List<Checker>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string currentCommand = tokens[0];

                if (currentCommand == "Citizen")
                {
                    Checker current = new Citizener(tokens[1], tokens[2], tokens[3], tokens[4]);
                    list.Add(current);
                }
                else if (currentCommand == "Robot")
                {
                    Checker current = new Robot(tokens[1], tokens[2]);
                    list.Add(current);
                }
                else if (currentCommand == "Pet")
                {
                    Checker current = new Pet(tokens[1], tokens[2]);
                    list.Add(current);
                }

            }

            string currentInput = Console.ReadLine();

            List<string> valide = new List<string>();

            foreach (var items in list)
            {
                if(items.Birthdate==null)
                {
                    continue;
                }

                if (items.Validation(items.Birthdate, currentInput) != "false")
                {
                    valide.Add(items.Birthdate);
                }

            }

            foreach (var items in valide)
            {
                Console.WriteLine(items);
            }

        }
    }
}
