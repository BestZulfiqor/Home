using System;
class Cat{
	private string Name;
    private int Age;
    public Cat(string name, int age){
		System.Console.WriteLine("Создаем кошку...");
		Name = name;
		Age = age;
	}
    public void Say(){
		System.Console.WriteLine($"{Name} говорит: Мяу");
	}
    public void ShowInfo(){
		System.Console.WriteLine("Информация о кошке:");
		System.Console.WriteLine($"Кошка {Name}, возраст: {Age} года");
	}
	public Cat(){
		System.Console.WriteLine("Создаем кошку...");
	}
}
class Program
{
	static void Main(string[] args)
	{
		Cat cat = new Cat("Мурка", 2);
		cat.Say();
		cat.ShowInfo();
	}
}