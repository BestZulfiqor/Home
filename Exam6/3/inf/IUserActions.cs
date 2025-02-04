namespace UserLibrary;

public interface IUserActions
{
    void CreateUser(User user);
    void DeleteUser(int id);
    void ChangeRole(int id, Role newRole);
    void DisplayInfo();
}
