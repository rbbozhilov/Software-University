using System;
using System.Collections.Generic;

namespace BorderControl
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            string input = string.Empty;
            List<Checker> idS = new List<Checker>();

            while((input=Console.ReadLine()) !="End")
            {

                string[] tokens = input.Split();

                if(tokens.Length==3)
                {
                    Checker citizener = new Citizener(tokens[0], tokens[1], tokens[2]);

                    idS.Add(citizener);


                }
                else if(tokens.Length==2)
                {

                    Checker robot = new Robot(tokens[0], tokens[1]);
                    idS.Add(robot);

                }

            }

            string currentId = Console.ReadLine();
            int indexer = idS.Count;

            int count = 0;
            for (int i = 0; i < indexer; i++)
            {

               
                Checker current = idS[count];
                
                if (idS[count].Validation(idS[count].Id, currentId) == "false")
                {
                    idS.Remove(current);
                    count--;
                }

                count++;

            }

            foreach(var items in idS)
            {
                Console.WriteLine(items.Id);
            }

        }
    }
}
