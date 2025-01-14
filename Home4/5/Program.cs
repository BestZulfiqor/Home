using System;

class Program
{
	static void Main(string[] args)
	{
		int[] nums = { 1, 3, 3, 2, 1, 5, 2 };
		var uniqueNumbers = nums.Distinct();
		foreach (var item in uniqueNumbers)
		{
			System.Console.Write(item + " ");
		}
	}
}