int n = int.Parse(Console.ReadLine());
int count = 0;
int[] nums = new int[n];
for(int i= 0; i< n;i++){
	nums[i] = int.Parse(Console.ReadLine());
}
for(int i= 1; i< n-1;i++){
	if(nums[i] > nums[i+1] && nums[i] > nums[i-1])
	{
		count++;
	}
}
System.Console.WriteLine(count);