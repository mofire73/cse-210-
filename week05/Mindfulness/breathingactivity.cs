using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description)
    {
    }

    public void Run()
    {
        StartMessage();

        int duration = GetDuration();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(4);

            if ((DateTime.Now - startTime).TotalSeconds >= duration)
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountDown(4);
        }

        EndMessage();
    }
}