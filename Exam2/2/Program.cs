using System;

class Program
{
	static void Main(string[] args)
	{
		int a = int.Parse(Console.ReadLine());
		int even = 0, odd = 0, sum = 0;
		for (int i = 0; i < a; i++)
		{
			int n = int.Parse(Console.ReadLine());
			if (n % 2 == 0)
			{
				even++;
			}
			else if (n % 2 != 0)
			{
				odd++;
			}
			if (n > 0)
			{
				sum+= n;
			}
		}
		System.Console.WriteLine("Результаты:");
		System.Console.WriteLine($"Количество четных чисел: {even}");
		System.Console.WriteLine($"Количество нечетных чисел: {odd}");
		System.Console.WriteLine($"Сумма положительных чисел: {sum}");
	}
}