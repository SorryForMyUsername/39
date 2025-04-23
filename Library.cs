using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Library
    {
        List<FictionBook> fictionBooks = new List<FictionBook>();
        List<NonFictionBook> nonFictionBooks = new List<NonFictionBook>();
        List<TextBook> textBooks = new List<TextBook>();

        public void AddFictionBook(FictionBook book)
        {
            fictionBooks.Add(book);
        }

        public void AddNonFictionBook(NonFictionBook book)
        {
            nonFictionBooks.Add(book);
        }

        public void AddTextBook(TextBook book)
        {
            textBooks.Add(book);
        }

        public void DeleteFictionBook()
        {
            Console.Write("Введите название книги, которую нужно удалить: ");
            string title = Console.ReadLine();
            FictionBook bookToRemove = fictionBooks.Find(b => b.Title == title);
            fictionBooks.Remove(bookToRemove);
        }

        public void DeleteNonFictionBook()
        {
            Console.Write("Введите название книги, которую нужно удалить: ");
            string title = Console.ReadLine();
            NonFictionBook bookToRemove = nonFictionBooks.Find(b => b.Title == title);
            nonFictionBooks.Remove(bookToRemove);
        }

        public void DeleteTextBook()
        {
            Console.Write("Введите название книги, которую нужно удалить: ");
            string title = Console.ReadLine();
            TextBook bookToRemove = textBooks.Find(b => b.Title == title);
            textBooks.Remove(bookToRemove);
        }

        public void OutputFictionBooks()
        {
            foreach (FictionBook book in fictionBooks)
            {
                book.Output();
                Console.WriteLine();
            }
        }

        public void OutputNonFictionBooks()
        {
            foreach (NonFictionBook book in nonFictionBooks)
            {
                book.Output();
                Console.WriteLine();
            }
        }

        public void OutputTextBooks()
        {
            foreach (TextBook book in textBooks)
            {
                book.Output();
                Console.WriteLine();
            }
        }

        public void OutputBooks()
        {
            OutputFictionBooks();
            OutputNonFictionBooks();
            OutputTextBooks();
        }
    }
}
