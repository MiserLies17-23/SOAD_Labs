/// <summary>
/// Класс Часы
/// </summary>
public class Clock
{
    /// <summary>
    /// Событие, уведомляющее об изменении времени
    /// </summary>
    public event Action TimeHandler = delegate { };
    
    /// <summary>
    /// Время в часах
    /// </summary>
    public int Hours { get; set; }

    /// <summary>
    /// Неявное преобразование из int в Clock
    /// </summary>
    /// <param name="hours"> Число </param>
    public static implicit operator Clock(int hours) 
    {
        return new Clock { Hours = hours % 24};
    }

    /// <summary>
    /// Явное преобразование из Clock в int
    /// </summary>
    /// <param name="c"> Часы </param>
    public static explicit operator int(Clock c) 
    {
        return c.Hours;
    }

    /// <summary>
    /// Перегрузка оператора >
    /// </summary>
    /// <param name="c1"> Первые часы </param>
    /// <param name="c2"> Вторые часы </param>
    /// <returns> true - если время на первых часах больше, false - иначе </returns>
    public static bool operator >(Clock c1, Clock c2) 
    {
        return c1.Hours > c2.Hours;
    }

    /// <summary>
    /// Перегрузка оператора < 
    /// </summary>
    /// <param name="c1"> Первые часы </param>
    /// <param name="c2"> Вторые часы </param>
    /// <returns> true - если время на первых часах меньше, false - иначе </returns>
    public static bool operator <(Clock c1, Clock c2)
    {
        return c1.Hours < c2.Hours;
    }

    /// <summary>
    /// Перегрузка оператора +
    /// </summary>
    /// <param name="c1"> Первые часы </param>
    /// <param name="c2"> Вторые часы </param>
    /// <returns> Новый объект класса Clock </returns>
    public static Clock operator + (Clock c1, Clock c2)
    {
        return new Clock { Hours = c1.Hours + c2.Hours };
    }

    public void DisplayTime()
    {
        TimeHandler();
    }
}