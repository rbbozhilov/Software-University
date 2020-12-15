using System;

namespace Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {

            int stranici = int.Parse(Console.ReadLine());
            float vremechetene = float.Parse(Console.ReadLine());
            int dni = int.Parse(Console.ReadLine());

            float obshtovreme = stranici / vremechetene;
            float obshtochasove = obshtovreme / dni;

            Console.WriteLine(obshtochasove);
        }
    }
}
