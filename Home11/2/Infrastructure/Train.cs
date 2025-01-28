namespace Infrastructure;

public class Train : Transport
{
    protected int Vagon { get; set; }
    public Train(string brand, string model, int capacity, int vagon) : base(brand, model, capacity)
    {
        this.Vagon = vagon;
    }
    public new void Info()
    {
        System.Console.WriteLine($"This is a Train \nBrand: {Brand}, Model: {Model}, Capacity: {Capacity}, Vagon: {Vagon}\n");
    }
}
