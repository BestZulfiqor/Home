using System.Security.Cryptography;
using Infrastructure;

class Program
{
	static void Main(string[] args)
	{
		Student student = new Student();
		student.Name = "Zulfiqor";
		student.Age = 20;
		student.Grade = new int[] { 3, 3, 4, 4 };
		Student student1 = new Student();
		student1.Name = "Ahmad";
		student1.Age = 26;
		student1.Grade = new int[] { 5, 5, 5, 5 };
		Student student2 = new Student();
		student2.Name = "Firdavs";
		student2.Age = 19;
		student2.Grade = new int[] { 3, 2, 4, 5 };
		StudentManager studentManager = new StudentManager();
		studentManager.AddStudent(student);
		studentManager.AddStudent(student1);
		studentManager.AddStudent(student2);
		// studentManager.RemoveStudent(2);
		studentManager.ShowInfo();
		// studentManager.FindByName("Zul");
		// studentManager.GetExcellentStudents();
		studentManager.GetAverageAge();
		studentManager.FindYoungestStudent();
		studentManager.GetOldestStudent();
		studentManager.SortByAge();
		studentManager.GetGradeStatistics();
	}
}