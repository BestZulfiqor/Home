using System;
class Student
{
	string Name;
	int Id;
	int Age;
	double Avarage;
	public Student(int id, string name, int age, double avarageGrade)
	{
		Name = name;
		Id = id;
		Age = age;
		Avarage = avarageGrade;
	}
	public void GetInfo()
	{
		Console.WriteLine($"Id: {Id}; Name: {Name}, Age: {Age}, Avarage Grade: {Avarage}");
	}
	public bool IsExcellent()
	{
		return Avarage > 4.0;
	}
}
class Program
{
	static void Main(string[] args)
	{
		Student student = new Student(1, "Shahrom", 20, 4.5);
		student.GetInfo();
		Console.WriteLine(student.IsExcellent());
	}
}