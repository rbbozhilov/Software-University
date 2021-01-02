using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            while (true)
            {

                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(" -> ");

                string currentCompany = tokens[0];
                string currentId = tokens[1];


                if (!companies.ContainsKey(currentCompany))
                {
                    companies.Add(currentCompany, new List<string>());
                    companies[currentCompany].Add(currentId);
                }

                else
                {
                    var list = new List<string>();
                    list.Add(currentId);
                    if (!companies[currentCompany].Contains(currentId))
                    {
                        companies[currentCompany].Add(currentId);
                    }
                }


            }

            var sortedCompanies = companies.OrderBy(x => x.Key);

            foreach (var items in sortedCompanies)
            {
                Console.WriteLine(items.Key);

                items.Value.ForEach(x => Console.WriteLine("-- {0}", x));

            }
        }
    }
}
