using System;
using System.Collections.Generic;

namespace Students_2._0
{
    class Program
    {

        class Student
        {

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }



        }



        static bool IsSame(List<Student> students, Student currentStudent)
        {

            foreach (Student items in students)
            {
                if ((items.FirstName == currentStudent.FirstName) && (items.LastName == currentStudent.LastName))
                {
                    return true;
                }
            }

            return false;
        }

        static Student IsSameStudent(List<Student> students, Student currentStudent, int[] index)
        {

            Student existingStudent = null;
            int counter = 0;
            foreach (Student items in students)
            {
                if ((items.FirstName == currentStudent.FirstName) && (items.LastName == currentStudent.LastName))
                {
                    existingStudent = currentStudent;
                    index[0] = counter;
                }
                counter++;
            }


            return existingStudent;

        }


        static void Main(string[] args)
        {


            List<Student> students = new List<Student>();


            string text = string.Empty;


            while ((text = Console.ReadLine()) != "end")
            {


                Student currentStudent = new Student();

                string[] token = text.Split();

                currentStudent.FirstName = token[0];
                currentStudent.LastName = token[1];
                currentStudent.Age = int.Parse(token[2]);
                currentStudent.HomeTown = token[3];

                if (IsSame(students, currentStudent))
                {

                    int[] takeIndex = new int[1];

                    currentStudent = IsSameStudent(students, currentStudent, takeIndex);

                    students.RemoveAt(takeIndex[0]);
                    students.Insert(takeIndex[0], currentStudent);


                }
                else
                {
                    students.Add(currentStudent);
                }

            }


            string town = Console.ReadLine();

            foreach (Student items in students)
            {

                if (items.HomeTown == town)
                {
                    Console.WriteLine("{0} {1} is {2} years old.", items.FirstName, items.LastName, items.Age);
                }

            }


        }
    }
}
