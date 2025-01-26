namespace Infracstructure;

public class PhoneBook
{
	Dictionary<string, string> phoneBook = new();
	public void AddContact(string Name, string phone){
		phoneBook.Add(Name, phone);
		Console.WriteLine($"Succesfully added!\n{Name} to {phone}");
		System.Console.WriteLine();
	}
	public void RemoveContact(string Name){
		phoneBook.Remove(Name);
		Console.WriteLine($"Succesfully removed! {phoneBook} to {Name}");
		System.Console.WriteLine();
	}
	public void FindPhone(string Name)
	{
		if (phoneBook.ContainsKey(Name))
		{
			Console.WriteLine($"Phone number of {Name} is {phoneBook[Name]}");
		}
		else
		{
			Console.WriteLine("Contact not found!");
		}
	}
	public void ShowAll()
	{
		int Id = 1;	
		foreach (var item in phoneBook)
		{
			Console.WriteLine($"{Id}. Name: {item.Key} Phone: {item.Value}");
			Id++;
		}
	}
}
