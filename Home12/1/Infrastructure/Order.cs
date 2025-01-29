using System.Reflection.Metadata;

namespace Infrastructure;

public class Order : Product
{
    public string CustomerName { get; set; }
    List<Product> orders = new List<Product>();
    public Order(string name, double price, int quantity, string customerName) : base(name, price, quantity)
    {
        this.CustomerName = customerName;
    }
    public void AddProductToOrder(Product product)
    {
        orders.Add(product);
    }
    public void GetTotalAmount()
    {
        double totalAmount = 0;
        foreach (var product in orders)
        {
            totalAmount += product.GetPrice() * product.GetQuantity();
        }
        System.Console.WriteLine($"\nОбщая сумма заказа: {totalAmount}\n");
    }
}
