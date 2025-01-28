namespace Infrastructure;

public class SmartPhone : Computer
{
    public int Battery { get; set; }
    public SmartPhone(string brand, string model, int year, int battery = 100) : base(brand, model, year)
    {
        Battery = battery;
    }
    public void ChargeBattery()
    {
        Battery = 100;
        Console.WriteLine("Battery is charging...");
    }
    public void TurnOnFlashlight()
    {
        Console.WriteLine("Flashlight is turning on...");
    }
    public void TurnOffFlashlight()
    {
        Console.WriteLine("Flashlight is turning off...");
    }
}
