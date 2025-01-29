using System.Data.SqlTypes;

namespace Infrastructure;

public class Food : Product
{
    private DateTime _expirationDate;
    public DateTime ExpirationDate { get{return _expirationDate;} set{_expirationDate = value;} }
    public Food(string name, double price, int quantity, DateTime expirationDate) : base(name, price, quantity) 
    {
        _expirationDate = expirationDate;
    }
    public bool IsExpired()
    {
        DateTime dateTime = DateTime.Now;
        if (_expirationDate > dateTime)
        {
            return true;
        }
        return false;
    }
}   
