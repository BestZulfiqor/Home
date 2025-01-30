using System;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        
        Rectangle rectangle = new Rectangle(6,4);
        
        Square square = new Square(3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);
        foreach (var item in shapes)
        {
            System.Console.WriteLine($"{item.Name()}: Area = {item.Area()}, Perimeter: {item.Perimeter()}");
        }
    }
}