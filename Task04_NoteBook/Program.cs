using System;

namespace Task04_NoteBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4 - Записная книжка xml:" +
               "\n\t* Программа спрашивает у пользователя данные о контакте:" +
               "\n\t* ФИО" +
               "\n\t* Название улицы" +
               "\n\t* Номер дома" +
               "\n\t* Номер квартиры" +
               "\n\t* Номер мобильного телефона" +
               "\n\t* Номер домашнего телефона" +
               "\n Программа должна сохранить данные в файл вида xml");
            Console.WriteLine(new String('=', 120));
            NoteBook noteBook = new NoteBook();
            while (true)
            {
                Console.WriteLine("Для заполнения записной книги, нажмите - Enter (для выхода нажмите любую клавишу):");
                if (Console.ReadKey().Key != ConsoleKey.Enter) break;
                Person person = new Person();
                Console.Write("Введите Фамилия Имя Отчество: ");
                person.FIO = Console.ReadLine();
                Console.Write("Введите название улицы: ");
                person.Street = Console.ReadLine();
                Console.Write("Введите номер дома: ");
                if(!int.TryParse(Console.ReadLine(), out int houseNum))
                {
                    Console.WriteLine("Не корректное значение! Номер дома должен быть числом!");
                    continue;
                }
                person.HouseNumber = houseNum;
                Console.Write("Введите номер квартиры: ");
                if (!int.TryParse(Console.ReadLine(), out int roomNum))
                {
                    Console.WriteLine("Не корректное значение! Номер комнаты должен быть числом!");
                    continue;
                }
                person.RoomNumber = roomNum;
                Console.Write("Введите номер мобильного телефона: ");
                person.PhoneNumber = Console.ReadLine();
                Console.Write("Введите номер домашнего телефона: ");
                person.HousePhoneNumber = Console.ReadLine();
                noteBook.AddPerson(person);
            }
            noteBook.SavePersonsToXml();
        }
    }
}
