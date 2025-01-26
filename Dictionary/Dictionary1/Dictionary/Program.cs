using Library;

class Program
{
	static void Main(string[] args)
	{
		Tools tools = new Tools();
		tools.CountWords("Привет мир! Привет C# мир программирование C# привет");
	}
}
// Dictionary<int, int> grades = new();
// int size = int.Parse(Console.ReadLine());
// for (int i = 0; i < size; i++)
// {
// 	int n1 = int.Parse(Console.ReadLine());
// 	int n2 = int.Parse(Console.ReadLine());
// 	grades.Add(n1, n2);
// }
// foreach (var item in grades)
// {
// 	Console.WriteLine(item.Key + " " + item.Value);
// }

// KeyValuePair<int, string> mike = new KeyValuePair<int, string>(56, "Mike");
// KeyValuePair<int, string> mike2 = new KeyValuePair<int, string>(57, "Mike2");
// var employees = new List<KeyValuePair<int, string>>() { mike, mike2 };
// var people = new Dictionary<int, string>();
// foreach (var employee in employees)
// {
// 	people.Add(employee.Key, employee.Value);
// }
// foreach (var grade in people)
// {
// 	Console.WriteLine(grade);
// }