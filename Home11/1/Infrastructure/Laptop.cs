namespace Infrastructure;

public class Laptop : Computer
{
    public int Battery { get; set; }
    public Laptop(string brand, string model, int year, int battery = 100) : base(brand, model, year)
    {
        Battery = battery;
    }
    public void ChargeBattery()
    {
        Battery = 100;
        Console.WriteLine("Battery is charging...");
    }
    public void TurnOnKeyboardColors()
    {
        Console.WriteLine("Keyboard colors are turning on...");
    }
    public void TurnOffKeyboardColors()
    {
        Console.WriteLine("Keyboard colors are turning off...");
    }
}
