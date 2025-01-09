double Method(int a){
	if (a > 100)
	{
		return a - a * 0.15;
	}
	else if (a < 50)
	{
		return a - a * 0.05;
	}
	else
	{
		return a - a * 0.1;
	}
}
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine(Method(n));