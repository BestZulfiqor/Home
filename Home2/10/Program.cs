int Max(int val1, int val2){
	return Math.Max(val1, val2);
}
string[] s = Console.ReadLine().Split();
int a = int.Parse(s[0]);
int b = int.Parse(s[1]);
System.Console.WriteLine(Max(a, b));