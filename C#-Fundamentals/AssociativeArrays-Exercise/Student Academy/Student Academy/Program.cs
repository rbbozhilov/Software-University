using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!student.ContainsKey(name))
                {
                    student.Add(name, new List<double>());
                }

                student[name].Add(grade);

            }

            student = student.Where(x => x.Value.Average() >= 4.50).ToDictionary(k => k.Key, v => v.Value);

            var finalStudent = new Dictionary<string, double>();

            foreach (var items in student)
            {
                finalStudent.Add(items.Key, items.Value.Average());
            }

            finalStudent = finalStudent.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, v => v.Value);

            foreach (var items in finalStudent)
            {
                Console.WriteLine("{0} -> {1:F2}", items.Key, items.Value);
            }
        }
    }
}
