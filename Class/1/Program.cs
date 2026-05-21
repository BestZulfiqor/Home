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
        Student student = new Student
        {
            name = "Zulfiqor",
            surname = "Alimamatov",
            age = 20,
            address = "Assadullo Gulomov",
            grades = [100, 100, 100, 100]
        };
        string info = student.GetInfo();
		string grades = student.AvaregeOfGrades();
		Console.WriteLine(info);
		Console.WriteLine(grades);
	}
}