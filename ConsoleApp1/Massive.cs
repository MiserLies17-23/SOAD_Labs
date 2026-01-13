/// <summary>
/// Обобщённый класс массива
/// </summary>
/// <typeparam name="T"> Тип значений массива </typeparam>
public class Massive<T>
{
    /// <summary>
    /// Массив 
    /// </summary>
    public T[] Mas { get;  set; }

    /// <summary>
    /// Длина массива
    /// </summary>
    public int Length 
    {
        get => Mas.Length; // получение длины массива
    }
    
    /// <summary>
    /// Конструктор с параметром
    /// </summary>
    /// <param name="m"> Массив значений заданного типа </param>
    public Massive(T[] m)
    {
        Mas = m;
    }

    /// <summary>
    /// Метод удаления элемента из массива по значению
    /// </summary>
    /// <param name="elem"> Удаляемый элемент </param>
    public void Remove(T elem)
    {
        if (Mas.Length == 0)
        {
            Console.WriteLine("Массив пуст!");
            return;
        }

        if (elem != null)
        {
            for (int i = 0; i < Mas.Length; i++)
            {
                
                if (Mas[i].Equals(elem))
                {
                    T[] CopyMas = new T[Mas.Length - 1];
                    for (int j = 0; j < i; j++)
                        CopyMas[j] = Mas[j];
                    for (int j = i + 1; j < Mas.Length; j++)
                        CopyMas[j - 1] = Mas[j];
                    Mas = CopyMas;
                    return;
                }
            }
            Console.WriteLine("Элемент не найден!");
            return;
        }
    }

    /// <summary>
    /// Метод получения элемента по индексу
    /// </summary>
    /// <param name="index"> Индекс элемента </param>
    /// <returns> Элемент, соответсвующий индексу или ошибка </returns>
    /// <exception cref="IndexOutOfRangeException"> Ошибка выхода за границы массива</exception>
    public T At(int index)
    {
        if (index < Mas.Length)
            return Mas[index];
        throw new IndexOutOfRangeException("Индекс вне длины массива!");
    }

    /// <summary>
    /// Метод добавления нового элеменат в массив
    /// </summary>
    /// <param name="elem"> Добавляемый элемент </param>
    public void Add(T elem)
    {
        T[] CopyMas = new T[Mas.Length + 1];
        for (int i = 0; i < Mas.Length; i++)
            CopyMas[i] = Mas[i];
        CopyMas[Mas.Length] = elem;
        Mas = CopyMas; 
    }

    /// <summary>
    /// Метод для вывода всех элементов массива
    /// </summary>
    public void Print()
    {
        if (Mas.Length > 0)
        {
            foreach (T item in Mas)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
        else
            Console.WriteLine("Массив пуст!");
    }
}

