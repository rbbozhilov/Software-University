using System;
using System.Collections.Generic;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] arrayText = text.Split();


            Random rnd = new Random();

            bool flag = false;
            List<string> lists = new List<string>();
            int lastIndex = arrayText.Length - 1;
            int counter = 0;

            do
            {



                int currentIndex = rnd.Next(0, lastIndex + 1);

                string currentWord = arrayText[currentIndex];


                if (counter == 0)
                {
                    lists.Add(currentWord);
                    counter++;
                    continue;
                }

                for (int i = 0; i < lists.Count; i++)
                {


                    if (currentWord == lists[i])
                    {
                        flag = true;

                        break;
                    }


                }

                if (!flag)
                {
                    lists.Add(currentWord);

                    counter++;
                }

                flag = false;


            }
            while (counter < arrayText.Length);


            foreach (string items in lists)
            {
                Console.WriteLine(items);
            }
        }
    }
}
