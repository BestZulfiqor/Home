using System.Xml;

namespace inf;

public class AdminUser : User
{
    public override void DisplayInfo()
    {
        System.Console.WriteLine("Это админ");
    }
}
