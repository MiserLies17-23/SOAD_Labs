namespace ConsoleApp1
{
    /// <summary>
    /// Класс программы
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа программы
        /// </summary>
        /// <param name="args"> Массив аргументов, передаётся при запуске </param>
        static void Main(string[] args)
        {
            //Clock c1 = new Clock { Hours = 13 };
            //Clock c2 = new Clock { Hours = 7 };
            //int hour1 = c1.Hours; // явное преобразование;
            //Console.WriteLine(hour1);
            //hour1 = 34;
            //c2 = hour1; // неявное преобразование;
            //Console.WriteLine(c1 > c2);
            //Console.WriteLine(c2.Hours);
            try
            {
                Massive<int> mas = new([1, 2, 3]);
                Console.WriteLine(mas.Length);
                Console.WriteLine(mas.Mas[2]);
                mas.At(2, out int elem);
                Console.WriteLine(elem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
