using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;



namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"(@(?<first>[A-Za-z]{3,})@{2}(?<second>[A-Za-z]{3,})@|#(?<firstt>[A-Za-z]{3,})#{2}(?<secondd>[A-Za-z]{3,})#)";
            Regex nameRegex = new Regex(namePattern);
            string input = Console.ReadLine();
            List<string> words = new List<string>();

            if (nameRegex.IsMatch(input))
            {

                MatchCollection matches = nameRegex.Matches(input);

                if (matches.Count > 0)
                {
                    Console.WriteLine("{0} word pairs found!", matches.Count);


                    foreach (Match items in matches)
                    {

                        char current = items.Value[0];
                        string first = string.Empty;
                        string second = string.Empty;

                        if (current == '@')
                        {

                            first = items.Groups["first"].Value;
                            second = items.Groups["second"].Value;
                            char[] arr = second.Reverse().ToArray();
                            string secondd = string.Join("", arr);

                            if (first == secondd)
                            {

                                words.Add(first);

                            }


                        }

                        else if (current == '#')
                        {
                            first = items.Groups["firstt"].Value;
                            second = items.Groups["secondd"].Value;
                            char[] arr = second.Reverse().ToArray();
                            string secondd = string.Join("", arr);
                            if (first == secondd)
                            {

                                words.Add(first);

                            }


                        }

                    }

                    if (words.Count > 0)
                    {
                        Console.WriteLine("The mirror words are:");
                        int counter = 0;

                        if (words.Count == 1)
                        {
                            foreach (var items in words)
                            {
                                char[] array = items.Reverse().ToArray();
                                string current = string.Join("", array);

                                Console.WriteLine("{0} <=> {1}", items, current);
                            }
                        }

                        else
                        {
                            foreach (var items in words)
                            {

                                if (counter == words.Count - 1)
                                {
                                    char[] arr = items.Reverse().ToArray();
                                    string reversed = string.Join("", arr);

                                    Console.WriteLine("{0} <=> {1}", items, reversed);
                                    break;
                                }

                                char[] ann = items.Reverse().ToArray();
                                string reversedd = string.Join("", ann);

                                Console.Write("{0} <=> {1}, ", items, reversedd);

                                counter++;


                            }

                        }

                    }

                    else
                    {
                        Console.WriteLine("No mirror words!");
                    }

                }


            }

            else
            {

                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");

            }
        }
    }
}
