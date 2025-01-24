using System;

class Program
{
	static int Sum(List<int> list)
	{
		int sum = 0;
		foreach (var item in list)
		{
			sum += item;
		}
		return sum;
	}
	static bool Check(List<int> list,int num){
		foreach (var item in list)
		{
			if (item == num)
			{
				return true;
			}
		}
		return false;
	}
	static List<int> Square(List<int> list){
		for (int i = 0; i < list.Count(); i++)
		{
			list[i] = list[i] * list[i];
		}
		return list;
	}
	static void Main(string[] args)
	{
		List<int> list = new List<int>() { 1, 21, 13, 54, 35 };
		int sum = Sum(list);
		System.Console.WriteLine(sum);
		
		// Misoli 2
		int n = int.Parse(Console.ReadLine());
		bool found = Check(list, n);
		System.Console.WriteLine(found);

		// Misoli 3
		list = Square(list);
		foreach (var item in list)
		{
			System.Console.Write($"{item} ");
		}
	}
}