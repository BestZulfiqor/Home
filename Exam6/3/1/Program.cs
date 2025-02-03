using System;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using inf;

class Program
{
    static void Main(string[] args)
    {
        UserManager userManager = new UserManager();
        while (true)
        {
            System.Console.WriteLine("1. Add");
            System.Console.WriteLine("2. Remove");
            System.Console.WriteLine("3. ChangeRole");
            System.Console.WriteLine("4. Display list of users");
            System.Console.WriteLine("5. Exit program");
            char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case '1':
                    System.Console.WriteLine("Add User");
                    User user1 = new User();
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();
                    System.Console.Write("Email: ");
                    string Email = Console.ReadLine();
                    System.Console.Write("Role: ");
                    bool role = bool.Parse(Console.ReadLine());
                    userManager.CreateUser(user1);
                    break;
                case '2':
                    System.Console.Write("Delete user \nEnter id: ");
                    userManager.DeleteUser(int.Parse(Console.ReadLine()));
                    break;
                case '3':
                    Console.Write("Enter user ID: ");
                    if (!int.TryParse(Console.ReadLine(), out int userId))
                    {
                        Console.WriteLine("Invalid ID format.");
                        break;
                    }
                    Console.Write("Enter new role (Admin/Regular): ");
                    string newRoleInput = Console.ReadLine().ToLower();

                    Role newRole = newRoleInput == "admin"
                        ? new Role("Administrator", new List<string> { "Manage Users", "Assign Roles" })
                        : new Role("Regular User", new List<string> { "View Info" });
                    userManager.ChangeRole(userId, newRole);
                    break;
                case '4':
                    System.Console.WriteLine("All users");
                    userManager.DisplayInfo();
                    break;
                case '5':
                    return;
                default:
                    break;
            }

        }
    }
}