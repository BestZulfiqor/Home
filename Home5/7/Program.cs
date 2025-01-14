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
        for (int i = 0; i < n / 2; i++)
        {
            int temp = nums[i];
            nums[i] = nums[nums.Length - i - 1];
            nums[nums.Length - i - 1] =  temp;
        }
        foreach (var item in nums)
        {
            System.Console.Write(item + " ");
        }
    }
}