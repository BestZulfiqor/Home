namespace inf;

public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }
    public User()
    {
        ID++;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}, Email: {Email}, Role: {Role.RoleName}");
    }
}
