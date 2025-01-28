namespace Infrastructure;

public class Airplane : Transport
{
    protected int Wheels { get; set; }
    public Airplane(string brand, string model, int capacity, int wheels) : base(brand, model, capacity)
    {
        this.Wheels = wheels;
    }
    public new void Info()
    {
        System.Console.WriteLine($"This is a Airlane \nBrand: {Brand}, Model: {Model}, Capacity: {Capacity}\n");
    }
}
