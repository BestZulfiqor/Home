using System;
class Order
{
	int OrderNumber;
	string ProductName;
	int Quantity;
	decimal TotalQuantity;
	public Order(int orderNumber, string productName, int productQuantity, decimal orderAmount)
	{
		this.OrderNumber = orderNumber;
		this.ProductName = productName;
		this.Quantity = productQuantity;
		this.TotalQuantity = orderAmount;
	}
	public Order(string productName, int productQuantity)
	{
		this.ProductName = productName;
		this.Quantity = productQuantity;
	}
	public Order(string productName, decimal orderAmount)
	{
		this.ProductName = productName;
		this.TotalQuantity = orderAmount;
	}
	public void DisplayInfo()
	{
		Console.WriteLine("Order Number: " + OrderNumber);
		Console.WriteLine("Product Name: " + ProductName);
		Console.WriteLine("Quantity: " + Quantity);
		Console.WriteLine("Total Quantity: " + TotalQuantity);
	}
}
class Program
{
	static void Main(string[] args)
	{
		Order order1 = new Order(101, "Ноутбук", 2, 2500);
		Order order2 = new Order("Смартфон", 5);
		Order order3 = new Order("Наушники", 120.5m);

		Console.WriteLine("Информация о заказах:");
		order1.DisplayInfo();
		order2.DisplayInfo();
		order3.DisplayInfo();
	}
}