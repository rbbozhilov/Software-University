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

        public Citizener(string name,string age,string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Name { get; }
        public string Age { get; }
        
        
    }
}
