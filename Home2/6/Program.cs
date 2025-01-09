 string Divisors(int x){
	string s = "";
	for(int i = 1; i <= x; i++){
		if(x % i == 0){
			s += i + " ";
		}
	}
	return s;
 }
 int a = int.Parse(Console.ReadLine());
 System.Console.WriteLine(Divisors(a));