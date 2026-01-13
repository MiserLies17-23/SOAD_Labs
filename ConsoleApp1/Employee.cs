/// <summary>
/// Класс Сотрудник, наследует от класса Человек
/// </summary>
public class Employee : Person
{
    /// <summary>
    /// Компания, где трудоустроен сотрудник
    /// </summary>
    public String Company {  get; set; }

    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="name"> Имя сотрудника </param>
    /// <param name="company"> Компания, где трудоустроен сотрудник </param>
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }

    /// <summary>
    /// Метод для вывода информации о сотруднике
    /// Скрывает реализацию базового класса
    /// </summary>
    public new void Print()
    {
        Console.WriteLine($"Name: {Name}   Company: {Company}");
    }

}

