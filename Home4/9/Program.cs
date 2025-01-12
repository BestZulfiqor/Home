using System;

class Program
{
	static int[] CompareArrays(int[] arr1, int[] arr2){
		string s = "";
		for (int i = 0; i < arr1.Length; i++)
		{
			bool found = true;
			for (int j = 0; j < arr2.Length; j++)
			{
				if (arr1[i] == arr2[j])
				{
					found = false;
					break;
				}
			}
			if (found)
			{
				s += arr1[i] + " "; 
			}
		}
		s = s.Trim();
		string[] ss = s.Split();
		int[] nums = new int[ss.Length];
		for (int i = 0; i < ss.Length; i++)
		{
			nums[i] = int.Parse(ss[i]);
		}
		return nums;
	}
	static void Main(string[] args)
	{
		int[] nums1 = {1,2,3,4};
		int[] nums2 = {1,2,3};
		int[] nums = CompareArrays(nums1, nums2);
		foreach (var item in nums)
		{
			System.Console.Write(item + " ");
		}
	}
}