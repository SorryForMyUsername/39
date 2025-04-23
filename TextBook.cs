using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class TextBook : IBook
    {
        string title;
        string author;
        int publicationYear;
        string subject;

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
                if(value < 1000 || value > DateTime.Now.Year)
                {
                    publicationYear = DateTime.Now.Year;
                }
                publicationYear = value;
            }
        }

        public string Subject
        {
            get { return subject; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    subject = "Неизвестно";
                }
                subject = value;
            }
        }

        public TextBook(string title, string author, int publicationYear, string subject)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Subject = subject;
        }

        public static TextBook Input()
        {
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Год издания: ");
            int publicationYear = int.Parse(Console.ReadLine());
            Console.Write("Предмет: ");
            string subject = Console.ReadLine();
            return new TextBook(title, author, publicationYear, subject);
        }

        public void Output()
        {
            Console.WriteLine($"Название: {Title}\n" +
                $"Автор: {Author}\n" +
                $"Год издания: {PublicationYear}\n" +
                $"Предмет: {Subject}");
        }
    }
}
