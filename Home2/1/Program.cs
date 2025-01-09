int n = int.Parse(Console.ReadLine());	
int juft = 0, toq = 0, digit = 0, sum = 0;
for(int i = n; i > 0; i /= 10)
{
	digit++;
	sum += digit;
	if(digit % 2 == 0)
		juft++;
	else
		toq++;
}
System.Console.WriteLine($"Even:{juft}");
System.Console.WriteLine($"Odd:{toq}");
System.Console.WriteLine($"Digit:{digit}");
System.Console.WriteLine($"Sum:{sum}");