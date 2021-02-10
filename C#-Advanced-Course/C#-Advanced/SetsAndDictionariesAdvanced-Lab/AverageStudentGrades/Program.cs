using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {


            var students = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());
            

            for(int i=0;i<n;i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string currentName = tokens[0];
                decimal currentMark = decimal.Parse(tokens[1]);

                if (!students.ContainsKey(currentName))
                {
                    students.Add(currentName, new List<decimal>() { currentMark });
                }

                else
                {
                    students[currentName].Add(currentMark);
                }
            }


            foreach(var items in students)
            {
               
                Console.Write("{0} -> ",items.Key);
                foreach(var itens in items.Value)
                {
                    Console.Write("{0:F2} ",itens);
                }
                
                Console.WriteLine("(avg: {0:F2})", items.Value.Average());
                
            }

        }
    }
}
