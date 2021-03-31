using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Person
    {

        public Person(string fullName,int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }


        [MyRequiredAttribute]
        public string FullName { get; set; }

        [MyRange(12,90)]
        public int Age { get; set; }



    }
}
