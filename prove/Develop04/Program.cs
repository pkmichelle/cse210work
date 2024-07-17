using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        int _breathCount = 0;
        int _reflectCount = 0;
        int _listCount = 0;
        bool _running = true;

        while (_running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("Choose an activity: ");

            int _choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (_choice)
            {
                case 1:
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.RunBreathing();
                    _breathCount++;
                    break;

                case 2:
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.RunReflecting();
                    _reflectCount++;
                    break;

                case 3:
                    Console.Clear();
                    ListingActivity listing = new ListingActivity();
                    listing.RunListing();
                    _listCount++;
                    break;

                case 4:
                    Console.WriteLine("Great job! You completed the following activities: ");
                    Console.WriteLine($"Breathing Activity: {_breathCount} times");
                    Console.WriteLine($"Reflecting Activity: {_reflectCount} times");
                    Console.WriteLine($"Listing Activity: {_listCount} times");
                    Console.WriteLine();
                    Console.WriteLine("Thank you. Have a nice day!");
                    _running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please choose one of the following activities.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}