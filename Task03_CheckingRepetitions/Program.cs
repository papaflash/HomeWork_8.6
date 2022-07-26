using System;

namespace Task03_CheckingRepetitions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3 - Проверка повторов:" +
               "\n\t* Пользователь вводит число." +
               "\n\t* Число сохраняется в HashSet коллекцию." +
               "\n\t* Если такое число уже присутствует в коллекции, то выводится сообщение, что число уже вводилось ранее." +
               "\n\t* Если числа нет, то появляется сообщение о том, что число успешно сохранено.");
            Console.WriteLine(new String('=', 120));
            UniqueSet uniqueSet = new UniqueSet();
            while (true)
            {
                Console.Write("Введите число для проверки на уникальность(для выхода нажмите - Enter): ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    uniqueSet.AddUniqueNum(num);
                }
                else
                    break;
            }
            uniqueSet.PrintUniqSet();
        }
    }
}
