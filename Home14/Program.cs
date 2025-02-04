using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(Math.Pow(5, 2));
        System.Console.WriteLine(Math.Abs(-5));
        System.Console.WriteLine(Math.Sqrt(25));
        System.Console.WriteLine(Math.Min(5, 2));
        System.Console.WriteLine(Math.Pi);
        System.Console.WriteLine(Math.Max(5, 10));
        System.Console.WriteLine(Math.Sqrt(25));
        System.Console.WriteLine(Math.Ceiling(-2.09));
        System.Console.WriteLine(Math.Sum(1, 2, 3, 4.5, 52.6));
        System.Console.WriteLine(Math.Round(-25.5));
        System.Console.WriteLine(Math.Multiply(25,21,2));
    }
}
static class Math
{
    public static double Sum(params double[] nums)
    {
        double sum = 0;
        foreach (var item in nums)
        {
            sum += item;
        }
        return sum;
    }
    public static double Multiply(params double[] nums)
    {
        double multiply = 1;
        foreach (var item in nums)
        {
            multiply *= item;
        }
        return multiply;
    }
    public static int Round(double x)
    {
        int a = (int)x;

        if (x >= 0)
        {
            if (x - a >= 0.5) return a + 1;
        }
        else
        {
            if (x - a <= -0.5) return a - 1;
        }

        return a;
    }

    public static int Ceiling(double x)
    {
        int a = (int)x;
        if (x > 0 && x != a)
        {
            return a + 1;
        }
        return a;
    }
    public static double Pi = 3.14;
    public static double Pow(double x, double y)
    {
        double p = 1;
        for (var i = 0; i < y; i++)
        {
            p *= x;
        }
        return p;
    }
    public static double Sqrt(double x)
    {
        return System.Math.Sqrt(x);
    }
    public static double Abs(double x)
    {
        if (x < 0)
        {
            x *= -1;
        }
        return x;
    }
    public static double Min(double x, double y)
    {
        return x < y ? x : y;
    }
    public static double Max(double x, double y)
    {
        return x > y ? x : y;
    }
}