namespace ClassLibrary;

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public string Type { get; set; }
    public Car(string brand, string model, int year, double price, string type)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        Type = type;
    }
}