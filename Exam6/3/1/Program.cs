using System;
using UserLibrary;

class Program
{
    static void Main()
    {
        UserManager userManager = new();
        while (true)
        {
            Console.WriteLine("\n1. Add User");
            Console.WriteLine("2. Remove User");
            Console.WriteLine("3. Change Role");
            Console.WriteLine("4. Display Users");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter role (Admin/Regular): ");
                    string roleInput = Console.ReadLine().ToLower();

                    User newUser = roleInput == "admin"
                        ? new AdminUser(name, email)
                        : new RegularUser(name, email);

                    userManager.CreateUser(newUser);
                    break;

                case "2":
                    Console.Write("Enter user ID to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                        userManager.DeleteUser(deleteId);
                    else
                        Console.WriteLine("Invalid ID format.");
                    break;

                case "3":
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

                case "4":
                    userManager.DisplayInfo();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}
