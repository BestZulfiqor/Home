using System;

class Program
{
    static int rec_func(int n, int sum = 0)
    {
        if (n == 0)
        {
            System.Console.WriteLine(sum);
            return 0;
        }
        sum += n;
        return rec_func(n - 1, sum);
    }
    static void Main(string[] args)
    {
        // int n = int.Parse(Console.ReadLine());
        // string s = Console.ReadLine();
        // string[] arr = s.Split(' ');
        // int[] nums = new int[n];
        // for (int i = 0; i < n; i++)
        // {
        //     nums[i] = int.Parse(arr[i]);
        // }
        // int max = int.MinValue;
        // for (int i = n - 1; i > 0; i--)
        // {
        //     if (max < nums[i])
        //     {
        //         max = nums[i];
        //     }
        // }
        // Console.WriteLine(max);
        int n = 8;
        System.Console.WriteLine(rec_func(n));

    }
}