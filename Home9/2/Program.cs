using System;
class User{
	string FirstName;
	string LastName;
	string Username;
	string Password;
	string[] users = new string[5];
	public User(string firstName, string lastName, string username, string password){
		this.FirstName = firstName;
		this.LastName = lastName;
		this.Username = username;
		this.Password = password;
	}
	public void GetInfo(){
		Console.WriteLine("First Name: " + FirstName);
		Console.WriteLine("Last Name: " + LastName);
		Console.WriteLine("Username: " + Username);
		Console.WriteLine("Password: " + Password);
	}
	public void Login(string username, string password){
		if (username == Username && password == Password){
			System.Console.WriteLine($"Login successful! Welcome, Mr./Ms. {FirstName} {LastName}");
		}
		else System.Console.WriteLine("Login failed!");
	}

}
class Program
{
	static void Main(string[] args)
	{
		User user = new User("Zulfiqor", "Alimamatov", "zulfiqor", "1234");
		while (true)
		{
			System.Console.Write("Enter your username: ");
			string username = Console.ReadLine();
			System.Console.Write("Enter your password: ");
			string password = Console.ReadLine();
			user.Login(username, password);
		}
	}
}