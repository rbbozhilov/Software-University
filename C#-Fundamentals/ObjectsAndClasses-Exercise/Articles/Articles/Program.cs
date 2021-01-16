using System;

namespace Articles
{
    class Article
    {

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }





        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }



        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }


        public override string ToString()
        {
            string res = Title + " - " + Content + ": " + Author;
            return res;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


            string text = Console.ReadLine();

            string[] arrayString = text.Split(", ");



            Article article = new Article(arrayString[0], arrayString[1], arrayString[2]);



            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string comand = Console.ReadLine();
                string[] comandArray = comand.Split(": ");
                string takeCommand = comandArray[0];




                string takeValue = comandArray[1];

                switch (takeCommand)
                {

                    case "Edit":
                        {
                            article.Edit(takeValue);
                            break;
                        }
                    case "ChangeAuthor":
                        {
                            article.ChangeAuthor(takeValue);
                            break;
                        }

                    case "Rename":
                        {
                            article.Rename(takeValue);
                            break;
                        }
                }
            }
            Console.WriteLine(article);

        }


    }
}
