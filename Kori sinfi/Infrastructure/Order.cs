namespace Infrastructure;

public class Order
{
    public int OrderId = 1;
    public List<MenuItem> Items = new List<MenuItem>();
    public double TotalMenu { get; set; }
    public void AddItem(MenuItem menuItem){
        Items.Add(menuItem);
    }
    public void RemoveItem(MenuItem menuItem){
        Items.Remove(menuItem);
    }
    public void CalculateTotal(){
        double total = 0;
        foreach (var item in Items)
        {
            total += item.Price;
        }
        TotalMenu = total;
        System.Console.WriteLine("Вся сумма заказа: " + TotalMenu);
    }
    public Order()
    {
        OrderId++;
    }
}
