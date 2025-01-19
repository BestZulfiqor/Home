using System;
class Hero
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
    public string[] Items;
    public Hero(string name)
    {
        System.Console.WriteLine("Создаем героя...");
        Name = name;
        Items = new string[10];
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        System.Console.WriteLine($"\nГерой получает урон ({damage})...\nЗдоровье: {Health} \n");
    }
    public void Heal(int amount)
    {
        Health += amount;
        System.Console.WriteLine($"Герой лечится ({amount})...\nЗдоровье: {Health} \n");
    }
    public void AddItem(string item)
    {
        Items[Items.Length - 1] = item;
        System.Console.Write($"Герой получает {item}... \nИнвентарь: {item}");
        foreach (var element in Items)
        {
            System.Console.Write(element + " ");
        }
    }
    public void LevelUp()
    {
        Level += 1;
        System.Console.WriteLine($"Герой получает новый уровень! \nУровень: {Level}");
    }
    public void ShowInfo()
    {
        System.Console.Write($"Имя: {Name} \nЗдоровье: {Health} \nУровень: {Level} \nИнвентарь: ");
        if (Items[0] == null)
        {
            Console.WriteLine("пусто");
        }
        else
        {
            foreach (var item in Items)
            {
            System.Console.Write(item + " ");
            }
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero("Alex");
        hero.Health = 100;
        hero.Level = 1;
        hero.ShowInfo();
        hero.AddItem("меч");
        hero.TakeDamage(25);
        hero.Heal(20);
        hero.LevelUp();
        hero.ShowInfo();
    }
}