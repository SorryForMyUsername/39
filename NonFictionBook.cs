using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class NonFictionBook : IBook
    {
        string title;
        string author;
        int publicationYear;
        string theme;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value; }
        }

        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }

        public NonFictionBook(string title, string author, int publicationYear, string theme)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Theme = theme;
        }

        public static NonFictionBook Input()
        {
            Console.WriteLine("Название: ");
            string title = Console.ReadLine();
            Console.WriteLine("Автор: ");
            string author = Console.ReadLine();
            Console.WriteLine("Год издания: ");
            int publicationYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Тема: ");
            string theme = Console.ReadLine();
            return new NonFictionBook(title, author, publicationYear, theme);
        }

        public void Output()
        {
            Console.WriteLine($"Название: {Title}\n" +
                $"Автор: {Author}\n" +
                $"Год издания: {PublicationYear}\n" +
                $"Тема: {Theme}");
        }
    }
}
