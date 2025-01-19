using System;

class Program
{
	static void Main(string[] args)
	{
		System.Console.WriteLine("Введите первое число:");
		int a = int.Parse(Console.ReadLine());
		System.Console.WriteLine("Введите второе число:");
		int b = int.Parse(Console.ReadLine());
		System.Console.WriteLine("Введите третье число:");
		int c = int.Parse(Console.ReadLine());
		int sum = a + b + c;
		int min = Math.Min(a,Math.Min(b,c));
		int max = Math.Max(a,Math.Max(b,c));
		System.Console.WriteLine($"Сумма чисел: {sum}");
		System.Console.WriteLine($"Самое большое число: {max}");
		System.Console.WriteLine($"Самое маленькое число: {min}");
	}
}