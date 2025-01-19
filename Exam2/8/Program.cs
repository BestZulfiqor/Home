using System;
class Product
{
	private string Name;
	private int Price;
	private int Count;
	public Product(string name, int price, int count)
	{
		System.Console.WriteLine("Создаем товар...");
		Name = name;
		Price = price;
		Count = count;
		ShowInfo();
	}
	public void Sell(int amount)
	{
		Count -= amount;
		System.Console.WriteLine($"Продаем {amount} яблок...");
		System.Console.WriteLine($"На складе осталось: {Count} шт.\n");
	}
	public void Add(int amount)
	{
		Count += amount;
		System.Console.WriteLine($"Добавляем {amount} яблок...");
		System.Console.WriteLine($"На складе сейчас: {Count} шт.\n");
	}
	public void ShowInfo()
	{
		System.Console.WriteLine($"Название: {Name}");
		System.Console.WriteLine($"Цена: {Price} руб.");
		System.Console.WriteLine($"Количества: {Count} шт.\n");
	}
}
class Program
{
	static void Main(string[] args)
	{
		Product product = new Product("Яблоки", 100, 15);
		product.Sell(5);
		product.Add(20);
	}
}