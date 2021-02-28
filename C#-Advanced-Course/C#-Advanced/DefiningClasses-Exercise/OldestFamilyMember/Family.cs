using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
   public class Family
    {

        //Fields
        List<Person> people;

        public Family()
        {
            people = new List<Person>();
        }

        public void Add(Person currentPerson)
        {
            people.Add(currentPerson);
        }

        public Person GetOldestMember()
        {

            Person oldestPerson = people[0];

            foreach(var items in people)
            {

                if(oldestPerson.Age<items.Age)
                {
                    oldestPerson = items;
                }


            }

           


            return oldestPerson;

        }


    }
}
