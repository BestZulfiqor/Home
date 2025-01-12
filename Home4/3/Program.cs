using System;

class Program
{
	static int[] ShiftArray(int[] arr, int positions){
		int[] result = new int[arr.Length];
		for (int i = 0; i < arr.Length; i++)
		{
			result[(i + positions) % arr.Length] = arr[i];
		}
		return result;
	}
	static void Main(string[] args)
	{
		int[] nums = {1, 2, 3, 4, 5};
		int n = int.Parse(Console.ReadLine());
		int[] result = ShiftArray(nums, n);
		foreach (int i in result)
		{
			Console.Write(i + " ");
		}
	}
}