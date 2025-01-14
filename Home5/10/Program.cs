using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        string[] arr = s.Split(' ');
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(arr[i]);
        }
		int max = int.MinValue;
        for (int i = n - 1; i > 0; i--)
        {
			if (max < nums[i])
			{
				max = nums[i];
			}
        }
		Console.WriteLine(max);
	}
}