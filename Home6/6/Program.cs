using System;

class Program
{
	static int Method(int x, int rev = 0)
	{
		if (x == 0)
		{
			return rev;
		}
		rev = rev * 10 + x % 10;
		return Method(x / 10, rev);
	}
	static void Main(string[] args)
	{
		int x = int.Parse(Console.ReadLine());
		System.Console.WriteLine(Method(x));
	}
}