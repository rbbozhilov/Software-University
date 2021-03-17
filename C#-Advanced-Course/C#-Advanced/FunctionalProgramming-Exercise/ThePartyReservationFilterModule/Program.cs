using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            List<string> filter = new List<string>();

            string input = string.Empty;
            List<string> result = new List<string>();
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] tokens = input.Split(";");

                string currentCommand = tokens[0];
                string currentOther = tokens[1];
                string currentString = tokens[2];


                if (currentCommand == "Add filter")
                {
                    result.Add($"{currentOther};{currentString}");
                }
                else if (currentCommand == "Remove filter")
                {
                    result.Remove($"{currentOther};{currentString}");
                }

            }


            foreach (var items in result)
            {

                string[] tokens = items.Split(";");

                string currentCommand = tokens[0];
                string currentString = tokens[1];


                switch (currentCommand)
                {

                    case "Starts with":
                        {

                            people = people.Where(p => !p.StartsWith(currentString)).ToArray();

                            break;
                        }
                    case "Ends with":
                        {

                            people = people.Where(p => !p.EndsWith(currentString)).ToArray();

                            break;
                        }
                    case "Length":
                        {

                            people = people.Where(p => p.Length != int.Parse(currentString)).ToArray();


                            break;
                        }
                    case "Contains":
                        {

                            people = people.Where(p => !p.Contains(currentString)).ToArray();

                            break;
                        }

                }


            }


            Console.WriteLine(string.Join(" ", people));
        }
    }
}
