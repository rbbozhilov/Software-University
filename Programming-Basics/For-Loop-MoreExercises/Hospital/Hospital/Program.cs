using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            int lekari = 7;

            int pregledani = 0;
            int nepregledani = 0;

            for (int i = 1; i <= dni; i++)
            {

                int pacienti = int.Parse(Console.ReadLine());


                if (i % 3 == 0 && nepregledani > pregledani)
                {

                    lekari++;

                }

                if (pacienti <= lekari)
                {

                    pregledani += pacienti;


                }
                else
                {

                    nepregledani += pacienti - lekari;
                    pregledani += lekari;

                }

            }


            Console.WriteLine("Treated patients: {0}.\nUntreated patients: {1}.", pregledani, nepregledani);
        }
    }
}
