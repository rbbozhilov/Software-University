using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ReverseString
{
    class StartUp
    {
        static void Main(string[] args)
        {


            string text = Console.ReadLine();
            Stack<char> basicReverse = new Stack<char>();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                basicReverse.Push(text[i]);
            }

            while (basicReverse.Count != 0)
            {
                builder.Append(basicReverse.Pop());
            }

            Console.WriteLine(builder);


        }
    }
}
