using System;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, string position, decimal salary)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
    }

    
    public Employee() { }
}

class Departament
{
    public string Name { get; set; }
    int index = 0;
    public Employee[] Employees { get; }

    public Departament(string name, int size)
    {
        Name = name;
        Employees = new Employee[size];
    }

    public void AddEmployee(Employee employee)
    {
        if (index < Employees.Length)
        {
            Employees[index] = employee;
            index++;
        }
        else
        {
            Console.WriteLine("Отдел заполнен!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee(1, "Алимаматов Зулфикор", "Программист", 10000m);
        Departament Development = new Departament("Development", 1);
        Development.AddEmployee(emp1);
		System.Console.WriteLine("Сотрудники отдела Development:");
        foreach (var employee in Development.Employees)
        {
            if (employee != null)
            {
                Console.WriteLine($"ID: {employee.Id}, Имя: {employee.Name}, Должность: {employee.Position}, Зарплата: {employee.Salary}");
            }
        }
        Employee emp2 = new Employee(2, "Кадамов Шоир", "Айтишник", 20000m);
		Departament Marketing = new Departament("Marketing", 1);

        Marketing.AddEmployee(emp2);
		System.Console.WriteLine("Сотрудники отдела Marketing:");
        foreach (var employee in Marketing.Employees)
        {
            if (employee != null)
            {
                Console.WriteLine($"ID: {employee.Id}, Имя: {employee.Name}, Должность: {employee.Position}, Зарплата: {employee.Salary}");
            }
        }
    }
}
