using System;
class User{
	public string FirstName;
	public string LastName;
	public string Username;
	public string Password;
	private bool IsLoggedIn;
	public void Login(string username, string password){
		if (username == Username && password == Password)
		{
			System.Console.WriteLine("User logged in successfully");
			IsLoggedIn = true;
		}
		else System.Console.WriteLine("Your password or username is incorrect");
	}
	public void Logout(){
		IsLoggedIn = false;
	}
	public string GetFullInfo(){
		return $"{FirstName} {LastName} - {IsLoggedIn}";
	}
}
class Program
{
	static void Main(string[] args)
	{
		User user = new User();
		user.FirstName = "Zulfiqor";
		user.LastName = "Alimamatov";
		user.Username = "Origin";
		user.Password = "********";
		user.Login(user.Username, user.Password);
		string info = user.GetFullInfo();
		System.Console.WriteLine(info);
		user.Logout();
	}
}