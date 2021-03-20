using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book
    {

        public Book(string title,int year,params string[] names)
        {

            this.Title = title;
            this.Year = year;
            this.Authors = names.ToList();

        }


        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }



    }
}
