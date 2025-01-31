using System;
using System.IO.Compression;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("Apple", 5, 120);
        Product product2 = new Product("Orange", 10, 100);
        Product product3 = new Product("Watermelon", 20, 300);
        StoreManager storeManager = new StoreManager();
        storeManager.AddProduct(product);
        storeManager.AddProduct(product2);
        storeManager.AddProduct(product3);
        storeManager.GetAllProducts();
        storeManager.GetProductByName("Apple");

        DateTime expiration = new DateTime(2025, 7, 20);
        Food food = new Food("Pizza", 20, 10, expiration);
        System.Console.WriteLine(food.IsExpired());

        DateTime pubDay = new DateTime(2024, 07, 2);
        Electronicks electronicks = new Electronicks("Phone", 2000, 10, 12, pubDay);
        electronicks.GetWarrantyStatus();
        storeManager.AddProduct(electronicks);

        Order order = new Order("Apple", 100, 2, "John");
        order.AddProductToOrder(order);
        order.GetTotalAmount();

        System.Console.WriteLine("\nПродукты по ценовому диапазону: ");
        foreach (var item in storeManager.GetProductsByPriceRange(10, 20))
        {
            System.Console.WriteLine($"Name: {item.GetName()}, Price: {item.GetPrice()}, Quantity: {item.GetQuantity()}");
        }

        System.Console.WriteLine("\nДоступные продукты: ");
        foreach (var item in storeManager.GetAvailableProducts())
        {
            System.Console.WriteLine($"Name: {item.GetName()}, Price: {item.GetPrice()}, Quantity: {item.GetQuantity()}");
        }

        while (true)
        {
            System.Console.WriteLine("Выберите операцию: \n1. Добавление продукта.\n2. Удаление продукта.\n3. Просмотр всех продуктов.\n4. Создание заказа.\n5. Подсчёт общей суммы заказа\n");
            char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case '1':
                    System.Console.WriteLine("1. Добавление продукта.");
                    Product product1 = new Product("Apple", 20, 50);
                    System.Console.Write("Enter product name: ");
                    product1.SetName(Console.ReadLine());
                    System.Console.Write("Enter price of product: ");
                    product1.SetPrice(double.Parse(Console.ReadLine()));
                    System.Console.Write("Enter quantity of product");
                    product1.SetQuantity(int.Parse(Console.ReadLine()));
                    storeManager.AddProduct(product1);
                    break;
                case '2':
                    System.Console.WriteLine("Введите имя продукта который хотите удалить.");
                    string name = Console.ReadLine();
                    if (storeManager.RemoveProduct(name))
                    {
                        System.Console.WriteLine($"Product with this {name} was deleted");
                    }
                    else System.Console.WriteLine($"There is no product with this {name}");
                    break;
                case '3':
                    storeManager.GetAllProducts();
                    break;
                case '4':
                    Order order1 = new Order();
                    string ordername = Console.ReadLine();
                    order1.SetName(ordername);
                    order1.SetPrice();
                    break;
                case '5':
                    storeManager.AddProduct(product);
                    break;
                default:
                    System.Console.WriteLine("There is no command!");
                    break;
            }
        }
    }
}