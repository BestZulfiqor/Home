using System;
using Infracstructure;

class Program
{
	static void Main(string[] args)
	{
		PhoneBook phoneBook = new();
		phoneBook.AddContact("Zulfiqor", "205221144");
		phoneBook.AddContact("Ahmadjon","888870709");
		// phoneBook.RemoveContact("Zulfiqor");
		phoneBook.FindPhone("Zulfiqor");
		phoneBook.ShowAll();
	}
}