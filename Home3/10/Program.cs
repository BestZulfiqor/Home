string Method(int n)
{
	string s = "";
	int temp1 = 0;
	int temp2 = 1;
	int temp3 = 1;
	for (int i = 0; i < n-1; i++)
	{
		s += temp1 + ", ";
		temp1 = temp2;
		temp2 = temp3;
		temp3 = temp1 + temp2;
	}
	s += temp1;
	return s;
}
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine(Method(n));