using System;
using System.Collections.Generic;
using System.Text;

namespace Task02_PhoneBook
{
    /// <summary>
    /// Структура справочник
    /// </summary>
    internal struct PhoneBook
    {
        /// <summary>
        /// Словарь с контактами
        /// </summary>
        static readonly Dictionary<string, User> _contacts = new Dictionary<string, User>();
        public static Dictionary<string, User> Contacts { get { return _contacts; } }
        /// <summary>
        /// Метод добавления данных в словарь
        /// </summary>
        /// <param name="phoneNumber">Ключ, номер телефона</param>
        /// <param name="concreteUser">Значение, структура пользователь(User)</param>
        internal static void AddContact(string phoneNumber, User concreteUser)
        {
            int hashCodeUser = concreteUser.GetHashCode();
            string formattedNumber = ParsePhoneNumber(phoneNumber); 
            if(hashCodeUser == 0)
                Console.WriteLine("Контакт не добавлен! Вы не ввели ФИО пользователя!");
            else if(string.IsNullOrEmpty(formattedNumber))
                Console.WriteLine("Не верный формат номера!");
            else if(Contacts.ContainsKey(formattedNumber))
                Contacts[formattedNumber] = concreteUser;
            else
                Contacts.Add(formattedNumber, concreteUser);
        }
        /// <summary>
        /// Метод для парсинга номера телефона в единый формат
        /// </summary>
        /// <param name="phoneNumber">Номер телефона в виде строки введенную в консоль</param>
        /// <returns>Возврат номера приведенного к общему виду</returns>
        private static string ParsePhoneNumber(string phoneNumber)
        {
            string formattedNumber = phoneNumber.TrimStart( new char[] { '+', '8', '7' });
            if(formattedNumber.Length < 10 || formattedNumber.Length > 11)
                return null;
            return formattedNumber;
        }
        /// <summary>
        /// Метод поиска контакта по номеру телефона
        /// </summary>
        /// <param name="phoneNumber">номер телефона введеный пользователем из Console</param>
        internal static void FindUserContact(string phoneNumber)
        {
            string formattedNumber = ParsePhoneNumber(phoneNumber);
            if (string.IsNullOrEmpty(formattedNumber))
                Console.WriteLine("Введен не верный формат номера!");
            else if (Contacts.TryGetValue(formattedNumber, out User findedUser))
                Console.WriteLine($"По номеру:{phoneNumber} привязан - {findedUser}");
            else
                Console.WriteLine("Контакт не найден!");
        }
    }
}
