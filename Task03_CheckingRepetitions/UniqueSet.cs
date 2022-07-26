using System;
using System.Collections.Generic;
using System.Text;

namespace Task03_CheckingRepetitions
{
    /// <summary>
    /// Структура уникальных значений
    /// </summary>
    internal struct UniqueSet
    {
        /// <summary>
        /// Хэшсэт уникальных значений типа int
        /// </summary>
        static HashSet<int> _uSet = new HashSet<int> ();
        public static HashSet<int> USet { get { return _uSet; }}
        /// <summary>
        /// Метод добавления значений, типа int, в уникальный список
        /// </summary>
        /// <param name="num">Число введеное пользователем</param>
        internal void AddUniqueNum(int num)
        {
            if (USet.Contains(num))
            {
                Console.WriteLine($"Невозможно добавить! Число - {num} уже присутствует в списке уникальных чисел!");
            }
            else
            {
                USet.Add(num);
                Console.WriteLine($"Число - {num} успешно добавлено, как уникальное!");
            }
        }
        /// <summary>
        /// Метод вывода уникального списка в консоль
        /// </summary>
        internal void PrintUniqSet()
        {
            Console.WriteLine("Значения списка уникальных значений: ");
            foreach(int u in USet)
                Console.WriteLine("\t" + u);
        }
    }
}
