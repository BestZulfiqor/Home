namespace Infrastructure;

public class Restaurant
{
    List<MenuItem> menuItems = new List<MenuItem>();
    List<Employee> employees = new List<Employee>();
    public void AddMenuItem(MenuItem item){
        menuItems.Add(item);
    }
    public void AssignEmployee(Employee employee)
    {
        employees.Add(employee);
    }
}
