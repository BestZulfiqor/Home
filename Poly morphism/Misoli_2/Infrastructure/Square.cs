namespace Infrastructure;

public class Square : Shape
{
    public override string Name(){
        return "Square";
    }
    private double width;
    public Square(double width)
    {
        this.width = width;
    }
    public override double Area()
    {
        return width* width;
    }
    public override double Perimeter()
    {
        return 4 * width;
    }
}
