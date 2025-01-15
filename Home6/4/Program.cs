using System;

class Program
{
	static int Method(int x, int d, int count = 0)
	{
		if (x == 0)
		{
			return count;
		}
		if (x % 10 == d)
		{
			count++;
		}
		return Method(x / 10, d, count);
	}
	static void Main(string[] args)
	{
		int x = int.Parse(Console.ReadLine());
		int d = int.Parse(Console.ReadLine());
		System.Console.WriteLine(Method(x, d));
	}
}