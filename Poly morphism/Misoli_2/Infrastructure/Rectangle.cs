namespace Infrastructure;

public class Rectangle : Shape
{
    public override string Name(){
        return "Rectangle";
    }
    private double Width;
    private double Height;
    public Rectangle(double width, double Height)
    {
        this.Width = width;
        this.Height = Height;
    }
    public override double Area()
    {
        return Width * Height;
    }
    public override double Perimeter()
    {
        return 2 * (Width + Height);
    }
}
