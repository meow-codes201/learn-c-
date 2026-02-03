
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //variables
        int x; // declaration
        x = 1234;//initialization
        double a = 9.9; // declaration + initialization
        char ch = '*';
        String word = "Greetings"; 
        bool isCoding = false;
        //Constant
        const double PI = 3.14159;
        // PI = 3.141; 🚫

        Console.WriteLine(x);
        Console.WriteLine(a);
        Console.WriteLine(ch);
        Console.WriteLine(word);
        Console.WriteLine(!isCoding);
        Console.WriteLine(PI);
        
    }
}
