using System;
class Program
{
	static string FindCommon(int[] arr1, int[] arr2)
	{
		string s = "";
		for (int i = 0; i < arr1.Length; i++)
		{
			for (int j = 0; j < arr2.Length; j++)
			{
				if (arr1[i] == arr2[j])
				{
					s += arr1[i];
					break;
				}
			}
		}
		string p = "";
		for (int i = 0; i < s.Length; i++)
		{
			int count = 0;
			for (int j = 0; j < p.Length; j++)
			{
				if (s[i] == p[j])
				{
					count++;
				}
			}
			if (count == 0)
			{
				p += s[i] + " ";
			}
		}
		return p;
	}

	static void Main(string[] args)
	{
		int[] arr1 = { 1, 2, 3, 2, 0 };
		int[] arr2 = { 5, 1, 2, 7, 3 };
		Console.WriteLine(FindCommon(arr1, arr2));
	}
}