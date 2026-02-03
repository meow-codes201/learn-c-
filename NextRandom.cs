
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Random Numbers");
        Random rn = new Random();
        int rollDdice1 = rn.Next(1,7); // Next
        Console.WriteLine(rollDdice1);
        int rollDdice2 = rn.Next(1,7); // Next
        Console.WriteLine(rollDdice2);
        int rollDdice3 = rn.Next(1,7); // Next
        Console.WriteLine(rollDdice3);
        
        double x = rn.NextDouble();
        Console.WriteLine(x);
        
        
    }
}
