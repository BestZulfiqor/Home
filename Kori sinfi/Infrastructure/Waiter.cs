namespace Infrastructure;

public class Waiter : Employee
{
    public override void PerformDuty()
    {
        System.Console.WriteLine("Waiter takes order");
    }
}
