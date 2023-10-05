using System;

// Определение класса Person
class Person
{
    // Поля класса
    private string name;    // Имя
    private int age;        // Возраст
    private string address; // Адрес

    // Конструктор класса для инициализации полей
    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    // Методы для установки и получения значений полей
    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public string GetAddress()
    {
        return address;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем объекты класса Person и устанавливаем значения полей
        Person person1 = new Person("Иван", 25, "Москва");
        Person person2 = new Person("Мария", 30, "Санкт-Петербург");

        // Выводим информацию о созданных объектах
        Console.WriteLine("Информация о первом человеке:");
        Console.WriteLine($"Имя: {person1.GetName()}");
        Console.WriteLine($"Возраст: {person1.GetAge()} лет");
        Console.WriteLine($"Адрес: {person1.GetAddress()}");

        Console.WriteLine();

        Console.WriteLine("Информация о втором человеке:");
        Console.WriteLine($"Имя: {person2.GetName()}");
        Console.WriteLine($"Возраст: {person2.GetAge()} лет");
        Console.WriteLine($"Адрес: {person2.GetAddress()}");
    }
}
