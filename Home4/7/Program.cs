using System;

class Program
{
	static string FindPairs(int[] nums, int sum){
		string res = "";
		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = i + 1; j < nums.Length; j++)
			{
				if (nums[i] + nums[j] == sum)
				{
					res += $"({nums[i]},{nums[j]}), ";
				}
			}
		}
		return res;
	}
	static void Main(string[] args)
	{
		int[] nums = {1,2,3,4,5};
		int sum = int.Parse(Console.ReadLine());
		string res = FindPairs(nums, sum);
		System.Console.WriteLine(res);
	}
}