namespace Infrastructure;

public class Product
{
    private string Name = "John";
    private double Price;
    private int Quantity;
    public Product(string name, double price, int quantity)
    {
        SetName(name);
        SetPrice(price);
        SetQuantity(quantity);
    }
    public string GetName() => Name;
    public void SetName(string name)
    {
        if (name.Length > 2)
        {
            this.Name = name;
        }
    }
    public double GetPrice() => Price;
    public void SetPrice(double price)
    {
        if (price > 0)
        {
            this.Price = price;
        }
    }
    public double GetQuantity() => Quantity;
    public void SetQuantity(int quantity)
    {
        if (quantity > 0)
        {
            this.Quantity = quantity;
        }
    }
}
