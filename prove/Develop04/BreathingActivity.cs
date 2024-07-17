using System;
using System.Diagnostics;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void RunBreathing()
    {
        ShowStartingMessage();
        ShowBreatheCycle();
        ShowEndingMessage();
    }

    public void ShowBreatheCycle()
    {
        int _duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathing in:");
            Countdown("Now breathe in...", 1, 4);

            Console.WriteLine();
            Console.WriteLine("Breathing out:");
            Countdown("Now breathe out...", 6, 1);
        }
    }

    public void Countdown(string message, int start, int end)
    {
        int step = start < end ? 1 : -1;
        for (int i = start; i != end + step; i += step)
        {
            Console.WriteLine($"{message} {i}");
            Thread.Sleep(1000);
            if (i != end) Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}