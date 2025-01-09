 int MinNumber(int a, int b, int c, int d){
	int min = Math.Min(a,Math.Min(b,Math.Min(c,d)));
	return	min;
 }
 string[] s = Console.ReadLine().Split();
 int a = int.Parse(s[0]);
 int b = int.Parse(s[1]);
 int c = int.Parse(s[2]);
 int d = int.Parse(s[3]);
 System.Console.WriteLine(MinNumber(a, b, c, d));