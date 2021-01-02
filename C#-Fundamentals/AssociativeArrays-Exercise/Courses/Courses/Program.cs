using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            while (true)
            {

                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(" : ");

                string currentCourse = tokens[0];
                string currentStudent = tokens[1];
                List<string> currentStudented = new List<string>();
                currentStudented.Add(currentStudent);
                if (!courses.ContainsKey(currentCourse))
                {
                    courses.Add(currentCourse, currentStudented);
                }
                else
                {
                    if (!courses.ContainsValue(currentStudented))
                    {
                        courses[currentCourse].Add(currentStudent);
                    }

                }

            }

            var sortedStudents = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, k => k.Value);

            foreach (var items in sortedStudents)
            {

                Console.WriteLine("{0}: {1}", items.Key, items.Value.Count);


                var list = items.Value.OrderBy(x => x).ToList();

                foreach (var itemss in list)
                {
                    Console.WriteLine("-- {0}", itemss);
                }

            }
        }
    }
}
