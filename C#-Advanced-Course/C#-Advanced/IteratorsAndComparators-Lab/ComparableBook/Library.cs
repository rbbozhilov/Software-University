using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {

        public Library(params Book[] books)
        {
            this.Books = books.ToList();
        }


        public List<Book> Books { get; set; }

      

        public IEnumerator<Book> GetEnumerator()
        {
            Books.Sort();
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        private class LibraryIterator : IEnumerator<Book>
        {

            
            private int currentIndex = -1;

            public LibraryIterator(List<Book> books)
            {
                this.Books = books;
            }

            public List<Book> Books { get; set; }

            public Book Current => Books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {

                if(++currentIndex < Books.Count)
                {
                    
                    return true;
                }
               
                else
                {
                    return false;
                }

            }


            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
