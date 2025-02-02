namespace inf;

public class Role
{
    public bool RoleName { get; set; }
    public List<string> Permission { get; set; }
    public void GetPermission()
    {
        foreach (var item in Permission)
        {
            System.Console.WriteLine(item + " ");
        }
    }
}
