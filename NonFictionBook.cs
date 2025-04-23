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
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    title = "Неизвестно";
                }
                title = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    author = "Неизвестен";
                }
                author = value;
            }
        }
        public int PublicationYear
        {
            get { return publicationYear; }
            set
            {
                if (value < 1000 || value > DateTime.Now.Year)
                {
                    publicationYear = DateTime.Now.Year;
                }
                publicationYear = value;
            }
        }

        public string Theme
        {
            get { return theme; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    author = "Неизвестно";
                }
                author = value;
            }
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
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Год издания: ");
            int publicationYear = int.Parse(Console.ReadLine());
            Console.Write("Тема: ");
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
