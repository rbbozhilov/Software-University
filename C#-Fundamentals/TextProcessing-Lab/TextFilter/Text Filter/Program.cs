using System;
using System.Linq;
using System.Text;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] searchedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < searchedWords.Length; i++)
            {

                if (text.Contains(searchedWords[i]))
                {

                    StringBuilder builder = new StringBuilder();

                    for (int j = 0; j < searchedWords[i].Length; j++)
                    {
                        builder.Append("*");
                    }
                    text = text.Replace(searchedWords[i], builder.ToString());
                }

            }

            Console.WriteLine(text);
        }
    }
}
