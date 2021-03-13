using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace FilterByAge
{

    public class Person
    {

        public Person(string name, int age)
        {

            Name = name;
            Age = age;

        }
        public string Name { get; set; }

        public int Age { get; set; }




    }

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Person[] person = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                person[i] = new Person(input[0], int.Parse(input[1]));

            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> firstDelegate = GetCondition(condition, age);
            Action<string, Person> secondDelegate = Print;


            foreach (var items in person)
            {

                if (firstDelegate(items))
                {
                    secondDelegate(format, items);
                }

            }

        }


        static void Print(string command, Person currentPerson)
        {

            switch (command)
            {

                case "name":
                    {

                        Console.WriteLine(currentPerson.Name);

                        break;
                    }
                case "age":
                    {
                        Console.WriteLine(currentPerson.Age);
                        break;
                    }
                case "name age":
                    {
                        Console.WriteLine("{0} - {1}", currentPerson.Name, currentPerson.Age);
                        break;
                    }

            }


        }

        static Func<Person, bool> GetCondition(string command, int age)
        {

            switch (command)
            {
                case "older":
                    {

                        return p => p.Age >= age;

                        break;
                    }
                case "younger":
                    {
                        return p => p.Age < age;
                        break;
                    }
                default:
                    {
                        return null;
                        break;
                    }
            }

        }

    }
}