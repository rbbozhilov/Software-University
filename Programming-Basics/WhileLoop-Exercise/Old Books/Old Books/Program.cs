using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            int broi = -1;

            string books = null;

            string booksess = Console.ReadLine();
            bool check = false;
            while (books != "No More Books")
            {



                if (books == booksess)
                {
                    check = true;
                    break;
                }

                broi++;
                books = Console.ReadLine();
            }

            if (check == true)
            {
                Console.WriteLine("You checked {0} books and found it.", broi);
            }
            else
            {
                Console.WriteLine("The book you search is not here!\nYou checked {0} books.", broi);
            }
        }
    }
}
