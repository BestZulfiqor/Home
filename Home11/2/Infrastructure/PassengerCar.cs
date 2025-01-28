using System.Data.SqlTypes;

namespace Infrastructure;

public class PassengerCar : Car
{
    public double Money { get; set; }
    public PassengerCar(string brand, string model, int capacity, int wheels, double money = 0) : base(brand, model, capacity, wheels)
    {
        this.Money = money;
    }
    public void AddClient()
    {
        Money += 2.5;
        System.Console.WriteLine($"Succesfully add client \nMoney: {Money}\n");
    }
}
