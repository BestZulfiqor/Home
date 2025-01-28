namespace Infrastructure;

public class Computer
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public Computer(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }
    public void TurnOn()
    {
        Console.WriteLine("Computer is turning on...");
    }
    public void TurnOff()
    {
        Console.WriteLine("Computer is turning off...");
    }
}
