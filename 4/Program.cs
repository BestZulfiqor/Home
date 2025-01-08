int n = int.Parse(Console.ReadLine());
int[] nums = new int[n];
for(int i = 0; i< n; i++){
	nums[i] = int.Parse(Console.ReadLine());
}
string result = "";
for(int i = 0; i< n; i++){
	int count = 0;
	for(int j = 0; j < n; j++){
		if(nums[i] == nums[j]){
			count++;
		}
	}
	if(count == 1){
		result += nums[i] + " ";
	}
}
System.Console.WriteLine(result);