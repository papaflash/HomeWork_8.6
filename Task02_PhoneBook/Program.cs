using System;

namespace Task02_PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2 - Телефонная книга:" +
                "\n\t* Пользователь вводит номера телефонов и ФИО их владельцев." +
                "\n\t* В процессе ввода информация размещается в Dictionary, где ключом является номер телефона, а значением — ФИО" +
                "\n\t* Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки." +
                "\n\t* Далее программа предлагает найти владельца по введенному номеру телефона." +
                "\n\t* Пользователь вводит номер телефона и ему выдаётся ФИО владельца." +
                "\n\t* Если владельца по такому номеру телефона не зарегистрировано, программа выводит сообщение.");
            Console.WriteLine(new String('=', 120));
            while (true)
            {
                Console.Write("Введите телефон пользователя(для завершения добавления контактов введите пустую строку): ");
                string phoneNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(phoneNumber)) break;
                User user = new User();
                Console.Write("Введите Фамилия: ");
                user.LastName = Console.ReadLine();
                Console.Write("Введите Имя: ");
                user.FirstName = Console.ReadLine();
                Console.Write("Введите Отчество(необязательно): ");
                user.MiddleName = Console.ReadLine();
                PhoneBook.AddContact(phoneNumber, user);
            }
            while (true)
            {
                Console.Write("Введите номер телефона для поиска контакта: ");
                PhoneBook.FindUserContact(Console.ReadLine());
                Console.WriteLine("Для выхода нажмите - Enter, для продолжения любую клавижу:");
                if (Console.ReadKey().Key == ConsoleKey.Enter) break;
            }
            Console.WriteLine("\tПрограмма закончила выполнение");
        }
    }
}
