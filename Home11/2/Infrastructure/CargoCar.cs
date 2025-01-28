namespace Infrastructure;

public class CargoCar : Car
{
    public int Cargo { get; set; }
    public CargoCar(string brand, string model, int capacity, int wheels, int cargo) : base(brand, model, capacity, wheels)
    {
        this.Cargo = cargo;
    }
    public new void Info()
    {
        System.Console.WriteLine($"This is Cargocar \nBrand: {Brand}, Model: {Model}, Capacity: {Capacity}, Wheels: {Wheels}, Cargo: {Cargo}\n");
    }
    public new void Beep()
    {
        System.Console.WriteLine("Beep-Beep-Beep");
    }
}
