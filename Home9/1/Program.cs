using System;

public class Calculator
{
	private int num1;
	private int num2;
	public Calculator(int num1, int num2)
	{
		this.num1 = num1;
		this.num2 = num2;
	}
	public int Sum()
	{
		return num1 + num2;
	}
	public int Subtract()
	{
		return num1 - num2;
	}
	public int Multiplication()
	{
		return num1 * num2;
	}
	public double Division()
	{
		if (num2 == 0)
		{
			return 0;
		}
		return (double)num1 / num2;
	}
}

class Program
{
	static void Main(string[] args)
	{
		while (true)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			Console.Write("Выберите операцию (+, -, *, /): ");
			char symbol = char.Parse(Console.ReadLine());
			Calculator calculator = new Calculator(num1, num2);
			double result = 0;

			switch (symbol)
			{
				case '+':
					result = calculator.Sum();
					break;
				case '-':
					result = calculator.Subtract();
					break;
				case '*':
					result = calculator.Multiplication();
					break;
				case '/':
					result = calculator.Division();
					break;
				default:
					Console.WriteLine("Неверная операция. Пожалуйста, попробуйте снова.");
					continue;
			}

			Console.Write($"Результат: {result} \nВведите новые числа: ");
		}
	}
}