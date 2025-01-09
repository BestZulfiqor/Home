void Method(int a , int b)
{
	System.Console.Write("Сумма: " + (a + b));
	System.Console.Write(", Разность: " + (a - b));
	System.Console.Write(", Произведение: " + (a * b));
}
string[] s = Console.ReadLine().Split();
int a = int.Parse(s[0]);
int b = int.Parse(s[1]);
Method(a, b);