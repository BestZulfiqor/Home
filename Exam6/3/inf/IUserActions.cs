namespace inf;

public interface IUserActions
{
    void CreateUser(User user);
    void DeleteUser(int id);
    void ChangeRole(int Id, bool role);
    void DisplayInfo();
}
