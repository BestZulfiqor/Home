using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<List<int>> FindSublists(List<int> list, int length)
    {
        List<List<int>> sublists = new List<List<int>>();
        for (int i = 0; i <= list.Count - length; i++)
        {
            List<int> sublist = list.GetRange(i, length);
            sublists.Add(sublist);
        }
        return sublists;
    }

    static void Main(string[] args)
    {
        // Misoli 1
        // List<int> nums1 = Console.ReadLine().Split().Select(int.Parse).ToList();
		// int length = int.Parse(Console.ReadLine());
        // List<List<int>> sublists = FindSublists(nums1, length);
        // foreach (var item in sublists)
        // {
        //     Console.WriteLine(string.Join(", ", item));
        // }

        // Misoli 2
        
    }
}