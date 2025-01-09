int Add(int a, int b)
{
	return a + b;
}
int Subtract(int a, int b)
{
	return a - b;
}
int Multiply(int a, int b)
{
	return a * b;
}
int Division(int a, int b)
{
	return a / b;
}
string[] s = Console.ReadLine().Split();
int a = int.Parse(s[0]);
int b = int.Parse(s[1]);
System.Console.WriteLine("Add:" + Add(a, b));
System.Console.WriteLine("Substract:" + Subtract(a, b));
System.Console.WriteLine("Multiply:" + Multiply(a, b));
System.Console.WriteLine("Division:" + Division(a, b));