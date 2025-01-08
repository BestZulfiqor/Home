int n = int.Parse(Console.ReadLine());
double sum = n;

if (n < 100)
{
	sum += n * 0.05;
}
else if (n <= 200)
{
	sum += n * 0.07;
}
else
{
	sum += n * 0.10;
}

Console.WriteLine(sum);