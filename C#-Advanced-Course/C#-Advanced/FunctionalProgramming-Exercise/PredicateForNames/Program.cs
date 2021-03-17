using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> func = x =>
            {

                if (x.Length <= length)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            };

            names = names.Where(func).ToArray();

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
