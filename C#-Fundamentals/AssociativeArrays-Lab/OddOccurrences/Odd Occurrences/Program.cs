using System;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            var dic = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {

                string currentWord = text[i].ToLower();

                if (!dic.ContainsKey(currentWord))
                {
                    dic.Add(currentWord, 0);
                }

                dic[currentWord]++;


            }

            foreach (var items in dic)
            {

                if (items.Value % 2 == 1)
                {
                    Console.Write("{0} ", items.Key);
                }

            }
        }
    }
}
