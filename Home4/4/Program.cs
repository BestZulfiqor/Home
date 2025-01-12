using System;

class Program
{
	static void GradeStats(int[] grades){
		int two = 0, three = 0, four = 0, five = 0;
		foreach (int grade in grades){
			if (grade == 2){
				two++;
			}
			else if (grade == 3){
				three++;
			}
			else if (grade == 4){
				four++;
			}
			else if (grade == 5){
				five++;
			}
		}
		System.Console.WriteLine("5: " + five + " шт.");
		System.Console.WriteLine("4: " + four + " шт.");
		System.Console.WriteLine("3: " + three + " шт.");
		System.Console.WriteLine("2: " + two + " шт.");
	}
	static void Main(string[] args)
	{
		int[] nums = {5, 4, 5, 3, 5, 4};
		 GradeStats(nums);
	}
}