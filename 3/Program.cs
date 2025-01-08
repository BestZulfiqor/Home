int n = int.Parse(Console.ReadLine());
int[] nums=  new int[n];
int max = 0, maxIndex = 0;
for (int i = 0; i < n; i++)
{
	nums[i] = int.Parse(Console.ReadLine());
	if (nums[i] > max)
	{
		max = nums[i];
		maxIndex = i;
	}
}
System.Console.WriteLine(maxIndex);