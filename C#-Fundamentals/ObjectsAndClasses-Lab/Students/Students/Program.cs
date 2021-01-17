using System;
using System.Collections.Generic;

namespace Students
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


                students.Add(currentStudent);


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
