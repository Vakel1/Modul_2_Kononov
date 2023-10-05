using System;

// Базовый класс Shape, представляющий геометрическую фигуру
class Shape
{
    // Виртуальный метод для расчета площади фигуры
    public virtual double Area()
    {
        return 0; // По умолчанию площадь равна 0
    }

    // Виртуальный метод для расчета периметра фигуры
    public virtual double Perimeter()
    {
        return 0; // По умолчанию периметр равен 0
    }
}

// Производный класс Circle, представляющий круг
class Circle : Shape
{
    private double radius; // Радиус круга

    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Переопределение метода для расчета площади круга
    public override double Area()
    {
        return Math.PI * radius * radius; // Площадь круга
    }

    // Переопределение метода для расчета периметра круга
    public override double Perimeter()
    {
        return 2 * Math.PI * radius; // Периметр круга
    }
}

// Производный класс Rectangle, представляющий прямоугольник
class Rectangle : Shape
{
    private double width;  // Ширина прямоугольника
    private double height; // Высота прямоугольника

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Переопределение метода для расчета площади прямоугольника
    public override double Area()
    {
        return width * height; // Площадь прямоугольника
    }

    // Переопределение метода для расчета периметра прямоугольника
    public override double Perimeter()
    {
        return 2 * (width + height); // Периметр прямоугольника
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем объекты классов Circle и Rectangle
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        // Выводим информацию о площади и периметре каждой фигуры
        Console.WriteLine("Площадь круга: " + circle.Area());
        Console.WriteLine("Периметр круга: " + circle.Perimeter());

        Console.WriteLine("Площадь прямоугольника: " + rectangle.Area());
        Console.WriteLine("Периметр прямоугольника: " + rectangle.Perimeter());
    }
}
