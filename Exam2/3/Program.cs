using System;

class Program
{
	static void PrintNumber(int number)
	{
		if (number % 2 == 0)
		{
			System.Console.WriteLine($"Число {number} является четным");
		}
		else System.Console.WriteLine($"Число {number} является нечетным");
	}
	static int Sum(int a, int b)
	{
		return a + b;
	}
	static int Max(int a, int b)
	{
		if (a >= b)
		{
			return a;
		}
		return b;
	}
	static void Main(string[] args)
	{
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		PrintNumber(a);
		PrintNumber(b);
		System.Console.WriteLine("Сумма чисел: " + Sum(a, b));
		System.Console.WriteLine("Максимальное число: " + Max(a, b));
	}
}