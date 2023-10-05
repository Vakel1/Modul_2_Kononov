using System;

class MyClass
{
    private int variable1;
    private string variable2;

    // Конструктор с входными параметрами
    public MyClass(int value1, string value2)
    {
        variable1 = value1;
        variable2 = value2;
    }

    // Конструктор, инициализирующий члены класса по умолчанию
    public MyClass()
    {
        variable1 = 0;
        variable2 = "По умолчанию";
    }

    // Деструктор
    ~MyClass()
    {
        Console.WriteLine("Объект MyClass удален.");
    }

    // Метод для вывода информации о переменных
    public void DisplayValues()
    {
        Console.WriteLine($"Переменная 1: {variable1}");
        Console.WriteLine($"Переменная 2: {variable2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Создать объект с входными параметрами");
        Console.WriteLine("2. Создать объект с параметрами по умолчанию");
        Console.WriteLine("3. Выход");

        while (true)
        {
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите значение переменной 1: ");
                    int value1 = int.Parse(Console.ReadLine());

                    Console.Write("Введите значение переменной 2: ");
                    string value2 = Console.ReadLine();

                    // Создание объекта MyClass с входными параметрами
                    MyClass obj1 = new MyClass(value1, value2);
                    obj1.DisplayValues();
                    break;

                case "2":
                    // Создание объекта MyClass с параметрами по умолчанию
                    MyClass obj2 = new MyClass();
                    obj2.DisplayValues();
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите действие из списка.");
                    break;
            }
        }
    }
}
