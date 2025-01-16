using System;
class Rectangle
{
	public int Width;
	public int Height;
	public string Color;
	public int GetArea()
	{
		return Height * Width;
	}
	public int GetPerimeter()
	{
		return 2 * (Height + Width);
	}
}

class Program
{
	static void Main(string[] args)
	{
		Rectangle rectangle = new Rectangle();
		rectangle.Width = int.Parse(Console.ReadLine());
		rectangle.Height = int.Parse(Console.ReadLine());
		rectangle.Color = "Green";
		int area = rectangle.GetArea();
		int perimeter = rectangle.GetPerimeter();
		System.Console.WriteLine(area + "\n" + perimeter);
	}
}