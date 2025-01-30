namespace Infrastructure;

public class Shape
{
    public virtual string Name() => "";
    public virtual double Area(){
        return 0;
    }
    public virtual double Perimeter(){
        return 0;
    }
}
