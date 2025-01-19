using System;
class Book{
	public string Title;
		private string Author;
		private int Year;
		public Book(string title, string author, int year){
			System.Console.WriteLine("Создаем книгу...");
			Title = title;
			Author = author;
			Year = year;
		}
		public void ShowInfo(){
			System.Console.WriteLine("Информация о книге:");
			System.Console.WriteLine($"Название: {Title}");
			System.Console.WriteLine($"Автор: {Author}");
			System.Console.WriteLine($"Год издания: {Year}");
		}
		public bool IsNewBook(int year){
			if (1800 < year)
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
		Book book = new Book("Война и мир", "Толстой",1869);
		book.ShowInfo();
		if(book.IsNewBook(1869)){
			System.Console.WriteLine("Эта книга издана позже 1800 года? Да");
		}
		else
			System.Console.WriteLine("Эта книга издана позже 1800 года? Нет");
	}
}