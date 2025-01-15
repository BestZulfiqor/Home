using System;

class Program
{
    static int Method(int x, int rev = 1, int count = 0)
    {
		if (x < rev)
		{
			return count;
		}
        if (x % rev == 0)
        {
            count++;
        }
        return Method(x, rev+=1,count);
    }
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        System.Console.WriteLine(Method(x));
    }
}