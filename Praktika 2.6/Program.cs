using System;

class Employee
{
    private string name;
    private int age;
    private string position;
    private double monthlySalary;

    public Employee(string name, int age, string position, double monthlySalary)
    {
        this.name = name;
        this.age = age;
        this.position = position;
        this.monthlySalary = monthlySalary;
    }

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

    public void SetPosition(string position)
    {
        this.position = position;
    }

    public string GetPosition()
    {
        return position;
    }

    public void SetMonthlySalary(double monthlySalary)
    {
        this.monthlySalary = monthlySalary;
    }

    public double GetMonthlySalary()
    {
        return monthlySalary;
    }

    public double CalculateAnnualIncome()
    {
        return monthlySalary * 12;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите информацию о сотруднике 1:");

        Console.Write("Имя: ");
        string name1 = Console.ReadLine();

        Console.Write("Возраст: ");
        int age1 = int.Parse(Console.ReadLine());

        Console.Write("Должность: ");
        string position1 = Console.ReadLine();

        Console.Write("Месячная зарплата: ");
        double salary1 = double.Parse(Console.ReadLine());

        Employee employee1 = new Employee(name1, age1, position1, salary1);

        Console.WriteLine("\nВведите информацию о сотруднике 2:");

        Console.Write("Имя: ");
        string name2 = Console.ReadLine();

        Console.Write("Возраст: ");
        int age2 = int.Parse(Console.ReadLine());

        Console.Write("Должность: ");
        string position2 = Console.ReadLine();

        Console.Write("Месячная зарплата: ");
        double salary2 = double.Parse(Console.ReadLine());

        Employee employee2 = new Employee(name2, age2, position2, salary2);

        Console.WriteLine("\nИнформация о сотруднике 1:");
        Console.WriteLine($"Имя: {employee1.GetName()}");
        Console.WriteLine($"Возраст: {employee1.GetAge()} лет");
        Console.WriteLine($"Должность: {employee1.GetPosition()}");
        Console.WriteLine($"Месячная зарплата: {employee1.GetMonthlySalary()} руб.");
        Console.WriteLine($"Годовой доход: {employee1.CalculateAnnualIncome()} руб.");

        Console.WriteLine("\nИнформация о сотруднике 2:");
        Console.WriteLine($"Имя: {employee2.GetName()}");
        Console.WriteLine($"Возраст: {employee2.GetAge()} лет");
        Console.WriteLine($"Должность: {employee2.GetPosition()}");
        Console.WriteLine($"Месячная зарплата: {employee2.GetMonthlySalary()} руб.");
        Console.WriteLine($"Годовой доход: {employee2.CalculateAnnualIncome()} руб.");
    }
}
