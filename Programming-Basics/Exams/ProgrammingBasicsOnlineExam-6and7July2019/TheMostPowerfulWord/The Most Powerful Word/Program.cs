using System;

namespace The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = null;
            double sum = 0;
            double points = 0;
            double maxPoints = Int32.MinValue;
            string helper = null;
            while ((text = Console.ReadLine()) != "End of words")
            {

                int length = text.Length;

                for (int i = 0; i < length; i++)
                {

                    sum += (int)text[i];
                    points += (int)text[i];

                }

                if (text[0] == 'o' || text[0] == 'a' || text[0] == 'e' || text[0] == 'i' || text[0] == 'u' || text[0] == 'y' || text[0] == 'A' || text[0] == 'O' || text[0] == 'U' || text[0] == 'E' || text[0] == 'I' || text[0] == 'Y')
                {

                    points *= length;


                }
                else
                {
                    points /= length;
                    points = Math.Floor(points);
                }

                if (points > maxPoints)
                {
                    maxPoints = points;
                    helper = text;
                }





                points = 0;

            }



            Console.WriteLine("The most powerful word is {0} - {1}", helper, maxPoints);
        }
    }
}
