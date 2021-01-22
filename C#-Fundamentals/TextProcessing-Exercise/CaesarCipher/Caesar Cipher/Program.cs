using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                result.Append((char)(text[i] + 3));
            }

            Console.WriteLine(result);
        }
    }
}
