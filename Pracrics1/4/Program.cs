using System;
class Actor{
	string fullName;
	int age;
	string gender;
	string[] moviesPlayed;
	public string[] AddMovie(int movies){
		int count = 0;
		moviesPlayed = new string[movies];
		for (int i = 0; i < movies; i++)
		{
			moviesPlayed[i] = Console.ReadLine();
		}
		return moviesPlayed;
	}
}
class Program
{
	static void Main(string[] args)
	{
		
	}
}