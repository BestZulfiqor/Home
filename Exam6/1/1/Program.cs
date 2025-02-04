using System;
using System.Collections.Generic;
using System.Linq;

class IceCream
{
    public string Flavor { get; set; }
    public int Value { get; set; }

    private static Dictionary<string, int> SweetnessValues = new Dictionary<string, int>();

    public IceCream(string flavor, int value)
    {
        Flavor = flavor;
        Value = value;
    }
}

class Program
{
    static void SweetestIceCream(List<IceCream> iceCreams)
    {
        int max = 0;
        string n = "";
        foreach (var item in iceCreams)
        {
            if (max < item.Value)
            {
                max = item.Value;
                n = item.Flavor;
            }
        }
        System.Console.WriteLine("Name : " + n + " Value : " + max);
    }

    static void Main()
    {
        var ice1 = new IceCream("Chocolate", 12);
        var ice2 = new IceCream("Vanilla", 0);
        var ice3 = new IceCream("Strawberry", 15);
        var ice4 = new IceCream("Plain", 2);
        var ice5 = new IceCream("ChocolateChip", 8);

        SweetestIceCream(new List<IceCream> { ice1, ice2, ice3, ice4, ice5 });
    }
}
