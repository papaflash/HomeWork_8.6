using System;
using System.Collections.Generic;
using System.Text;

namespace Task01_IntegerList
{
    internal struct IntList
    {
        List<int> _numList;
        public List<int> NumList { get { return _numList; } private set { _numList = value; } }
        /// <summary>
        /// Метод заполнения списка целыми числами в диапазоне min, max
        /// </summary>
        /// <param name="listCapasity">Размер списка</param>
        /// <param name="min">минимально возможное число в списке</param>
        /// <param name="max">максимально возможное число в списке</param>
        internal void InitList(int listCapasity = 100, int min = 0, int max = 100)
        {
            _numList = new List<int>(listCapasity);
            Random r = new Random();
            for(int i = 0; i < NumList.Capacity; i++)
                NumList.Add(r.Next(min, max));
            PrintList();
        }
        /// <summary>
        /// Метод вывода списка в консоль
        /// </summary>
        private void PrintList()
        {
            Console.WriteLine("Значения списка:");
            for (int i = 0; i < NumList.Count; i++)
            {
                if (i % 20 == 0)
                    Console.WriteLine();
                Console.Write(NumList[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new String('=', 60));    
        }
        /// <summary>
        /// Метод удаления чисел в заданном диапазоне min, max
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        internal void RemoveNumbers(int min = 25, int max = 50)
        {
            if(NumList == null)
            {
                Console.WriteLine("Список на заполнен!");
                return;
            }
            int countDels = 0;
            Console.WriteLine($"Удаляем числа которые > {min} и < {max}");
            for(int i = 0; i < NumList.Count; i++)
            {
                if (NumList[i] > min && NumList[i] < max)
                {
                    countDels++;
                    NumList.RemoveAt(i);
                }    
            }
            Console.WriteLine($"Кол-во удаленных чисел: {countDels}");
            PrintList();
        }
    }
}
