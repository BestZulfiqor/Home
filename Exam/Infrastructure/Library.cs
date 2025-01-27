namespace Infrastructure;

public class Library
{
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Book> Books { get; set; } = new List<Book>();
    private int Available;
    private int UseBook;
    int count = 0;
    public void PrintStudents()
    {
        System.Console.WriteLine("Список всех студентов:");
        foreach (var item in Students)
        {
            System.Console.WriteLine($"Студент: {item.Name}, Возраст: {item.Age}, Группа: {item.Group}");
        }
        System.Console.WriteLine($"Всего студентов: {Students.Count}\n");
    }
    public void FindStudentsByGroup(string group)
    {
        int count = 0;
        System.Console.WriteLine($"=== Поиск студентов группы {group} ===");
        foreach (var item in Students)
        {
            if (item.Group.Contains(group))
            {
                System.Console.WriteLine($"Найден студент: {item.Name} из группы {item.Group}");
                count++;
            }
        }
        this.count = count;
        System.Console.WriteLine($"Всего найдено: {count} студента\n");
    }
    public void GetAverageAge()
    {
        double average = 0;
        foreach (var item in Students)
        {
            average += item.Age;
        }
        average /= Students.Count;
        System.Console.WriteLine($"\nКоличество студентов: {count} \nСредний возраст: {Math.Round(average, 1)} лет\n");
    }
    public void FindYoungest()
    {
        int min = 199;
        string name = "";
        foreach (var item in Students)
        {
            if (item.Age < min)
            {
                min = item.Age;
                name = item.Name;
            }
        }
        System.Console.WriteLine($"Самый молодой: {name} ({min} лет)\n");
    }
    public void FilterByAge(int minAge, int maxAge)
    {
        int count = 1;
        foreach (var item in Students)
        {
            if (item.Age >= minAge && item.Age <= maxAge)
            {
                System.Console.WriteLine($"{count}. {item.Name}, {item.Age} лет, Группа: {item.Group}");
                count++;
            }
        }
        System.Console.WriteLine();
    }
    public void AddBook(Book book)
    {
        if (book.Year <= 2025 && book.Title.Length > 3 && book.Author.Length > 3)
        {
            System.Console.WriteLine($"Книга \"{book.Title}\" успешно добавлена\n");
            Books.Add(book);
        }
        else System.Console.WriteLine("Неверные данные!\n");
    }
    public void FindBooksByYear(int year)
    {
        bool found = false;
        int count = 0;
        foreach (var item in Books)
        {
            if (item.Year == year)
            {
                System.Console.WriteLine($"1. \"{item.Title}\" - {item.Author}");
                count++;
                found = true;
            }
        }
        if (!found)
        {
            System.Console.WriteLine("Нету книг по этому году!");
        }
        System.Console.WriteLine();
    }
    public void CountBooksByAuthor(string author)
    {
        int countBooks = 0;
        foreach (var item in Books)
        {
            if (item.Author == author)
            {
                countBooks++;
            }
        }
        int available = countBooks;
        int use = 0;
        foreach (var item in Books)
        {
            if (item.Author == author)
            {
                if (item.IsAvailable)
                {
                    available--;
                    use++;
                }
            }
        }
        System.Console.WriteLine($"Всего книг: {countBooks} \nДоступно: {available}\nВ пользовании: {use}\n");
        this.Available = available;
        this.UseBook = use;
    }
    public void ChangeBookStatus(string title, bool isAvailable){
        bool found = false; 
        foreach (var item in Books)
        {
            if (item.Title == title && item.IsAvailable == isAvailable)
            {
                item.IsAvailable = isAvailable;
                System.Console.WriteLine($"Книга \"{item.Title}\" теперь недоступна\n");
                found = true;
                UseBook++;
                Available--;
            }
        }
        if (!found)
        {
            System.Console.WriteLine("Ошибка ввода!");
        }
    }
    public void ShowLibraryStats()
    {
        System.Console.WriteLine($"Всего студентов: {Students.Count} \nВсего книг: {Books.Count}\nДоступно книг: {Available} \nКниг в пользовании: {UseBook}");
    }
}
