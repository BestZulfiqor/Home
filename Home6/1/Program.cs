using System;

class Program
{
	static int Method(int a, int b)
	{
		if (b < a)
		{
			return a;
		}
		if (b % 2 == 0)
		{
			System.Console.Write(b + " ");
		}
		return Method(a, b - 1);
	}
	static void Main(string[] args)
	{
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		Method(a, b);
	}
}