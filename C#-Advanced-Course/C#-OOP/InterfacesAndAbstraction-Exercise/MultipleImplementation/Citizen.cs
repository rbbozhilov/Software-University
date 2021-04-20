using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson , IIdentifiable , IBirthable
    {

        private string name;
        private int age;
        private string birthDate;
        private string id;

        public Citizen(string name,int age , string id , string birthDate)
        {
            this.name = name;
            this.age = age;
            this.birthDate = birthDate;
            this.id = id;
        }

        public string Name => this.name;

        public int Age => this.age;

        public string Id => this.id;

        public string Birthdate => this.birthDate;



    }
}
