int Method(int a, int b, int c){
	return Math.Max(a, Math.Max(b, c));
}
string[] s = Console.ReadLine().Split();
int a = int.Parse(s[0]);
int b = int.Parse(s[1]);
int c = int.Parse(s[2]);
System.Console.WriteLine("Максимальное число: " + Method(a, b, c));