using System;

class Program
{
	static void CountInRanges(int[] arr)
	{
		int count30 = 0, count60 = 0, count90 = 0, count100 = 0;
		for (int i = 0; i < arr.Length; i++)
		{

			if (arr[i] <= 30)
			{
				count30++;
			}
			else if (arr[i] <= 60)
			{
				count60++;
			}
			else if (arr[i] <= 90)
			{
				count90++;
			}
			else if (arr[i] <= 100)
			{
				count100++;
			}
		}
		System.Console.WriteLine($"0-30: {count30}");
		System.Console.WriteLine($"0-60: {count60}");
		System.Console.WriteLine($"0-90: {count90}");
		System.Console.WriteLine($"0-100: {count100}");
	}
	static void Main(string[] args)
	{
		int[] nums = { 25, 45, 65, 23, 92, 12, 88, 34 };
		CountInRanges(nums);
	}
}