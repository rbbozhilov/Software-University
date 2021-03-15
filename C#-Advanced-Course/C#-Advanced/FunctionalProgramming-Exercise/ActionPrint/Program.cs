using System;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var items in names)
            {
                Action<string> printer = Print(items);
                printer(items);
            }

        }

        static Action<string> Print(string currentName)
        {

            return currentName => Console.WriteLine(currentName);

        }
    }
}
