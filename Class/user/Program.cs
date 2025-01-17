using System;
class User{
	private string username;
	private string password;
	public string firstname;
	public string lastname;
	public string email;
	public void Register(){
		System.Console.Write("Set your firstname: ");
		firstname = Console.ReadLine();
		System.Console.Write("Set your lastname: ");
		lastname = Console.ReadLine();
		System.Console.Write("Set your email: ");
		email = Console.ReadLine();
		System.Console.Write("Set your username: ");
		username = Console.ReadLine();
		System.Console.Write("Set your password: ");
		password = Console.ReadLine();
		if (password.Length >= 8)
		{
			System.Console.WriteLine("You're succesfully registered!");
		}
		else System.Console.WriteLine("You're failed!");
	}
	public string Login(string username, string password){
		if (this.username == username && this.password == password){
			return "You'r logged succesfully!";
		}
		else return "If you don't have account please register!";
	}
	public string Logout(){
		System.Console.WriteLine("Do you really want to Log out? \n Yes: a \t No: x");
		char ch = char.Parse(Console.ReadLine());
		if (ch == 'a')
		{
			return "You're logged out succesfully!";
		}
		else if(ch == 'x'){
			return "You're not logged out:)";
		}
		return Logout();
	}
	public string ChangePassword(){
		System.Console.WriteLine("Let's change your password!");
		password = Console.ReadLine();
		if (password.Length >= 8)
		{
			return $"Your new password is {password}";
		}
		return ChangePassword();
	}
	public string GetFullInfo(){
		return $"FirstName: {firstname} \nLastName: {lastname} \nEmail: {email} \nUserName: {username} \nPassword: {password}";
	}
}
class Program
{
	static void Main(string[] args)
	{
		User user = new User();
		user.Register();
		string info = user.GetFullInfo();
		System.Console.WriteLine(info);
		string change = user.ChangePassword();
		info = user.GetFullInfo();
		System.Console.WriteLine(info);
		string logout = user.Logout();
		System.Console.WriteLine(logout);
	}
}