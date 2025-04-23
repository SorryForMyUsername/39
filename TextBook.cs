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

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
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
            Console.WriteLine("Название: ");
            string title = Console.ReadLine();
            Console.WriteLine("Автор: ");
            string author = Console.ReadLine();
            Console.WriteLine("Год издания: ");
            int publicationYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Предмет: ");
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
