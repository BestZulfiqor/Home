void Swap(ref int a, ref int b){
	int temp = a;
	a = b;
	b = temp;
}
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Swap(ref a, ref b);
System.Console.WriteLine($"x = {a}\ny = {b}");