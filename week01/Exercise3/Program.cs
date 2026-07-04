using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello this is a Magic Number Game.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guess = 0;

        while (guess != number)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                break;
            }
            else if (guess < number)
            {
                Console.WriteLine("Too low.");
            }
            else if (guess > number)
            {
                Console.WriteLine("Too high.");
            }
            
        }

    }
}