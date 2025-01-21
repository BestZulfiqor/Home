using System;
class Teacher
{
	string fullName;
	string subject;
	int experience;
	public void Tech()
	{
		System.Console.WriteLine($"{fullName} is teaching {subject}");
	}
	public void SetExperience(int years)
	{
		experience = years;
	}
	public int GetExperience()
	{
		return experience;
	}
	public Teacher()
	{

	}
	public Teacher(string fullName, string subject)
	{
		this.fullName = fullName;
		this.subject = subject;
	}
	public Teacher(string fullName, string subject, int experience)
	{
		this.fullName = fullName;
		this.subject = subject;
		this.experience = experience;
	}
}
class Program
{
	static void Main(string[] args)
	{
		Teacher teacher = new Teacher("Zulfiqor", "Math", 20);
		teacher.Tech();
		teacher.SetExperience(25);
		int experience = teacher.GetExperience();
		System.Console.WriteLine("Years of experience: " + experience);
	}
}