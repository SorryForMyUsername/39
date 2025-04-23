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
                    "   ---\n" +
                    "4. Удалить художественную книгу\n" +
                    "5. Удалить научную книгу\n" +
                    "6. Удалить учебник\n" +
                    "   ---\n" +
                    "7. Вывести художественные книги\n" +
                    "8. Вывести научные книги\n" + 
                    "9. Вывести учебники\n" +
                    "0. Вывести все книги\n" +
                    "   ---\n" +
                    "В. Выход\n");

                while (true)
                {
                    char keyChar = Console.ReadKey(true).KeyChar;
                    if (keyChar == 'В' || keyChar == 'в')
                    {
                        return;
                    }

                    int choice = keyChar - 48;

                    switch (choice)
                    {
                        case 1: library.AddFictionBook(FictionBook.Input()); break;
                        case 2: library.AddNonFictionBook(NonFictionBook.Input()); break;
                        case 3: library.AddTextBook(TextBook.Input()); break;
                        case 4: library.DeleteFictionBook(); break;
                        case 5: library.DeleteNonFictionBook(); break;
                        case 6: library.DeleteTextBook(); break;
                        case 7: library.OutputFictionBooks(); Wait(); break;
                        case 8: library.OutputNonFictionBooks(); Wait(); break;
                        case 9: library.OutputTextBooks(); Wait(); break;
                        case 0: library.OutputBooks(); Wait(); break;
                        default: continue;
                    }
                    Console.Clear();
                    break;
                }
            }
        }

        static void Wait()
        {
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey(true);
        }
    }
}
