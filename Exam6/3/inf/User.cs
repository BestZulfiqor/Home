namespace inf;

public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool Role { get; set; }
    public User()
    {
        ID++;
    }
    public virtual void DisplayInfo()
    {
        System.Console.WriteLine(Name + " " + Email + " " + Role);
    }
}
