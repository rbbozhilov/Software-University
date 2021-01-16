using System;
using System.Collections.Generic;

namespace Articles_2._0
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

            int n = int.Parse(Console.ReadLine());


            List<Article> articles = new List<Article>();


            for (int i = 0; i < n; i++)
            {

                string text = Console.ReadLine();

                string[] arrayString = text.Split(", ");

                Article currentArticle = new Article(arrayString[0], arrayString[1], arrayString[2]);

                articles.Add(currentArticle);


            }


            string command = Console.ReadLine();


            switch (command)
            {

                case "title":
                    {

                        articles.Sort((a1, a2) => a1.Title.CompareTo(a2.Title));
                        break;
                    }

                case "content":
                    {
                        articles.Sort((a1, a2) => a1.Content.CompareTo(a2.Content));
                        break;
                    }

                case "author":
                    {

                        articles.Sort((a1, a2) => a1.Author.CompareTo(a2.Author));
                        break;
                    }

            }

            foreach (Article items in articles)
            {

                Console.WriteLine("{0} - {1}: {2}", items.Title, items.Content, items.Author);

            }
        }
    }
}
