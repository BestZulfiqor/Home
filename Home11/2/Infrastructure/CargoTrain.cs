namespace Infrastructure;

public class CargoTrain : Train
{
    public int Cargo { get; set; }
    public CargoTrain(string brand, string model, int capacity, int vagon, int cargo) : base(brand, model, capacity, vagon)
    {
        this.Cargo = cargo;
    }
    public new void Info()
    {
        System.Console.WriteLine($"This is a CargoPlane \nBrand: {Brand}, Model: {Model}, Capacity: {Capacity}, Vagon: {Vagon}, Cargo: {Cargo}\n");
    }
    public void AddCargo(int cargo)
    {
        this.Cargo += cargo;
    }
}
