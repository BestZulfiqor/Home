namespace Infrastructure;

public class RegularUser : User
{
    public override void ViewActivity()
    {
        System.Console.WriteLine("Regular user activity");
    }
}
