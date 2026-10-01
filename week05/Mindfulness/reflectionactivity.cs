using System;

public class ReflectionActivity : Activity
{
    private string[] _prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description)
        : base(name, description)
    {
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Length)];

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        int duration = GetDuration();

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string question = _questions[random.Next(_questions.Length)];

            Console.WriteLine();
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        EndMessage();
    }
}