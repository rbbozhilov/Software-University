using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class  StartUp
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                string[] tokens = Console.ReadLine().Split();
                people.Add(new Person(tokens[0], int.Parse(tokens[1])));



            }

            List<Person> olderPeople = people.Where(x => x.Age > 30).ToList();
            olderPeople = olderPeople.OrderBy(x => x.Name).ToList();

            foreach(var items in olderPeople)
            {
                Console.WriteLine("{0} - {1}",items.Name,items.Age);
            }


        }
    }
}
