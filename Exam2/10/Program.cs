using System;
class Hero
{
    public string Name { get; set; }
    public int Health = 100;
    public int Level { get; set; }
    public string[] Items;
    int increment = 0;
    public Hero(string name, int amount, int health = 100)
    {
        System.Console.WriteLine("Создаем героя...");
        Name = name;
        Items = new string[amount];
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
        Items[increment] = item;
        increment++;
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
            System.Console.Write("Enter command: ");
            string s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    hero.ShowInfo();
                    break;
                case "2":
                    System.Console.Write("Enter damage: ");
                    int damage = int.Parse(Console.ReadLine());
                    hero.TakeDamage(damage);
                    break;
                case "3":
                    System.Console.Write("Healing: ");
                    int heal = int.Parse(Console.ReadLine());
                    hero.Heal(heal);
                    break;
                case "4":
                    System.Console.Write("Level up");
                    hero.LevelUp();
                    break;
                default:
                    break;
            }
        System.Console.WriteLine("Hero is die!");
        }
    }
}