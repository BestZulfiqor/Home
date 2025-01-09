string Method(int a){
	for (int i = 2; i < a; i++)
	{
		if (a % i == 0)
		{
			return "Простое число: Нет";
		}
	}
	return "Простое число: Да";
}
int a = int.Parse(Console.ReadLine());	
Console.WriteLine(Method(a));