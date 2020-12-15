using System;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int kapacitet = int.Parse(Console.ReadLine());
            int broifenove = int.Parse(Console.ReadLine());
            double broacha = 0;
            double broachb = 0;
            double broachv = 0;
            double broachg = 0;

            for (int i = 0; i < broifenove; i++)
            {

                string text = Console.ReadLine();

                if (text == "A")
                {
                    broacha++;
                }
                else if (text == "B")
                {
                    broachb++;
                }
                else if (text == "V")
                {
                    broachv++;
                }
                else if (text == "G")
                {
                    broachg++;
                }


            }

            broacha = broacha / broifenove * 100;
            broachb = broachb / broifenove * 100;
            broachv = broachv / broifenove * 100;
            broachg = broachg / broifenove * 100;
            double broifenovee = (double)broifenove / kapacitet * 100;


            Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%\n{3:F2}%\n{4:F2}%", broacha, broachb, broachv, broachg, broifenovee);
        }
    }
}
