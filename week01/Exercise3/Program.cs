using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Magic Number Game!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Too low.");
            }
            else
            {
                Console.WriteLine("Too high.");
            }
        }
    }
}