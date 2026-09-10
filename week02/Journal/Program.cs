
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.WriteLine($"Hello {name}! Welcome to your Journal.");

        Journal journal = new Journal();

        string[] prompts =
        {
            "What was the best part of your day?",
            "What are you grateful for today?",
            "What did you learn today?",
            "What was something challenging today?"
        };

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();

                Random random = new Random();
                int index = random.Next(prompts.Length);

                entry._prompt = prompts[index];

                Console.WriteLine(entry._prompt);

                Console.Write("Write your answer: ");
                entry._response = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter a filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
