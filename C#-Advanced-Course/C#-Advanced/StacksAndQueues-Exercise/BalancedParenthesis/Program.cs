using System;
using System.Collections.Generic;

namespace Balanced_Parenthesis
{
   public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var items = new Stack<char>();
            var others = new Queue<char>();

            for (int i = 0; i < input.Length; i++)
            {

                items.Push(input[i]);
                others.Enqueue(input[i]);

            }

            int length = items.Count - 1;

            for (int i = 0; i <= length; i++)
            {

                char currentOther = items.Pop();
                char currentItem = others.Dequeue();

                if (currentItem == ')' || currentItem == '}' || currentItem == ']')
                {
                    Console.WriteLine("YES");
                    break;
                }

                if ((currentItem != currentOther - 1) && (currentItem != currentOther - 2) && (currentItem != currentOther - 2))
                {
                    Console.WriteLine("NO");
                    break;
                }

            }
        }
    }
}
