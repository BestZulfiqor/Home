using System;

class Program
{
    static void Main(string[] args)
    {
        // for (var i = 1; i < 6; i++)
        // {
        //     for (var j = 0; j < i; j++)
        //     {
        //         System.Console.Write(i + " ");
        //     }
        //     System.Console.WriteLine();
        // }
        // for (var i = 6; i < 10; i++)
        // {
        //     for (var j = i; j < 10; j++)
        //     {
        //         System.Console.Write(i + " ");
        //     }
        //     System.Console.WriteLine();
        // }

        IceCream iceCream1 = new IceCream("Plain", 0);
        IceCream iceCream2 = new IceCream("Vanilla", 5);
        IceCream iceCream3 = new IceCream("Chokolate", 5);
        IceCream iceCream4 = new IceCream("Strawberry", 10);
        IceCream iceCream5 = new IceCream("Chocolate", 10);
        
        List<IceCream> iceCreams = new List<IceCream>();
        iceCreams.Add(iceCream1);
        iceCreams.Add(iceCream2);
        iceCreams.Add(iceCream3);
        iceCreams.Add(iceCream4);
        iceCreams.Add(iceCream5);
        

    }
    static IceCream Sweetest_icecream(List<IceCream> iceCream)
    {
        int max = 0;
        string name = "";
        for (var i = 0; i < iceCream.Count; i++)
        {
            if (iceCream[i] )
            {
                
            }
        }
        IceCream iceCream1 = new IceCream(name,max);
        return iceCream1;
    }
}
public class IceCream
{
    Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
    public IceCream(string Name, int SweetnessValue)
    {
        keyValuePairs[Name] = SweetnessValue;
    }
    
}