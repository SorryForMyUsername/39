using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Program
    {
        static Library library = new Library();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1. Добавить художественную книгу\n" +
                    "2. Добавить научную книгу\n" +
                    "3. Добавить учебник\n" +
                    "----------------------------------\n" +
                    "4. Удалить художественную книгу\n" +
                    "5. Удалить научную книгу\n" +
                    "6. Удалить учебник\n" +
                    "----------------------------------\n" +
                    "7. Вывести художественные книги\n" +
                    "8. Вывести научные книги\n" + 
                    "9. Вывести учебники\n" +
                    "0. Вывести все книги\n" +
                    "----------------------------------\n" +
                    "В. Выход\n");

                char keyChar = Console.ReadKey(true).KeyChar;
                if(keyChar == 'В' || keyChar == 'в')
                {
                    break;
                }

                int choice = keyChar - 48;

                switch (choice)
                {
                    case 1: 
                        library.AddFictionBook(FictionBook.Input());
                        Console.WriteLine();
                        break;
                    case 2: 
                        library.AddNonFictionBook(NonFictionBook.Input());
                        Console.WriteLine();
                        break;
                    case 3: 
                        library.AddTextBook(TextBook.Input());
                        Console.WriteLine();
                        break;
                    case 4: break;
                    case 5: break;
                    case 6: break;
                    case 7: library.OutputFictionBooks(); break;
                    case 8: library.OutputNonFictionBooks(); break;
                    case 9: library.OutputTextBooks(); break;
                    case 0: library.OutputBooks(); break;
                }
            }
        }
    }
}
