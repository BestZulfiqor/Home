using System.Net.NetworkInformation;

namespace Infrastructure;

public class Circle : Shape
{
    public override string Name(){
        return "Circle";
    }
    private double Radius;
    private const double Pi = 3.14;
    public Circle(double Radius)
    {
        this.Radius = Radius;
    }
    public override double Area()
    {
        return Pi * Math.Pow(Radius, 2);
    }
    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}
