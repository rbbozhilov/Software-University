using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizener : Checker 
    {

        private string name;
        private string age;
        private string id;
        private string birthdate;

        public Citizener(string name,string age,string id,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; }
        public string Age { get; }

       

        public string Id { get; set; }


    }
}
