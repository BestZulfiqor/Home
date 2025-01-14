using System;

class Program
{
	static void Main(string[] args)
	{
		int n = int.Parse(Console.ReadLine());
		int[] nums = new int[n];
		for (int i = 0; i < n; i++)
		{
			nums[i] = int.Parse(Console.ReadLine());
		}
		for (int i = 0; i < n; i+=2)
		{
			System.Console.Write(nums[i] + " ");
		}
	}
}