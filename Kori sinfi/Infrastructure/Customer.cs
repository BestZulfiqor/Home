namespace Infrastructure;

public class Customer
{
    public string Name { get; set; }
    List<Order> OrderHistory = new();
    public Customer(string Name)
    {
        this.Name = Name;
    }
    public void MakeOrder(Order order){
        OrderHistory.Add(order);
    }
    public void ViewOrders(){
        System.Console.WriteLine("All orders");
        int i = 1;
        foreach (var avqot in OrderHistory)
        {
            foreach (var kola in avqot.Items)
            {
                System.Console.WriteLine($"{i}. Name: {kola.Name}, Price: {kola.Price}, Category: {kola.Category}");
                i++;
            }
        }
    }
}
