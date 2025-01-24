using System;
using System.Collections.Generic;

class Program
{
    static List<int> RemoveEven(List<int> list)
    {
        List<int> nums = new List<int>();
        foreach (var item in list)
        {
            if (item % 2 != 0)
            {
                nums.Add(item);
            }
        }
        return nums;
    }
    static List<int> Duclicate(List<int> list1, List<int> list2)
    {
        List<int> nums = new List<int>();
        for (int i = 0; i < list1.Count(); i++)
        {
            bool found = true;
            for (int j = 0; j < list2.Count(); j++)
            {
                if (list1[i] == list2[i])
                {
                    found = false;
                }
            }
            if (found)
            {
                nums.Add(list1[i]);
            }
        }
        return nums;
    }
    static void Main(string[] args)
    {
        // Misoli 1
        // List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        // nums = RemoveEven(nums);
        // System.Console.WriteLine(string.Join(", ", nums));

        // Misoli 2
        // List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
        // List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
        // List<int> nums3 = Duclicate(nums1, nums2);
        // System.Console.WriteLine(string.Join(", ", nums3));

        // Misoli 3
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        System.Console.WriteLine($"Max: {nums.Max()}, Min: {nums.Min()}");
    }
}