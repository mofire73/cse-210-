using System;

public class ListingActivity : Activity
{
    private string[] _prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description)
        : base(name, description)
    {
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Length)];

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine();

        int count = 0;
        DateTime startTime = DateTime.Now;
        int duration = GetDuration();

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(answer))
            {
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items.");

        EndMessage();
    }
}