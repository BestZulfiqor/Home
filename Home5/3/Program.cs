using System;

class Program
{
	static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		int[] nums = new int[n];
		int count = 0;
		for (int i = 0; i < n; i++)
		{
			nums[i] = int.Parse(Console.ReadLine());
		}
		for (int i = 0; i < n; i++)
		{
			if (nums[i] > 0)
			{
				count++;
			}
		}
		System.Console.WriteLine(count);
	}
}