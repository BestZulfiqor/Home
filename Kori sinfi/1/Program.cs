using System;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Restaurant restaurant = new Restaurant();
        MenuItem menuItem = new MenuItem("Pizza", 50, "Tajik");
        restaurant.AddMenuItem(menuItem);
        Customer customer = new Customer("John");
        Order order = new Order();
        order.AddItem(menuItem);
        customer.MakeOrder(order);
        customer.ViewOrders();
        order.CalculateTotal();

        while (true)
        {
            Console.WriteLine("1. Добавить блюдо в заказ");
            Console.WriteLine("2. Удалить блюдо из заказа");
            Console.WriteLine("3. Посмотреть заказ");
            Console.WriteLine("4. Посчитать сумму заказа");
            char key = char.Parse(Console.ReadLine());
            switch (key)
            {
                case '1':
                    Console.WriteLine("Введите название блюда");
                    string name = Console.ReadLine();
                    
                    break;
                default:
                    break;
            }
                
        }
    }
}
