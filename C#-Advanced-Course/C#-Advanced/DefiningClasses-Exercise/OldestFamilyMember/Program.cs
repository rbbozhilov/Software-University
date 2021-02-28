using System;

namespace DefiningClasses
{
  public  class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for(int i=0;i<n;i++)
            {

                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentName = tokens[0];
                int currentAge = int.Parse(tokens[1]);
                family.Add(new Person(currentName, currentAge));



            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine("{0} {1}",oldestPerson.Name,oldestPerson.Age);


        }
    }
}
