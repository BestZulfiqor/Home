string Method(int a){
	if (a % 2 == 0)
	{
		return "Чётное";
	}
	else return "Нечётное";
}
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine(Method(n));