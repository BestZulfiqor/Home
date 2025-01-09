int Method(int[] arr){
	int sum = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		sum += arr[i];
	}
	return sum / arr.Length;
}
int a = int.Parse(Console.ReadLine());
string[] s = Console.ReadLine().Split();
int[] arr = new int[s.Length];
for (int i = 0; i < s.Length; i++)
{
	arr[i] = int.Parse(s[i]);
}
System.Console.WriteLine(Method(arr));