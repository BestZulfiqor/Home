using System;
class Student
{
    private string Name;
    private int[] Grades = new int[5];
    public Student(string name)
    {
        System.Console.WriteLine("Создаем студента...");
        Name = name;
    }
    public void AddGrade()
    {
        System.Console.WriteLine("Добавляем оценки:");
        string s = Console.ReadLine();
        string[] ss = s.Split();
        for (int i = 0; i < ss.Length; i++)
        {
            Grades[i] = int.Parse(ss[i]);
        }
    }
    public double GetAverage()
    {
        double sum = 0;
        for (int i = 0; i < Grades.Length; i++)
        {
            sum += Grades[i];
        }
        double average = sum / Grades.Length;
        return average;
    }
    public void ShowGrades()
    {
        System.Console.WriteLine("Информация о студенте:");
        System.Console.WriteLine($"Студент: {Name}");
        System.Console.Write($"Оценки: ");
        for (int i = 0; i < Grades.Length - 1; i++)
        {
            System.Console.Write(Grades[i] + ", ");
        }
        System.Console.WriteLine(Grades[Grades.Length - 1]);
        System.Console.WriteLine($"Средний балл: {GetAverage()}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Иван");
        student.AddGrade();
        student.GetAverage();
        student.ShowGrades();
    }
}