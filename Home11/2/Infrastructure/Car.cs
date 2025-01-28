namespace Infrastructure;

public class Car : Transport
{
    public int Wheels { get; set; }
    public Car(string brand, string model, int capacity, int wheels) : base(brand, model,capacity)
    {
        this.Wheels = wheels;
    }
    public void Beep()
    {
        System.Console.WriteLine("Beep-Beep");
    }
    public new  void Info()
    {
        System.Console.WriteLine($"This is a Car \nBrand: {Brand}, Model: {Model}, Capacity: {Capacity}, Wheels: {Wheels}\n");
    }
}
