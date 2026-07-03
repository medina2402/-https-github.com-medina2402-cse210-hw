using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("first i need your first name.");
        string firstname = Console.ReadLine();
        Console.WriteLine($"Hello, {firstname}!");
        Console.WriteLine("now i need your last name.");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}!");

    }
}