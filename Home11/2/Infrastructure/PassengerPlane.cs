namespace Infrastructure;

public class PassengerPlane : Airplane
{
    public int Ticket { get; set; }
    public double Money { get; set; }
    public double PriceTicket { get; set; }
    public PassengerPlane(string brand, string model, int capacity, int wheels, int ticket, double priceTicket, double money = 0) : base(brand, model, capacity, wheels)
    {
        this.Ticket = ticket;
        this.PriceTicket = priceTicket;
        this.Money = money;
    }
    public void BuyTicket(int amount)
    {
        Ticket -= amount;
        Money += amount * PriceTicket;
        System.Console.WriteLine($"Ticket succesfully selled \nTickets: {Ticket} \t Money: {Money}\n");
    }
    public new void Info()
    {
        System.Console.WriteLine($"This is a Passengerplane \nBrand: {Brand}, Model: {Model}, Capacity: {Capacity}, Tickets: {Ticket}, Tickect price: {PriceTicket}");
    }
}
