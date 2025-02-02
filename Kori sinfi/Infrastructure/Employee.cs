namespace Infrastructure;

public abstract class Employee
{
    public string Name { get; set; }
    public string Role { get; set; }
    public abstract void PerformDuty();
}
