int MinDigit (int n){
	int min = int.MaxValue;
	for(int i = n; i > 0; i /= 10){
		if(i % 10 < min){
			min = i % 10;
		}
	}
	return min;
}
int MaxDigit (int n){
	int max = int.MinValue;	
	for(int i = n; i > 0; i /= 10){
		if(i % 10 > max){
			max = i % 10;
		}
	}
	return max;
}
int n = int.Parse(Console.ReadLine());
Console.WriteLine(MinDigit(n) + " + " + MaxDigit(n) + " = " + (MinDigit(n) + MaxDigit(n)));