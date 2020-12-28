using System;

namespace Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int vaucher = int.Parse(Console.ReadLine());
            int counterTickets = 0;
            int counterProducts = 0;

            string text = null;

            while ((text = Console.ReadLine()) != "End")
            {


                if (text.Length > 8)
                {

                    vaucher -= text[0];
                    vaucher -= text[1];

                    if (vaucher < 0)
                    {
                        break;
                    }
                    else
                    {
                        counterTickets++;
                    }

                }
                else
                {
                    vaucher -= text[0];

                    if (vaucher < 0)
                    {

                        break;


                    }
                    else
                    {
                        counterProducts++;
                    }


                }



            }


            Console.WriteLine("{0}\n{1}", counterTickets, counterProducts);
        }
    }
}
