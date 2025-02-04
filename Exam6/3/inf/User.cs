using System.Text.RegularExpressions;

namespace UserLibrary;

public class User
{
    private static int counter = 1;
    public int ID { get; }
    public string Name { get; set; }
    private string email;
    public string Email
    {
        get => email;
        set
        {
            if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Invalid email format");
            email = value;
        }
    }
    public Role Role { get; set; }

    public User(string name, string email, Role role)
    {
        ID = counter++;
        Name = name;
        Email = email;
        Role = role;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}, Email: {Email}, Role: {Role.RoleName}");
    }
}
