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
        for (int i = 0; i < Items.Length; i++)
        {
            if (Items[0] == null)
            {
                System.Console.WriteLine("Пусто");
                break;
            }
            else if (Items[i] == null)
            {
                break;
            }
            System.Console.Write(Items[0] + " ");
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero("Alex", 10);
        while (hero.Health > 0)
        {
            System.Console.Write($"Damage: ");
            int damage = int.Parse(Console.ReadLine());
            hero.TakeDamage(damage);
            System.Console.Write("Add item: ");
            string item = Console.ReadLine();
            hero.AddItem(item);
            System.Console.Write("Heal ");
            int heal = int.Parse(Console.ReadLine());
            hero.Heal(heal);
            hero.ShowInfo();
        hero.AddItem("меч");
        hero.TakeDamage(25);
        hero.Heal(20);
        hero.LevelUp();
        hero.ShowInfo();
    }
}