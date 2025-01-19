using System;
class Calculator{
	public int Add(int a, int b){
		return a + b;
	}

    // Вычесть одно число из другого
    public int Subtract(int a, int b){
		return a - b;
	}

    // Умножить два числа
    public int Multiply(int a, int b){
		return a * b;
	}
	public Calculator(){
		System.Console.WriteLine("Калькулятор: \nВведите два числа:");
	}
}
class Program
{
	static void Main(string[] args)
	{
		Calculator calculator = new Calculator();
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		System.Console.WriteLine("Результаты:");
		System.Console.WriteLine($"{a} + {b} = {calculator.Add(a,b)}");
		System.Console.WriteLine($"{a} - {b} = {calculator.Subtract(a,b)}");
		System.Console.WriteLine($"{a} * {b} = {calculator.Multiply(a,b)}");
	}
}