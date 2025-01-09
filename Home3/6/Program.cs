int Method(int a)
{
	int sum = 0;
	for (int i = 0; i <= a; i++)
	{
		if (i % 2 == 0)
		{
			sum += i;
		}
	}
	return sum;
}
int a = int.Parse(Console.ReadLine());
Console.WriteLine(Method(a));