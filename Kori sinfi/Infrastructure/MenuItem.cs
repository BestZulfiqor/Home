namespace Infrastructure;

public class MenuItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
    public MenuItem(string Name, double Price, string Category)
    {
        this.Name = Name;
        this.Price = Price;
        this.Category = Category;
    }
    public string GetDescription(){
        return $"{Name} - {Price} - {Category}";
    }
}
