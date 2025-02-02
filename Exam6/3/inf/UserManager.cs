namespace inf;

public class UserManager : IUserActions
{
    List<User> users = new List<User>();
    public void CreateUser(User user)
    {
        users.Add(user);
        System.Console.WriteLine("Youre added used");
    }
    public void DeleteUser(int id)
    {
        foreach (var item in users)
        {
            if (item.ID == id)
            {
                users.Remove(item);
                System.Console.WriteLine($"Removed user with id: {id}");
                return;
            }
        }
        System.Console.WriteLine("User with id not found");
    }
    public void ChangeRole(int Id, bool role)
    {
        foreach (var item in users)
        {
            if (item.ID == Id)
            {
                item.Role = role;
            }
        }
    }
    public void DisplayInfo()
    {
        foreach (var item in users)
        {
            System.Console.WriteLine(item);
        }
    }
}
