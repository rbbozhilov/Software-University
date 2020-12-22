using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int broigrupi = int.Parse(Console.ReadLine());

            double broimusala = 0;
            double broimonblan = 0;
            double broikiliman = 0;
            double ke = 0;
            double everest = 0;
            double allpeople = 0;
            for (int i = 0; i < broigrupi; i++)
            {

                int broihora = int.Parse(Console.ReadLine());

                if (broihora <= 5)
                {

                    broimusala += broihora;


                }
                else if (broihora > 5 && broihora <= 12)
                {
                    broimonblan += broihora;
                }
                else if (broihora > 12 && broihora <= 25)
                {
                    broikiliman += broihora;
                }
                else if (broihora > 25 && broihora <= 40)
                {
                    ke += broihora;
                }
                else if (broihora > 40)
                {
                    everest += broihora;
                }
                allpeople += broihora;

            }


            broimusala = broimusala / allpeople * 100;
            broimonblan = broimonblan / allpeople * 100;
            broikiliman = broikiliman / allpeople * 100;
            ke = ke / allpeople * 100;
            everest = everest / allpeople * 100;

            Console.WriteLine("{0:F2}%\n{1:F2}%\n{2:F2}%\n{3:F2}%\n{4:F2}%", broimusala, broimonblan, broikiliman, ke, everest);
        }
    }
}
