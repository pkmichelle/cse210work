using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(): base()
    {
        SetName("listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void RunListing()
    {
        ShowStartingMessage();
        ShowPrompt();
        ShowCountdown(3);
        ListingItems();
        ShowEndingMessage();
    }
    
    private void ShowPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine();

        int _randIndex = new Random().Next(0,_prompts.Count());
        Console.WriteLine(_prompts[_randIndex]);
        Console.WriteLine();
    }

    public void ListingItems()
    {
        List<string> items = new List<string>();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        Console.WriteLine("Start listing items: ");
        while (DateTime.Now < endTime)
        {
            string _item = Console.ReadLine();
            if(!string.IsNullOrEmpty(_item))
            {
                items.Add(_item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");
    }
}