int[] IncrementArrayElements(int[] arr, int increment)
{
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] += increment;
	}
	return arr;
}
int[] arr = new int[]{1, 2, 3};
IncrementArrayElements(arr, 5);
Console.WriteLine(string.Join(", ", arr)); 