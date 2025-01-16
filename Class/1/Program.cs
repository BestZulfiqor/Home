using System;

class Student
{
	public string? name;
	public string? surname;
	public int age;
	public string? address;
	public int[] grades;
	public string GetInfo()
	{
		return $"fullname: {name} {surname} \nage: {age} \naddreess: {address}";
	}
	public string AvaregeOfGrades()
	{
		int sum = 0;
		for (int i = 0; i < grades.Length; i++)
		{
			sum += grades[i];
		}
		return $"Avarage: {sum / grades.Length}";
	}
}
class Program
{
	static void Main(string[] args)
	{
		Student student = new Student();
		student.name = "Zulfiqor";
		student.surname = "Alimamatov";
		student.age = 20;
		student.address = "Assadullo Gulomov";
		student.grades = new int[]{100,100,100,100};
		string info = student.GetInfo();
		string grades = student.AvaregeOfGrades();
		System.Console.WriteLine(info);
		System.Console.WriteLine(grades);
	}
}