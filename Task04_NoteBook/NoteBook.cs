using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Task04_NoteBook
{
    /// <summary>
    /// Класс представляющий записную книжку
    /// </summary>
    internal class NoteBook
    {
        readonly string _fileName;
        /// <summary>
        /// Имя файла для записи
        /// </summary>
        public string FileName { get { return _fileName; } }
        List<Person> _persons;
        /// <summary>
        /// Список пользователей в записной книжке
        /// </summary>
        public List<Person> Persons { get { return _persons; } }
        XDocument _xmlDocument;
        /// <summary>
        /// Документ представления книги в виде xml
        /// </summary>
        public XDocument XmlDocument { get { return _xmlDocument; } }
        /// <summary>
        /// Конструктор по умолчанию принимает название файла
        /// </summary>
        /// <param name="fileName">Название файла для сохраниня</param>
        public NoteBook(string fileName = "NoteBook.xml")
        {
            _xmlDocument = new XDocument();
            _persons = new List<Person>();
            _fileName = Environment.CurrentDirectory + "\\" + fileName;
        }
        /// <summary>
        /// Метод сохранения списка Persons в xml файл
        /// </summary>
        internal void SavePersonsToXml()
        {
            if (Persons.Count == 0)
            {
                Console.WriteLine("Не чего записывать!");
                return;
            }
            XElement xPersons = new XElement("Persons");
            foreach(Person person in Persons)
            {
                xPersons.Add(BuildPersonXml(person));
            }
            XmlDocument.Add(xPersons);
            XmlDocument.Save(FileName);
            Console.WriteLine($"Данные успешно записаны в \n{FileName}");
        }
        /// <summary>
        /// Метод приведения Person к модели xml
        /// </summary>
        /// <param name="person">пользователь Person</param>
        /// <returns>Возвращает Person в виде XElement</returns>
        private XElement BuildPersonXml(Person person)
        {
            XElement xCurrPerson = new XElement("Person");
            xCurrPerson.Add(new XAttribute("name", person.FIO));
            xCurrPerson.Add(new XElement("Address",
                new XElement("Street", person.Street),
                new XElement("HouseNumber", person.HouseNumber),
                new XElement("FlatNumber", person.RoomNumber)));
            xCurrPerson.Add(new XElement("Phones",
                new XElement("MobilePhone", person.PhoneNumber),
                new XElement("FlatPhone", person.HousePhoneNumber)));
            return xCurrPerson;
        }
        /// <summary>
        /// Метод добавления нового пользователя Person в список Persons
        /// </summary>
        /// <param name="newPerson">Новый пользователь Person</param>
        internal void AddPerson(Person newPerson)
        {
            Persons.Add(newPerson);
        }
    }
}
