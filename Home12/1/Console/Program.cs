using System;
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

        
    }
}