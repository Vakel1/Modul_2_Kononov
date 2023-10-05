using System;
using System.Collections.Generic;
using System.Linq;

class Author
{
    public string FirstName { get; }
    public string LastName { get; }
    public int BirthYear { get; }

    public Author(string firstName, string lastName, int birthYear)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthYear = birthYear;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ({BirthYear} г.)";
    }
}

class Book
{
    public string Title { get; }
    public Author Author { get; }
    public int YearPublished { get; }

    public Book(string title, Author author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }

    public override string ToString()
    {
        return $"{Title}, автор: {Author}, год издания: {YearPublished}";
    }
}

class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public List<Book> FindBooksByAuthor(Author author)
    {
        return books.Where(book => book.Author == author).ToList();
    }

    public List<Book> FindBooksByYear(int year)
    {
        return books.Where(book => book.YearPublished == year).ToList();
    }

    public List<Book> GetAllBooks()
    {
        return books;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Поиск книг по автору");
            Console.WriteLine("4. Поиск книг по году издания");
            Console.WriteLine("5. Выйти");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите название книги: ");
                    string title = Console.ReadLine();

                    Console.Write("Введите имя автора: ");
                    string authorFirstName = Console.ReadLine();

                    Console.Write("Введите фамилию автора: ");
                    string authorLastName = Console.ReadLine();

                    Console.Write("Введите год издания: ");
                    int yearPublished = int.Parse(Console.ReadLine());

                    Author author = new Author(authorFirstName, authorLastName, 0);
                    Book book = new Book(title, author, yearPublished);

                    library.AddBook(book);
                    Console.WriteLine("Книга добавлена в библиотеку.");
                    break;

                case "2":
                    Console.Write("Введите название книги для удаления: ");
                    string bookToDelete = Console.ReadLine();

                    List<Book> booksToDelete = library.GetAllBooks().Where(b => b.Title == bookToDelete).ToList();
                    if (booksToDelete.Count > 0)
                    {
                        foreach (var b in booksToDelete)
                        {
                            library.RemoveBook(b);
                            Console.WriteLine("Книга удалена из библиотеки.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Книга не найдена.");
                    }
                    break;

                case "3":
                    Console.Write("Введите имя автора для поиска книг: ");
                    string authorToSearch = Console.ReadLine();

                    List<Book> booksByAuthor = library.GetAllBooks().Where(b => b.Author.FirstName == authorToSearch || b.Author.LastName == authorToSearch).ToList();
                    if (booksByAuthor.Count > 0)
                    {
                        Console.WriteLine("Найденные книги:");
                        foreach (var b in booksByAuthor)
                        {
                            Console.WriteLine(b);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Книги автора не найдены.");
                    }
                    break;

                case "4":
                    Console.Write("Введите год издания для поиска книг: ");
                    int yearToSearch = int.Parse(Console.ReadLine());

                    List<Book> booksByYear = library.FindBooksByYear(yearToSearch);
                    if (booksByYear.Count > 0)
                    {
                        Console.WriteLine("Найденные книги:");
                        foreach (var b in booksByYear)
                        {
                            Console.WriteLine(b);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Книги в указанном году не найдены.");
                    }
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите действие из списка.");
                    break;
            }
        }
    }
}
