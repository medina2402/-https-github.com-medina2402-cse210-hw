using System;

internal class NewBaseType
{
    static string GetName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    static int GetNumber()
    {
        Console.Write("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }
    static void Main(string[] args)
    {
        Welcome();

        string name = GetName();
        int number = GetNumber();

        Result(name, Square(number));
    }

    static void Result(string name, int square)
    {
        Console.WriteLine($"{name}, your number squared is {square}.");
    }

    static int Square(int number)
    {
        return number * number;
    }

    static void Welcome()
    {
        Console.WriteLine("Welcome!");
    }
}

class Program : NewBaseType
{
}