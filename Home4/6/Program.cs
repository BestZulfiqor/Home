using System;

class Program
{
	static int[] MergeArrays(int[] arr1, int[] arr2)
	{
		int[] res = new int[arr1.Length + arr2.Length];
		for (int i = 0; i < arr1.Length; i++)
		{
			if (arr1[i] % 2 == 0)
			{
				res[i] = arr1[i];
			}
			if (arr2[i] % 2 == 0)
			{
				res[i] = arr2[i];
			}
		}
		for (int i = 0; i < arr1.Length; i++)
		{
			if (arr1[i] % 2 != 0)
			{
				res[i + arr1.Length] = arr1[i];
			}
			if (arr2[i] % 2 != 0)
			{
				res[i + arr1.Length] = arr2[i];
			}
		}
		return res;
	}
	static void Main(string[] args)
	{
		int[] nums1 = { 1, 2, 3 };
		int[] nums2 = { 4, 5, 6 };
		int[] res = MergeArrays(nums1, nums2);
		foreach (var item in res)
		{
			System.Console.Write(item + " ");
		}
	}
}