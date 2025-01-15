using System;

class Program
{
	static int Method(int x, int count = 0)
	{
		if (x == 0)
		{
			return count;
		}
		count += x;
		return Method(x -1, count);
	}
	static void Main(string[] args)
	{
		int x = int.Parse(Console.ReadLine());
		System.Console.WriteLine(Method(x));
	}
}