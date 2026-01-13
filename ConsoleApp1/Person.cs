/// <summary>
/// Класс для описания человекаа
/// </summary>
public class Person
{
    /// <summary>
    /// Свойство имя
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Конструктор с параметром
    /// </summary>
    /// <param name="name"> Передаваемое в конструктор имя человека </param>
    public Person(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Метод для вывода информации о человеке
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
    }
}
