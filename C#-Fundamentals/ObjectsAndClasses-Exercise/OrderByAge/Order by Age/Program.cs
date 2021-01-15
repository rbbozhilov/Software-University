using System;
using System.Collections.Generic;

namespace Order_by_Age
{
    class Person
    {

        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {

            string text = string.Empty;

            List<Person> persons = new List<Person>();

            while ((text = Console.ReadLine()) != "End")
            {
                string[] textArray = text.Split();
                string name = textArray[0];
                string id = textArray[1];
                int age = int.Parse(textArray[2]);
                Person currentPerson = new Person(name, id, age);
                persons.Add(currentPerson);
            }


            persons.Sort((a1, a2) => a1.Age.CompareTo(a2.Age));


            foreach (Person items in persons)
            {

                Console.WriteLine("{0} with ID: {1} is {2} years old.", items.Name, items.ID, items.Age);

            }

        }
    }
}
