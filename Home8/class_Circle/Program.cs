using System;
class Circle{
	private double Radius;
	private double PI = 3.14159;
	public Circle(double radius){
		Radius = radius;
	}
	public Circle(){
		Radius = 0.0;
	}
	public void SetRadius(double radius){
		Radius = radius;
	}
	public double GetRadius(){
		return Radius;
	} 
	public double GetArea(){
		return PI * Radius * Radius;
	}
	public double GetDiameter(){
		return 2 * Radius;
	}
	public double GetCircumference(){
		return 2 * PI * Radius;
	}
}
class Program
{
	static void Main(string[] args)
	{
		Circle circle = new Circle(12.2);
		double radius = circle.GetRadius();
		double diameter = circle.GetDiameter();
		double area = circle.GetArea();
		double circumference = circle.GetCircumference();
		System.Console.WriteLine($"Radius: {radius}, Diameter: {diameter}, Area: {area}, Circumference: {circumference}");
	}
}