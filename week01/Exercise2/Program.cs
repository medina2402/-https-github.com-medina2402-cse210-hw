using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is F.");
        }
    }
}   