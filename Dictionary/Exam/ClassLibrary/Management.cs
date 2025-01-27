using System.ComponentModel;

namespace ClassLibrary;

public class Management
{
    List<Author> authors = new List<Author>();
    List<Car> cars = new List<Car>();
    List<Post> posts = new List<Post>();
    public void PrintAuthors()
    {
        foreach (var item in authors)
        {
            Console.WriteLine($"Имя: {item.Name}, Возраст: {item.Age}, Email: {item.Email}");
        }
    }
    public void AddAuthor(Author author)
    {
        authors.Add(author);
        Console.WriteLine($"Автор успешно добавлен: {author.Name}\n");
    }
    public void FindAuthor()
    {
        int id = 1;
        bool found = false;
        foreach (var item in authors)
        {
            if (item.Age > 25 && item.Hascar)
            {
                System.Console.WriteLine($"{id}. {item.Name} ({item.Age})");
                id++;
                found = true;
            }
        }
        if (!found)
        {
            System.Console.WriteLine("Нету ни одного человека с такими показательями!\n");
        }
    }
    public Author FindAuthorByEmail(string email)
    {
        foreach (var item in authors)
        {
            if (item.Email == email)
            {
                System.Console.WriteLine($"Найден автор: \nИмя: {item.Name} \nВозраст: {item.Age} \nEmail: {item.Email}");
                return item;
            }
        }
        System.Console.WriteLine("Автор не найден");
        return null;
    }
    public bool AddCar(Car newCar)
    {
        if (newCar.Year <= 2025 && newCar.Price > 0 && (newCar.Type == "Sedan" || newCar.Type == "SUV" || newCar.Type == "Sport"))
        {
            cars.Add(newCar);
            System.Console.WriteLine("Машина успешно добавлена \nРезультат: true\n");
            return true;
        }

        System.Console.WriteLine("Ошибка: некорректные данные машины \nРезультат: false\n");
        return false;
    }
    public List<Car> GetCarsByFilter(double minPrice, double maxPrice, int minYear, int maxYear, string type)
    {
        List<Car> filtercars = new List<Car>();
        foreach (var item in cars)
        {
            if (item.Price >= minPrice && item.Price <= maxPrice && item.Year >= minYear && item.Year <= maxYear && item.Type == type)
            {
                filtercars.Add(item);
            }
        }
        return filtercars;
    }
    public void CompareCars(Car car1, Car car2)
    {
        if (car1.Price >= car2.Price)
        {
            Console.WriteLine($"Более дорогая: {car1.Brand} {car1.Model} ({car1.Price}$)");
        }
        else Console.WriteLine($"Более дорогая: {car2.Brand} {car2.Model} ({car2.Price}$)");

        if (car1.Year > car2.Year)
        {
            System.Console.WriteLine($"Более новая: {car1.Brand} {car1.Model} ({car1.Year})");
        }
        else System.Console.WriteLine($"Более новая: {car2.Brand} {car2.Model} ({car2.Year})");

        if (car1.Type == car2.Type)
        {
            System.Console.WriteLine($"Машины одного типа {car1.Type}");
        }
        else System.Console.WriteLine("Машины разного типа");
    }
    public void AnalyzeCars()
    {
        double average = 0;
        foreach (var item in cars)
        {
            average += item.Price;
        }
        average /= cars.Count;
        System.Console.WriteLine($"Средняя цена: {average}\n");
        System.Console.WriteLine("Машины дороже средней: ");
        int count = 1;
        foreach (var item in cars)
        {
            if (item.Price > average)
            {
                System.Console.WriteLine($"{count}. {item.Brand} - {item.Price}$");
                count++;
            }
        }
        System.Console.WriteLine("Группировка по типу: ");
        int sedan = 0, suv = 0;
        bool bsedan = false, bsuv = false;
        foreach (var item in cars)
        {
            if (item.Type == "Sedan")
            {
                sedan++;
                bsedan = true;
            }
            if (item.Type == "SUV")
            {
                suv++;
                bsuv = true;
            }
        }
        if (bsedan)
        {
            System.Console.WriteLine($"Sedan ({sedan}):");
            foreach (var item in cars)
            {
                if (item.Type == "Sedan")
                {
                    System.Console.WriteLine($"  - {item.Brand} {item.Model} - {item.Price}$");
                }
            }
        }
        if (bsuv)
        {
            System.Console.WriteLine($"SUV ({suv}):");
            foreach (var item in cars)
            {
                if (item.Type == "SUV")
                {
                    System.Console.WriteLine($"  - {item.Brand} {item.Model} - {item.Price}$");
                }
            }
        }
    }
    public void AddPost(Post post)
    {
        posts.Add(post);
    }
    public void GetPostInfo()
    {
        Console.WriteLine("\nПосты с > 10 лайками:\n");
        int like = 0, favourite = 0;
        string title = "";
        foreach (var item in posts)
        {
            if (item.Likes > 10)
            {
                Console.WriteLine($"- {item.Title} от {item.Author.Name} ({item.Likes} лайков) - {item.Description}");
            }
            if (favourite < item.Likes)
            {
                favourite = item.Likes;
                title = item.Title;
            }
            like += item.Likes;
        }
        Console.WriteLine("\nОбщее количество лайков: " + like);
        Console.WriteLine($"Самый популярный пост: {title} ({favourite} лайков)\n");
    }
    public List<Post> SearchPosts(string authorName, string carModel)
    {
        List<Post> posts2 = new List<Post>();
        foreach (var item in authors)
        {
            if (item.Name == authorName && item.Hascar)
            {
                foreach (var item2 in posts)
                {
                    if (item2.Author.Name == authorName && item2.Car.Model.Contains(carModel))
                    {
                        posts2.Add(item2);
                    }
                }
            }
        }
        return posts2;
    }
    public void Statistics()
    {
        Dictionary<string, int> authorPost = new Dictionary<string, int>();

        foreach (var post in posts)
        {
            if (authorPost.ContainsKey(post.Author.Name))
            {
                authorPost[post.Author.Name]++;
            }
            else
            {
                authorPost[post.Author.Name] = 1;
            }
        }

        Console.WriteLine("\nСтатистика постов:");
        foreach (var item in authorPost)
        {
            Console.WriteLine($"{item.Key}: {item.Value} пост(ов)");
        }
    }
}