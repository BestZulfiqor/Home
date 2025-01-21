using System;
class Student
{
	string fullName;
	int age;
	int grade;
	public void Study()
	{
		System.Console.WriteLine($"{fullName} is studying.");
	}
	public void SetGrade(int newGrade)
	{
		grade = newGrade;
	}
	public int GetGrade()
	{
		return grade;
	}
	public Student(string fullName, int age, int grade)
	{
		this.fullName = fullName;
		this.age = age;
		this.grade = grade;
	}
	public Student(string fullName, int age)
	{
		this.fullName = fullName;
		this.age = age;
	}
	public Student(){}

}
class Program
{
	static void Main(string[] args)
	{
		Student student = new Student("Zulfiqor", 20, 5);
		student.Study();
		student.SetGrade(4);
		int grade = student.GetGrade();
		System.Console.WriteLine(grade);
	}
}