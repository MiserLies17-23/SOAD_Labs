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
            try
            {
                Massive<int> mas = new Massive<int>([1, 2, 3, 4]); // Потенциально могут быть пользователи
                Console.WriteLine(mas.Length);
                mas.Print();
                Console.WriteLine(mas.At(10));
                mas.Print();
                mas.Add(5);
                mas.Print();
                mas.Remove(3);
                mas.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
