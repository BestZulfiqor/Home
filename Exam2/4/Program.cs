using System;
class Piggy{
	private int Money;
    public void Add(int amount){
		Money += amount;
		System.Console.WriteLine($"Добавляем {amount} рублей");
	}
    public void Take(int amount){
		Money-=amount;
		System.Console.WriteLine($"Достаем {amount} рублей");
	}
    public void ShowMoney(){
		System.Console.WriteLine($"В копилке: {Money} рублей");
	}
	public Piggy(){
		System.Console.WriteLine("Создаем копилку...");
	}
}
class Program
{
	static void Main(string[] args)
	{
		Piggy piggy = new Piggy();
		piggy.Add(100);
		piggy.Add(50);
		piggy.ShowMoney();
		piggy.Take(30);
		piggy.ShowMoney();
	}
}