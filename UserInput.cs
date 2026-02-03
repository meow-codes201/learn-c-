
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name");
        String name = Console.ReadLine();
        Console.WriteLine("Please enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hello "+ name+"!\n"+"You are "+ age+ " years old");

    }
}
