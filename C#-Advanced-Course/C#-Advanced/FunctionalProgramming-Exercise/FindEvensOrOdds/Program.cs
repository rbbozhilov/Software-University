using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();


            Func<int[], List<int>> funcParse = x =>
            {

                var result = new List<int>();

                for (int i = x[0]; i <= x[1]; i++)
                {
                    result.Add(i);
                }

                return result;
            };

            numbers = funcParse(inputs);

            string command = Console.ReadLine();

            Predicate<int> oddPredicate = x => x % 2 != 0;
            Predicate<int> evenPredicate = x => x % 2 == 0;

            Action<List<int>, string> action = (x, y) =>
            {

                switch (y)
                {
                    case "even":
                        {

                            numbers = MyWhere(evenPredicate, numbers);

                            break;
                        }
                    case "odd":
                        {

                            numbers = MyWhere(oddPredicate, numbers);

                            break;
                        }
                }


                Console.WriteLine(string.Join(" ", numbers));
            };

            action(numbers, command);

        }

        static List<int> MyWhere(Predicate<int> operation, List<int> numbers)
        {

            var result = new List<int>();

            foreach (var items in numbers)
            {
                if (operation(items))
                {
                    result.Add(items);
                }
            }


            return result;
        }
    
    }
}
