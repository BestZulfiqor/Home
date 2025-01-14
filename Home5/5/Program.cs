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
		for (int i = 0; i < n - 1; i++)
		{
			if (nums[i] > 0 && nums[i + 1] > 0 || nums[i] < 0 && nums[i + 1] < 0)
			{
				System.Console.WriteLine("YES");
				return; 
			}
		}
		System.Console.WriteLine("NO");
	}
}