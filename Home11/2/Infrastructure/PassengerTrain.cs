namespace Infrastructure;

public class PassengerTrain : Train
{
    public int Ticket { get; set; }
    public double Money { get; set; }
    public double PriceTicket { get; set; }
    public PassengerTrain(string brand, string model, int capacity, int vagon, int ticket, double priceTicket,double money = 0) : base(brand, model, capacity, vagon)
    {
        this.Ticket = ticket;
        this.Money = money;
        this.PriceTicket = priceTicket;
    }
    public void BuyTicket(int amount)
    {
        Ticket -= amount;
        Money += amount * PriceTicket;
        System.Console.WriteLine($"Ticket succesfully selled \nTickets: {Ticket} \t Money: {Money}\n");
    }
    public new void Info()
    {
        System.Console.WriteLine($"This is a PassengerTrain \nBrand: {Brand}, Model: {Model}, Capacity: {Capacity}, Tickets: {Ticket}, Tickect price: {PriceTicket}");
    }
}
