using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Типы данных: 
            char symbol = 'r'; // Символ
            string str = "New string"; // Строковый

            byte a = 0; // число от 0 до 255
            short b = 32000; // число от -32768 до 36767
            int c = 100;

            float d = 3.14f; // дробные
            double e = 3.14159;

            bool isTrue = true; // булевые

            // Ввод и вывод:
            Console.Write("Введите i: ");
            int i = int.Parse(Console.ReadLine()); // Преобразование типов! 
            Console.WriteLine($"i: {i}");

            // Преобразование типов. Вводятся только строки!
            Console.Write("Введите любое целое число: ");
            string strNum = Console.ReadLine();
            int num = Convert.ToInt32(strNum); // Второй способ; первый в 29 строке
            Console.WriteLine($"Ваше число: {num}");

            // Преобразования чисел:
            c = (int)d; // float в int

            double f = c; // int в double;
            float g = c; // int в float */

            // Условия и switch case:
            Console.Write("Введите число от 1 до 7 включительно: ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Понедельник!");
                    break;
                case 2:
                    Console.WriteLine("Вторник!");
                    break;
                case 3:
                    Console.WriteLine("Среда!");
                    break;
                case 4:
                    Console.WriteLine("Четверг!");
                    break;
                case 5:
                    Console.WriteLine("Пятница!");
                    break;
                case 6:
                    Console.WriteLine("Суббота!");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье!");
                    break;
                default:
                    if (n < 1)
                        Console.WriteLine("Введено число меньше 1!");
                    else if (n > 7)
                        Console.WriteLine("Введено число больше 7!");
                    break;
            }

            // Циклы: 
            // for - заранее известно кол-во повторений
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"i: {i}");
            }

            // while - заранее не известно количество повторений 
            int number = 0;
            while (number < 5)
            {
                number++;
                Console.WriteLine($"number: {number}");
            }

            // do while - выполнится хотя бы один раз
            do
            {
                number++;
                Console.WriteLine($"number {number}");
            } while (number < 5);

            // for each - перебор коллекций
            string[] fruits = { "яблоко", "банан", "апельсин" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Массивы. Одномерные:
            int[] at = new int[5]; // массив из 5 нулей
            int[] numbers = { 8, 9, 4, 3, 7, 0, 1 }; // заданный массив
                                                     //int[] ints = new int[] { 1, 2,3, 4, 5,6, 7, 8 }; // Можно так

            // Двумерные:
            int[,] numbers2 = new int[3, 3]
            {
                { 1, 2, 3},
                { 2, 3, 4},
                { 3, 4, 5}
            };

            // Ступенчатый массив (массив массивов)
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

            // методы:
            Console.WriteLine($"Вывод массива: " + string.Join(", ", numbers));
            Console.WriteLine("Длина: " + numbers.Length);
            Console.WriteLine($"Ранк (размерность): {numbers.Rank}");

            Array.Sort(numbers); // Сортировка
            Console.WriteLine($"Сортировка: {string.Join(",", numbers)}");

            Array.Reverse(numbers); // Обратный порядок
            Console.WriteLine("Перевёрнутый массы: " + string.Join(",", numbers));

            // Бинарный поиск (массив должен быть отсортирован!)
            Array.Sort(numbers);
            int index = Array.BinarySearch(numbers, 8);
            Console.WriteLine($"Число 8 найдено по индексу: {index}");

            // Линейный поиск
            int foundIndex = Array.IndexOf(numbers, 2);
            Console.WriteLine($"Число 2 найдено по индексу: {foundIndex}");

            // Проверка существования
            bool exists = Array.Exists(numbers, x => x > 5);
            Console.WriteLine($"Есть числа больше 5: {exists}");

            //Копирование
            int[] source = { 1, 2, 3, 4, 5 };
            int[] destination = new int[5];

            // Способ 1: Array.Copy()
            Array.Copy(source, destination, source.Length);

            // Способ 2: Clone() (создает новый массив)
            int[] cloned = (int[])source.Clone();

            // Способ 3: CopyTo()
            int[] copyToArray = new int[5];
            source.CopyTo(copyToArray, 0);
        }
    }
}
