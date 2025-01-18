using System;
class Book{
	private string Title;
	private string Author;
	private int Year;
	public Book(string title, string author, int year){
		Title = title;
		Author = author;
		Year = year;
	}
	public void GetInfo(){
		System.Console.WriteLine($"Title: {Title}, Муаллиф: {Author}, Соли нашр: {Year}");
	}
	public bool IsPublishedRecently(){
		if (Year > 2010)
		{
			return true;
		}
		return false;
	}
}
class Program
{
	static void Main(string[] args)
	{
		Book book = new Book(title: "About life",author:"Alimamatov Zulfiqor", 2012);
		book.GetInfo();
		bool published = book.IsPublishedRecently();
		System.Console.WriteLine(published);
	}
}