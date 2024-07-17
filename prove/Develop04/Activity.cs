using System;
using System.Threading;

public abstract class Activity
{
    private int _duration;
    private string _activityName;
    private string _description;

    public void SetName(string name)
    {
        _activityName = name;
    }

    public void SetDescription(string desc)
    {
        _description = desc;
    }

    public void ShowDescription()
    {
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void ShowStartingMessage()
    {
        Console.WriteLine($"Starting {_activityName}...");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void ShowEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed the {_activityName} for {_duration} seconds.");
        Thread.Sleep(2000);
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowCountdown(int seconds)
    {
        Console.WriteLine();

        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"You may begin in: {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            foreach (var s in spinner)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(s);
                Thread.Sleep(250);
            }
        }
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(" "); // Clear the spinner character
        Console.SetCursorPosition(0, Console.CursorTop);
    }
} 