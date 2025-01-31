using System.Runtime.CompilerServices;

namespace Infrastructure;

public class TaskList
{
    List<Task> tasks = new List<Task>();
    List<Category> categories = new List<Category>();

    public void AddTask(Task task)
    {
        this.tasks.Add(task);
    }
    public void RemoveTask(string title)
    {
        foreach (var item in tasks)
        {
            if (item.Title == title)
            {
                tasks.Remove(item);
                System.Console.WriteLine($"Задача \"{item.Title}\" удалена\n");
                break;
            }
        }
    }
    public void ShowAllTasks()
    {
        System.Console.WriteLine("Список всех задач:");
        int i = 1;
        foreach (var item in tasks)
        {
            Console.WriteLine($"{i}. Задача {item.Title} - Описание {item.Description}");
            i++;
        }
        System.Console.WriteLine();
    }
    public void MarkAsCompleted(string title)
    {
        foreach (var item in tasks)
        {
            if (item.Title == title)
            {
                item.IsCompleted = true;
                System.Console.WriteLine($"Задача \"{item.Title}\" отмечена как выполненная\n");
                break;
            }
        }
    }
    public List<Task> GetCompletedTasks()
    {
        List<Task> taks = new List<Task>();
        foreach (var item in tasks)
        {
            if (item.IsCompleted)
            {
                taks.Add(item);
            }
        }
        return taks;
    }
    public List<Task> GetUnCompletedTasks()
    {
        List<Task> taks = new List<Task>();
        foreach (var item in tasks)
        {
            if (!item.IsCompleted)
            {
                taks.Add(item);
            }
        }
        return taks;
    }
    public Task FindByTitle(string title)
    {
        foreach (var item in tasks)
        {
            if (item.Title == title)
            {
                return item;
            }
        }
        Task taks = new Task();
        return taks;
    }
    public List<Task> FindByDescription(string description)
    {
        List<Task> items = new List<Task>();
        foreach (var item in tasks)
        {
            if (item.Description == description)
            {
                items.Add(item);
            }
        }
        return items;
    }
    public void AddCategory(string name, string description)
    {
        Category category = new Category();
        category.Name = name;
        category.Description = description;
        categories.Add(category);
    }
    public void RemoveCategory(string name)
    {
        foreach (var item in categories)
        {
            if (item.Name == name)
            {
                categories.Remove(item);
                Console.WriteLine($"Категория \"{item.Name}\" удалена\n");
                break;
            }
        }
    }
    public void ShowCategories()
    {
        Console.WriteLine("Список категорий:");
        int i = 1;
        foreach (var item in categories)
        {
            Console.WriteLine($"{i}. {item.Name} - {item.Description}");
            i++;
        }
        Console.WriteLine();
    }
    public List<Task> FindTasksByCategory(string categoryName)
    {
        List<Task> items = new List<Task>();
        foreach (var item in tasks)
        {
            if (item.CategoryName == categoryName)
            {
                items.Add(item);
            }
        }
        return items;
    }
    public void ShowTasksByCategory(string categoryName){
        List<Task> items = FindTasksByCategory(categoryName);
        Console.WriteLine($"Список задач в категории \"{categoryName}\":");
        int i = 1;
        foreach (var item in items)
        {
            Console.WriteLine($"{i}. {item.Title} - {item.Description}");
            i++;
        }
        Console.WriteLine();
    }
    public int GetTotalTasks(){
        return tasks.Count;
    }
    public int GetCompletedTasksCount(){
        int count = 0;
        foreach (var item in tasks)
        {
            if (item.IsCompleted)
            {
                count++;
            }
        }
        return count;
    }
    public void UpdateTaskTitle(string oldTitle, string newTitle){
        foreach (var item in tasks)
        {
            if (item.Title == oldTitle)
            {
                item.Title = newTitle;
                Console.WriteLine($"Задача \"{oldTitle}\" переименована в \"{newTitle}\"\n");
                break;
            }
        }
    }
    public void UpdateTaskDescription(string title, string newDescription){
        foreach (var item in tasks)
        {
            if (item.Title == title)
            {
                item.Description = newDescription;
                Console.WriteLine($"Описание задачи \"{title}\" обновлено\n");
                break;
            }
        }
    }
    public void UpdateTaskCategory(string title, string newCategory){
        foreach (var item in tasks)
        {
            if (item.Title == title)
            {
                item.CategoryName = newCategory;
                Console.WriteLine($"Категория задачи \"{title}\" обновлена\n");
                break;
            }
        }
    }
}
