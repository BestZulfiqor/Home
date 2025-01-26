using System.Data;

namespace Infrastructure;

public class Grade
{
    Dictionary<string, List<int>> grades = new();

    public void AddGrade(string name, int grade)
    {
        if (!grades.ContainsKey(name))
        {
            grades[name] = new List<int>();
        }
        grades[name].Add(grade);
        Console.WriteLine($"Оценки {name}: {string.Join(", ", grades[name])}\n");
    }

    public void PrintAverage(string name)
    {
        if (grades.ContainsKey(name))
        {
            double average = 0;
            foreach (var grade in grades[name])
            {
                average += grade;
            }
            average /= grades[name].Count;
            Console.WriteLine($"Средний балл {name}: {average}");
        }
        else
        {
            Console.WriteLine($"Студент {name} не найден.");
        }
        Console.WriteLine();
    }

    public void PrintAllStudents()
    {
        Console.WriteLine("Все студенты:");
        foreach (var student in grades)
        {
            double average = 0;
            foreach (var grade in student.Value)
            {
                average += grade;
            }
            average /= student.Value.Count;
            Console.WriteLine($"{student.Key}: средний балл - {average}");
        }
        Console.WriteLine();
    }
}