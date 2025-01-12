using System;
class Program
{
	static void SeparateNumbers(int[] arr)
	{
		string s = "";
		string p = "";
		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] % 2 == 0)
			{
				s += arr[i] + " ";
			}
			else p += arr[i] + " ";
		}

		System.Console.WriteLine($"Четные: {s}");
		System.Console.WriteLine($"Нечетные: {p}");
	}

	static void Main(string[] args)
	{
		int[] nums = { 1, 2, 3, 4, 5, 6 };
		SeparateNumbers(nums);
	}
}