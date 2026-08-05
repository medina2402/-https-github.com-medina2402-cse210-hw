using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths you have?",
        "Who are people that have helped you in your life?",
        "What are things you are grateful for?",
        "What are good things you have done?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");

        string prompt = _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        Console.WriteLine();

        List<string> answers = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();

            if (!string.IsNullOrEmpty(answer))
            {
                answers.Add(answer);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {answers.Count} items!");

        DisplayEndingMessage();
    }
}