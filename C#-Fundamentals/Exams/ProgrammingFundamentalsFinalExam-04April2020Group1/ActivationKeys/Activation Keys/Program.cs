using System;

namespace Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();



            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Generate")
            {

                string[] tokens = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = tokens[0];

                if (currentCommand == "Contains")
                {

                    string sub = tokens[1];
                    if (input.Contains(sub))
                    {

                        Console.WriteLine("{0} contains {1}", input, sub);

                    }

                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }


                }

                else if (currentCommand == "Flip")
                {

                    string currentMiniCommand = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);


                    if (currentMiniCommand == "Upper")
                    {

                        input = input.Substring(0, startIndex) + input.Substring(startIndex, endIndex - startIndex).ToUpper() + input.Substring(endIndex);


                    }

                    else if (currentMiniCommand == "Lower")
                    {


                        input = input.Substring(0, startIndex) + input.Substring(startIndex, endIndex - startIndex).ToLower() + input.Substring(endIndex);

                    }

                    Console.WriteLine(input);

                }

                else if (currentCommand == "Slice")
                {

                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    input = input.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(input);


                }


            }

            Console.WriteLine("Your activation key is: {0}", input);


        }
    }
}
