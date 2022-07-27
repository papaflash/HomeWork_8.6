using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_NoteBook
{
    /// <summary>
    /// Структура представления пользователя
    /// </summary>
    internal struct Person
    {
        string _FIO;
        public string FIO { get { return _FIO; } set { _FIO = value; } }
        string _street;
        public string Street { get { return _street; } set { _street = value;} }
        int _houseNumber;
        public int HouseNumber { get { return _houseNumber; } set { _houseNumber = value; } }
        int _roomNumber;
        public int RoomNumber { get { return _roomNumber; } set { _roomNumber = value; } } 
        string _phoneNumber;
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        string _housePhoneNumber;
        public string HousePhoneNumber { get { return _housePhoneNumber; } set { _housePhoneNumber = value; } }

        public Person(string fio, string street, int houseNumber, int roomNumber, string phoneNumber, string housePhoneNumber)
        {
            _FIO = fio;
            _street = street;
            _houseNumber = houseNumber;
            _roomNumber = roomNumber;
            _phoneNumber = phoneNumber;
            _housePhoneNumber = housePhoneNumber;
        }
    }
}
