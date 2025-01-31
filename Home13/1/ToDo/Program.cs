using System;
using System.Threading.Channels;
using Infrastructure;

class Program
{
    static void Main(string[] args)
    {
        Infrastructure.Task task = new Infrastructure.Task
        {
            Title = "Выучить C#",
            Description = "Изучить основы",
            CategoryName = "Учёба"
        };
        var task1 = new Infrastructure.Task();
        task1.Title = "Сделать домашку";
        task1.Description = "Решить задачи по C#";
        task1.IsCompleted = false;

        Console.WriteLine($"Задача: {task1.Title}");
        Console.WriteLine($"Описание: {task1.Description}");
        if (task1.IsCompleted)
        {
            Console.WriteLine("Статус: Выполнена");
        }
        else
        {
            Console.WriteLine("Статус: Не выполнена");
        }

        var taskList = new TaskList();
        taskList.AddTask(new Infrastructure.Task { Title = "Задача 1", Description = "Описание 1" });
        taskList.AddTask(new Infrastructure.Task { Title = "Задача 2", Description = "Описание 2" });
        taskList.ShowAllTasks();
        taskList.RemoveTask("Задача 1");
        taskList.ShowAllTasks();
        taskList.MarkAsCompleted("Задача 2");
        Console.WriteLine("Выполненные задачи:");
        foreach (var item in taskList.GetCompletedTasks())
        {
            Console.WriteLine(item.Title);
        }

        var task2 = taskList.FindByTitle("Задача 2");
        Console.WriteLine($"Найдена задача: {task2.Title}");

        var tasks = taskList.FindByDescription("Описание");
        Console.WriteLine("Задачи с описанием 'Описание':");
        foreach (var t in tasks)
        {
            Console.WriteLine(t.Title);
        }

        taskList.AddCategory("Работа", "Рабочие задачи");
        taskList.AddCategory("Дом", "Домашние дела");
        taskList.ShowCategories();

        var tasks2 = taskList.FindTasksByCategory("Работа");
        Console.WriteLine("Задачи в категории 'Работа':");
        foreach (var item in tasks)
        {
            Console.WriteLine(item.Title);
        }

        Console.WriteLine($"Всего задач: {taskList.GetTotalTasks()}");
        Console.WriteLine($"Выполнено: {taskList.GetCompletedTasksCount()}");
        Console.WriteLine($"Не выполнено: {taskList.GetUnCompletedTasks()}");
        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить задачу");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Отметить как выполненную");
            Console.WriteLine("4. Показать все задачи");
            Console.WriteLine("5. Найти задачу");
            Console.WriteLine("0. Выход");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Введите название задачи: ");
                    var title = Console.ReadLine();
                    Console.Write("Введите описание: ");
                    var description = Console.ReadLine();
                    Console.Write("Введите категорию: ");
                    var category = Console.ReadLine();
                    Infrastructure.Task newTask = new Infrastructure.Task
                    {
                        Title = title,
                        Description = description,
                        CategoryName = category
                    };
                    break;
                case "2":
                    Console.Write("Введите название задачи: ");
                    var titleToRemove = Console.ReadLine();
                    taskList.RemoveTask(titleToRemove);
                    break;
                case "3":
                    string s = Console.ReadLine();
                    taskList.MarkAsCompleted(s);
                    Console.WriteLine("Выполненные задачи:");
                    foreach (var item in taskList.GetCompletedTasks())
                    {
                        Console.WriteLine(item.Title);
                    }
                    break;
                    case "4":
                    taskList.ShowAllTasks();
                    break;
                    case "5":
                    System.Console.WriteLine("Enter title of task");
                    taskList.FindByTitle(Console.ReadLine());
                    break;
                    case "6":
                    return ;
                    break;
                default:
                    break;
            }

        }
    }
}
