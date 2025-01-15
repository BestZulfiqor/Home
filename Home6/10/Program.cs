using System;

class Program
{
    static int Method(int x , int sum = 0)
    {
		if (x == 0)
		{
			return sum;
		}
		sum += int.Parse(Console.ReadLine());
		return Method(x - 1, sum);
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine(Method(100));
    }
}