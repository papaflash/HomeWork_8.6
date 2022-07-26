using System;
using System.Collections.Generic;
using System.Text;

namespace Task02_PhoneBook
{
    /// <summary>
    /// Структура представления пользователя
    /// </summary>
    internal struct User
    {
        string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        string _middleName;
        public string MiddleName { get { return _middleName; } set { _middleName = value; } }
        public User(string lastName, string firstName, string middleName = "")
        {
            _lastName = lastName;
            _firstName = firstName;
            _middleName = middleName;
        }
        public override int GetHashCode()
        {
            if(string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(FirstName))
                return 0;
            return LastName.GetHashCode();
        }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
