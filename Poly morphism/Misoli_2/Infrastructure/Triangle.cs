namespace Infrastructure;

public class Triangle : Shape
{
    private double a, b, c;

    public override double Area()
    {
        return Math.Max(a,Math.Max(b,c));
    }
     public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
}
