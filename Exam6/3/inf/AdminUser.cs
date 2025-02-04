namespace UserLibrary;

public class AdminUser : User
{
    public AdminUser(string name, string email) 
        : base(name, email, new Role("Administrator", new List<string> { "Manage Users", "Assign Roles" })) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[Admin] {Name} ({Email}) - ID: {ID}");
    }
}
