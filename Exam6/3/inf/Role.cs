namespace UserLibrary;

public class Role
{
    public string RoleName { get; set; }
    public List<string> Permissions { get; set; } = new();

    public Role(string roleName, List<string> permissions)
    {
        RoleName = roleName;
        Permissions = permissions;
    }

    public List<string> GetPermissions() => Permissions;
}
