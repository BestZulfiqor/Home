int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
int zarb = 1;
for(int i = 0; i < n; i++)
{
	nums[i] = int.Parse(Console.ReadLine());
	zarb *= nums[i];
}
System.Console.WriteLine(zarb);
