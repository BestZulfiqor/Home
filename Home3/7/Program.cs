int Method(int a)
{
	if (a == 1)
	{
		return 1;
	}
	return a * Method(a - 1);
}
int a = int.Parse(Console.ReadLine());
Console.WriteLine(Method(a));