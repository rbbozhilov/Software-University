using System;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedWord = Console.ReadLine();

            string text = Console.ReadLine();

            while (text.Contains(searchedWord, StringComparison.InvariantCultureIgnoreCase))
            {

                int currentIndex = text.IndexOf(searchedWord, StringComparison.InvariantCultureIgnoreCase);

                text = text.Remove(currentIndex, searchedWord.Length);

            }

            Console.WriteLine(text);
        }
    }
}
