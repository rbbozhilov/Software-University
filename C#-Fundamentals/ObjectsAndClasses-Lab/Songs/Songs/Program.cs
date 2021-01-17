using System;
using System.Collections.Generic;

namespace Songs
{
    class Program
    {

        class Song
        {


            public string Time { get; set; }
            public string Type { get; set; }
            public string Name { get; set; }



        }

        static void Main(string[] args)
        {



            List<Song> songsInList = new List<Song>();

            int n = int.Parse(Console.ReadLine());

            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {


                text = Console.ReadLine();

                string[] tokens = text.Split('_');



                songsInList.Add(new Song() { Type = tokens[0], Name = tokens[1], Time = tokens[2] });



            }


            string answer = Console.ReadLine();


            if (answer == "all")
            {

                foreach (Song items in songsInList)
                {
                    Console.WriteLine(items.Name);
                }

            }
            else
            {


                foreach (Song items in songsInList)
                {

                    if (items.Type == answer)
                    {
                        Console.WriteLine(items.Name);
                    }


                }


            }

        }
    }
}
