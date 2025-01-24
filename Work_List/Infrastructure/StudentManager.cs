using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Infrastructure;

public class StudentManager
{
	List<Student> Students = new();
	int id = 1;
	public void AddStudent(Student student)
	{
		student.Id = id;
		Students.Add(student);
		Console.Write($"Студент успешно добавлен: \nId: {id}, \tИмя: {student.Name}, \tВозраст: {student.Age}, \tОценки: ");
		Console.WriteLine(string.Join(", ", student.Grade));
		id++;
		Console.WriteLine();
	}
	public void RemoveStudent(int id)
	{
		foreach (var student in Students)
		{
			if (student.Id == id)
			{
				Students.Remove(student);
				Console.WriteLine($"Student with Id: {id} was Removed!\n");
				return;
			}
		}
		Console.WriteLine($"Student with Id: {id} don't found!\n");
	}
	public void ShowInfo()
	{
		Console.WriteLine("Список всех студентов:");
		foreach (var student in Students)
		{
			Console.Write($"{student.Id}. {student.Name} ({student.Age}) - Оценки: ");
			Console.WriteLine(string.Join(", ", student.Grade));
			Console.WriteLine();
		}
	}
	public void FindByName(string name)
	{
		Console.WriteLine($"Найденные студенты по запросу '{name}':");
		foreach (var student in Students)
		{
			if (student.Name.ToLower().Contains(name.ToLower()))
			{
				Console.Write($"Id: {student.Id}, {student.Name} ({student.Age} лет) - Grades: ");
				Console.WriteLine(string.Join(", ", student.Grade));
				Console.WriteLine();
			}
		}
	}
	public void GetExcellentStudents()
	{
		Console.WriteLine("Список отличников: ");
		foreach (var student in Students)
		{
			if (student.Grade.Contains(5))
			{
				int count = 0;
				foreach (var grade in student.Grade)
				{
					if (grade == 5)
					{
						count++;
					}
				}
				if (count == student.Grade.Count())
				{
					Console.Write($"{student.Id}. {student.Name} ({student.Age} лет) - Все оценки: ");
					Console.WriteLine(string.Join(", ", student.Grade));
				}
				else
				{
					Console.Write($"{student.Id}. {student.Name} ({student.Age} лет) - Есть оценки: ");
					Console.WriteLine(string.Join(", ", student.Grade));
				}
			}
		}
		Console.WriteLine();
	}
	public void FindYoungestStudent()
	{
		string name = "";
		int age = 199;
		foreach (var student in Students)
		{
			if (student.Age < age)
			{
				age = student.Age;
				name = student.Name;
			}
		}
		Console.WriteLine($"Самый молодой студент: {name} ({age} лет)");
	}
	public void GetOldestStudent()
	{
		string name = "";
		int age = 0;
		foreach (var student in Students)
		{
			if (student.Age > age)
			{
				age = student.Age;
				name = student.Name;
			}
		}
		Console.WriteLine($"Самый взрослый студент: {name} ({age} лет)\n");
	}
	public void GetAverageAge()
	{
		int sum = 0;
		foreach (var age in Students)
		{
			sum += age.Age;
		}
		Console.WriteLine($"Средний возраст студентов: {sum / Students.Count} лет\n");
	}
	public void SortByAge()
	{
		Students.Sort((x, y) => x.Age.CompareTo(y.Age));
		Console.WriteLine("Студенты по возрасту:");
		foreach (var student in Students)
		{
			Console.WriteLine($"{student.Id}. {student.Name} ({student.Age} лет)");
		}
		Console.WriteLine();
	}
		public void GetGradeStatistics()
	{
		Console.WriteLine("Статистика оценок:");
		int five = 0, four = 0, three = 0, two = 0;
		foreach (var student in Students)
		{
			bool Five = false, Four = false, Three = false, Two = false;
			foreach (var grade in student.Grade)
			{
				switch (grade)
				{
					case 5:
						Five = true;
						break;
					case 4:
						Four = true;
						break;
					case 3:
						Three = true;
						break;
					case 2:
						Two = true;
						break;
				}
			}
			if (Five) five++;
			if (Four) four++;
			if (Three) three++;
			if (Two) two++;
		}
		Console.WriteLine($"Оценка 5: {five} студента");
		Console.WriteLine($"Оценка 4: {four} студента");
		Console.WriteLine($"Оценка 3: {three} студента");
		Console.WriteLine($"Оценка 2: {two} студента");
	}
}