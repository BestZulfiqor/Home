using System;

class Program
{
	static int Method(int a, int b, int c, int d)
	{
		if (b == a)
		{
			return a;
		}
		if (b % d == c)
		{
			System.Console.Write(b + " ");
		}
		return Method(a, b - 1, c, d);
	}
	static void Main(string[] args)
	{
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		int d = int.Parse(Console.ReadLine());
		System.Console.WriteLine(Method(a, b, c, d));
	}
}