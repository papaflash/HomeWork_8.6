using System;

namespace Task01_IntegerList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 - работа со списком:" +
                "\n\t* Создать лист целых чисел" +
                "\n\t* Заполнить лист случайными числами в диапазоне от 0 до 100" + 
                "\n\t* Вывести лист на экран" +
                "\n\t* Удалить из листа числа больше 25, но меньше 50" +
                "\n\t* Вывести лист на экран после удаления чисел");
            IntList list = new IntList();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Для заполнения листа нажмите - 1\nДля удаления из листа чисел диапазона 25 < n < 50 нажмите - 2" +
                    "\nДля выхода нажмите - Escape");
                Console.Write("Ваш выбор: ");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.D1:
                        list.InitList();
                        break;
                    case ConsoleKey.D2:
                        list.RemoveNumbers();
                        break;
                    case ConsoleKey.Escape:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine($"Для клавиши {key} нет действий!\n{new String('=', 100)}");
                        break;
                }
            }
        }
    }
}
