int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
for(int i = 0; i<n; i++)
{
	nums[i] = int.Parse(Console.ReadLine());
}
for(int i = n - 1; i > 1; i--)
{
	if(nums[i] == nums[i - 1]){
		Console.WriteLine(nums[i] + " " + nums[i]);
		return;
	}
}