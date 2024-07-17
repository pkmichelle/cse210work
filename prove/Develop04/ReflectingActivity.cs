using System;
using System.Threading;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base()
    {
        SetName("Reflection Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other apects of your life.");

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experiene meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void RunReflecting()
    {
        ShowStartingMessage();
        ShowPrompt();
        ShowCountdown(3);
        ShowQuestions();
        ShowEndingMessage();
    }
        
    public void ShowPrompt()
    {
        Console.WriteLine("Consider the following: ");
        Console.WriteLine();

        int _randIndex = new Random().Next(0,_prompts.Count);
        Console.WriteLine(_prompts[_randIndex]);
        Console.WriteLine();

        Console.WriteLine("When you feel ready, press enter to continue.");
        Console.ReadLine();    
    }

    public void ShowQuestions()
    {
        int _duration = GetDuration();
        List<string> _selectedQuestions = new List<string>();
        Random rand = new Random();

        while (_selectedQuestions.Count < 3)
        {
            string _question = _questions[rand.Next(_questions.Count)];
            if (!_selectedQuestions.Contains(_question))
            {
                _selectedQuestions.Add(_question);
            }
        }

        foreach (string question in _selectedQuestions)
        {
            Console.WriteLine($"---{question}---");
            ShowSpinner(_duration);
            Console.WriteLine();
        }
        
        ShowSpinner(5);
    }

    private void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
