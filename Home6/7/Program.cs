using System;

class Program
{
    static int Method(int x, int rev = 2)
    {
        if (x % rev == 0)
        {
            return rev;
        }
        return Method(x, rev+=1);
    }
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        System.Console.WriteLine(Method(x));
    }
}