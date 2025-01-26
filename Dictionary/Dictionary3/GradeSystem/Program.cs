using System;
using System.Collections.Generic;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        var gradeSystem = new Grade();
        gradeSystem.AddGrade("Иван", 5);
        gradeSystem.AddGrade("Иван", 4);
        gradeSystem.AddGrade("Мария", 5);

        gradeSystem.PrintAverage("Иван");

        gradeSystem.PrintAllStudents();
    }
}