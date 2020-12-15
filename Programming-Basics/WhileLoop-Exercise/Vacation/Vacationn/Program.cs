using System;

namespace Vacationn
{
    class Program
    {
        static void Main(string[] args)
        {
            double ekskurzia = double.Parse(Console.ReadLine());
            double pari = double.Parse(Console.ReadLine());
            double sum = 0;
            int broach = 0;
            int broachposled = 0;
            sum = pari;
            bool check;
            while (true)
            {


                string doing = Console.ReadLine();
                double spesthar = double.Parse(Console.ReadLine());
                broach++;




                if (doing == "spend")
                {
                    check = false;
                    sum -= spesthar;
                    if (sum < 0)
                    {
                        sum = 0;
                    }

                    broachposled++;

                    if (broachposled == 5)
                    {
                        Console.WriteLine("You can't save the money.\n{0}", broach);
                        break;

                    }
                }
                else if (doing == "save")
                {
                    sum += spesthar;
                    check = true;
                    if (check == true)
                    {
                        broachposled = 0;
                    }
                    if (sum >= ekskurzia)
                    {

                        Console.WriteLine("You saved the money for {0} days.", broach);
                        break;

                    }

                }

            }
        }
    }
}
