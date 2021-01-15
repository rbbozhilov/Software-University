using System;
using System.Collections.Generic;

namespace Studentsx
{
    class Student
    {


        public Student(string firstName, string lastName, double grade)
        {

            FirstName = firstName;
            LastName = lastName;
            Grade = grade;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }



    }

    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());


            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {

                string information = Console.ReadLine();
                string[] informationArray = information.Split();
                Student currentStudent = new Student(informationArray[0], informationArray[1], double.Parse(informationArray[2]));

                students.Add(currentStudent);


            }


            students.Sort((a1, a2) => a2.Grade.CompareTo(a1.Grade));


            foreach (Student item in students)
            {

                Console.WriteLine("{0} {1}: {2:F2}", item.FirstName, item.LastName, item.Grade);

            }

        }
    }
}
