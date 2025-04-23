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

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
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
