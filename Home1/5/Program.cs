int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
int min = int.MaxValue, minIndex = 0;
for(int i = 0; i < n; i++)
{
	nums[i] = int.Parse(Console.ReadLine());
	if(nums[i] < min)
	{
		min = nums[i];
		minIndex = i;
	}
}
System.Console.WriteLine(minIndex);