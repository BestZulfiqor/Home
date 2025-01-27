using System;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        library.Students.Add(new Student { Name = "Алексей", Age = 20, Group = "A-101" });
        library.Students.Add(new Student { Name = "Мария", Age = 19, Group = "B-202" });
        library.Students.Add(new Student { Name = "Дмитрий", Age = 20, Group = "A-101" });
        library.PrintStudents();
        System.Console.Write("Введите группу которое хотите искать: ");
        string group = Console.ReadLine();
        library.FindStudentsByGroup(group);
        library.GetAverageAge();
        library.FindYoungest();
        System.Console.Write("Введите минимальный возраст: ");
        int minAge = int.Parse(Console.ReadLine());
        System.Console.Write("Введите максимальный возраст: ");
        int maxAge = int.Parse(Console.ReadLine());
        library.FilterByAge(minAge, maxAge);

        Book book = new Book { Title = "Война и мир", Author = "Л.Н. Толстой", Year = 1869, };
        Book book1 = new Book { Title = "Война", Author = "Л.Н. Толстой", Year = 1870, };
        library.AddBook(book);
        library.AddBook(book1);
        System.Console.Write("Введите год выпуска книг: ");
        int year = int.Parse(Console.ReadLine());
        library.FindBooksByYear(year);
        library.CountBooksByAuthor("Л.Н. Толстой");
        library.ChangeBookStatus("Война и мир", false);
        library.ShowLibraryStats();
    }
}