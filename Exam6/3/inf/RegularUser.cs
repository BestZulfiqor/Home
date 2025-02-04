namespace UserLibrary;

public class RegularUser : User
{
    public RegularUser(string name, string email) 
        : base(name, email, new Role("Regular User", new List<string> { "View Info" })) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"[User] {Name} ({Email}) - ID: {ID}");
    }
}
