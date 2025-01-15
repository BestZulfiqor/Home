using System;

class Program
{
    static void Method(int a, int b)
    {
        if (b < a)
        {
            return;
        }
        int sqrt = (int)Math.Sqrt(b);
        if (sqrt * sqrt == b)
        {
            Console.Write(b + " ");
        }
        Method(a, b - 1);
    }

    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Method(a, b);
    }
}