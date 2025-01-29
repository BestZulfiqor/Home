using System.Globalization;

namespace Infrastructure;

public class Electronicks : Product
{
    private int _warrantyPeriodInMonths;
    private DateTime PubDay = DateTime.Now;
    public int WarrantyPeriodInMonths { get{return _warrantyPeriodInMonths;} set{_warrantyPeriodInMonths = value;} }
    public Electronicks(string name, double price, int quantity, int warrantyPeriodInMonths, DateTime pubday) : base(name, price, quantity)
    {
        PubDay = pubday;
        WarrantyPeriodInMonths = warrantyPeriodInMonths;
    }
    public void GetWarrantyStatus()
    {
        var garanty = PubDay.AddMonths(_warrantyPeriodInMonths);
        if (garanty > DateTime.Now)
        {
            System.Console.WriteLine("Гарантия активна");
        }
        else System.Console.WriteLine("Гарантия не активна");
    }
}
