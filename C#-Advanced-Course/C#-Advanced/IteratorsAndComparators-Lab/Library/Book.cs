using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {

        public Book(string title, int year, params string[] names)
        {

            this.Title = title;
            this.Year = year;
            this.Authors = names.ToList();

        }


        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {


            if (this.Year.CompareTo(other.Year) != 0)
            {
                return this.Year.CompareTo(other.Year);
            }

            return this.Title.CompareTo(other.Title);
        }


        public override string ToString()
        {
            return $"{Title} - {Year}";
        }

    }
}
