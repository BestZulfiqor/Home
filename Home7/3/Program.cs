using System;
class Author{
	public string name;
	public int age;
	public string nationality;
	public string GetName(){
		return name;
	}
	public int GetAge(){
		return age;
	}
	public string GetNationality(){
		return nationality;
	}
	public void Introduce(){
		System.Console.WriteLine($"My name is: {name}. I am {age} years old. I am from {nationality}.");
	}
	public int Celebrate(){
		return age+=1;
	}
}
class Program
{
	static void Main(string[] args)
	{
		Author author = new Author();
		author.name = "Zulfiqor";
		string name = author.GetName();
		author.nationality = "Tajikistan";
		string nationality = author.GetNationality();
		author.age = 20;
		int age = author.GetAge();
		author.Introduce();
		System.Console.WriteLine(age);
		age = author.Celebrate();
		System.Console.WriteLine(age);

	}
}