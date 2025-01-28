namespace Infrastructure;

public class CargoPlane : Airplane
{
    public int Cargo { get; set; }
    public CargoPlane(string brand, string model, int capacity, int wheels, int cargo) : base(brand, model, capacity, wheels)
    {
        this.Cargo = cargo;
        this.Wheels = wheels;
    }
    public new void Info()
    {
        System.Console.WriteLine($"This is a CargoPlane \nBrand: {Brand}, Model: {Model}, Capacity: {Capacity}, Cargo: {Cargo}\n");
    }
    public void AddCargo(int cargo)
    {
        this.Cargo += cargo;
    }
}
