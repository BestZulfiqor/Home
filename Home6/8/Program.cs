using System;

class Program
{
    static void Method(int x, int rev = 1)
    {
		if (x < rev)
		{
			return;
		}
        if (x % rev == 0)
        {
            System.Console.Write(rev + " ");
        }
        Method(x, rev+=1);
    }
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        Method(x);
    }
}