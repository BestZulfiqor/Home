using System;
class Program
{
	static int[] SeparateEvenNumbers(int[] arr)
	{
		string p = "";
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] % 2 == 0)
			{
				p += arr[i] + " ";
			}
		}
		p = p.Trim();
		string[] pp = p.Split();
		int[] nums = new int[pp.Length];
		for (int i = 0; i < pp.Length; i++)
		{
			nums[i] = int.Parse(pp[i]);
		}
		return nums;
	}
	static int[] SeparateOddNumbers(int[] arr)
	{
		string p = "";
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] % 2 != 0)
			{
				p += arr[i] + " ";
			}
		}
		p = p.Trim();
		string[] pp = p.Split();
		int[] nums = new int[pp.Length];
		for (int i = 0; i < pp.Length; i++)
		{
			nums[i] = int.Parse(pp[i]);
		}
		return nums;
	}
	static void Main(string[] args)
	{
		string[] s = Console.ReadLine().Split();
		int[] nums = new int[s.Length];
		for (int i = 0; i < nums.Length; i++)
		{
			nums[i] = int.Parse(s[i]);
		}
		int[] odd = SeparateOddNumbers(nums);
		int[] even = SeparateEvenNumbers(nums);
		System.Console.Write($"Нечетные: [");
		int count = 0;
		foreach (var item in odd)
		{
			count++;
			System.Console.Write(item);
			if (odd.Length != count)
			{
				System.Console.Write(", ");
			}
		}
		System.Console.Write("]");
		Console.WriteLine();
		System.Console.Write($"Четные: [");
		count = 0;
		foreach (var item in even)
		{
			count++;
			System.Console.Write(item);
			if (odd.Length != count)
			{
				System.Console.Write(", ");
			}
		}
		System.Console.Write("]");
	}
}