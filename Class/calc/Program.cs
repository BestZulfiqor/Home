using System;
class Calculator
{
	public int Add(int a, int b)
	{
		return a + b;
	}
	public int Substract(int a, int b)
	{
		return a - b;
	}
	public int Multiple(int a, int b)
	{
		return a * b;
	}
	public double Divide(double a, double b)
	{
		if (b == 0)
		{
			return 0;
		}
		return a / b;
	}
	public double Pow(int a, double b)
	{
		int pow = 1;
		for (int i = 0; i < b; i++)
		{
			pow *= a;
		}
		return pow;
	}
}
class Program
{
	static void Main(string[] args)
	{
		var calc = new Calculator();
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int add = calc.Add(a, b);
		int substract = calc.Substract(a, b);
		int multiple = calc.Multiple(a, b);
		double divide = calc.Divide(a, b);
		double pow = calc.Pow(a, b);
		System.Console.WriteLine("Add: " + add);
		System.Console.WriteLine("Substract: " + substract);
		System.Console.WriteLine("Multipe: " + multiple);
		System.Console.WriteLine("Divide: " + divide);
		System.Console.WriteLine("Pow: " + pow);
	}
}