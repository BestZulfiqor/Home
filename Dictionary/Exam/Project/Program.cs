using System;
using ClassLibrary;
class Program
{
    static void Main(string[] args)
    {
        Management management = new Management();
        Author author1 = new Author("John", 25, "john@mail.com", true);
        Author author2 = new Author("Alice", 30, "alice@mail.com", false);
        Author author3 = new Author("Bob", 20, "bob@mail.com", true);
        management.AddAuthor(author1);
        management.AddAuthor(author2);
        management.AddAuthor(author3);
        management.PrintAuthors();
        management.FindAuthor();
        management.FindAuthorByEmail("john@mail.com");

        Car car1 = new Car("Mazda", "3", 2020, 35000, "Sedan");
        Car car2 = new Car("BMW", "X5", 2022, 50000, "SUV");
        Car car3 = new Car("Mercedes", "Benz", 2015, 23000, "Sport");
        management.AddCar(car1);
        management.AddCar(car2);
        management.AddCar(car3);

        if (management.GetCarsByFilter(1200, 70000, 2012, 2017, "Sport").Count != 0)
        {
            int count = 1;
            System.Console.WriteLine("Найдены машины:");
            foreach (var item in management.GetCarsByFilter(1200, 70000, 2012, 2025, "Sport"))
            {
                System.Console.WriteLine($"{count}. {item.Brand} {item.Model} ({item.Year}) - {item.Price}$");
                count++;
            }
            System.Console.WriteLine();
        }
        else System.Console.WriteLine("По такими запросами нету машин! \n");

        management.CompareCars(car1, car2);
        management.AnalyzeCars();

        Post post1 = new Post("Post1", author1, car1,"20.01.2024", 15);
        Post post2 = new Post("Post2", author2, car1,"25.01.2024", 20);
        Post post3 = new Post("Post3", author3, car1,"10.01.2024", 5);
        management.AddPost(post1);
        management.AddPost(post2);
        management.AddPost(post3);
        management.GetPostInfo();
        System.Console.WriteLine("Найденные посты:");
        int count2 = 1;
        foreach (var item in management.SearchPosts("John", "3"))
        {
            System.Console.WriteLine($"\"{count2}. {item.Car.Brand} {item.Car.Model} - {item.Title}\" от {item.Author.Name} ({item.Likes}) - {item.Description}");
            count2++;
        }
        management.Statistics();
    }
}