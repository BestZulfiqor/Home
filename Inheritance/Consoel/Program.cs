using System;
class Person{
    protected int Age { get; set; }
    public void Greet(){
        System.Console.WriteLine("Hello");
    }
    public void SetAge(int age){
        Age = age;
    }
}
class Student : Person{
    public void Study(){
        System.Console.WriteLine("I'm studying");
    }
    public void ShowAge(){
        System.Console.WriteLine($"My age is {Age} years old");
    }
}
class Teacher : Person{
    public void Explain(){
        System.Console.WriteLine("I'm explaining");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Greet();
        Student student = new Student();
        student.SetAge(20);
        student.Greet();
        student.ShowAge();
        Teacher teacher = new Teacher();
        teacher.SetAge(30);
        teacher.Greet();
        teacher.Explain();
    }
}