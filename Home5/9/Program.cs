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
        int temp = nums[n - 1];
        for (int i = n - 1; i > 0; i--)
        {
            nums[i] = nums[i - 1];
        }
        nums[0] = temp;
        foreach (var item in nums)
        {
            Console.Write(item + " ");
        }
    }
}