namespace UserLibrary;

public class UserManager : IUserActions
{
    private List<User> users = new();

    public void CreateUser(User user)
    {
        users.Add(user);
        Console.WriteLine($"User {user.Name} added.");
    }

    public void DeleteUser(int id)
    {
        var user = users.FirstOrDefault(u => u.ID == id);
        if (user != null)
        {
            users.Remove(user);
            Console.WriteLine($"User {id} removed.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void ChangeRole(int id, Role newRole)
    {
        var user = users.FirstOrDefault(u => u.ID == id);
        if (user != null)
        {
            user.Role = newRole;
            Console.WriteLine($"User {id} role changed to {newRole.RoleName}.");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    public void DisplayInfo()
    {
        foreach (var user in users)
            user.DisplayInfo();
    }
}
