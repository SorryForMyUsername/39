using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class FictionBook : IBook
    {
        string title;
        string author;
        int publicationYear;
        string genre;

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

        public string Genre
        {
            get { return genre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    genre = "Неизвестно";
                }
                genre = value;
            }
        }

        public FictionBook(string title, string author, int publicationYear, string genre)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Genre = genre;
        }

        public static FictionBook Input()
        {
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Год издания: ");
            int publicationYear = int.Parse(Console.ReadLine());
            Console.Write("Жанр: ");
            string genre = Console.ReadLine();
            return new FictionBook(title, author, publicationYear, genre);
        }

        public void Output()
        {
            Console.WriteLine($"Название: {Title}\n" +
                $"Автор: {Author}\n" +
                $"Год издания: {PublicationYear}\n" +
                $"Жанр: {Genre}");
        }
    }
}
