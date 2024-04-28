using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // if (x>y)
        // {
        //     Console.WriteLine("greater than");
        // else if (x>z)
        // {
        //     Console.WriteLine("greater than z");
        // }
        // else
        // {
        //     Console.WriteLine("less than both");
        // }
        // }
        
    // if (name == "John")
    // {
    //     Console.WriteLine("The name is John");
    // }
    // if (name != "Color")
    // {
    //     Console.WriteLine("That's not my fav");
    // }
    // if (name == "Peter" || name== "James" || name== "John")
    // {
    //     Console.WriteLine("this is a biblical name.");
    // }
    // if (name == "Brigham" && name== "Young")
    // {
    //     Console.WriteLine("Welcome bro Brigham");
    // }
    // if (!(name == "Peter" || name== "James" || name== "John"))
    // {
    //     Console.WriteLine("this is a biblical name.");
    // }
    // string valueInText = "42";
    // int number = int.Parse(valueInText);

    //

        Console.Write("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);

        string letter = "";

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else if (gradePercent < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade: {letter}");
        
        
        if (gradePercent >= 70)
        {
            Console.WriteLine("You've passed. Great job!");
        }
        else
        {
            Console.WriteLine("You'll get it next time! You did not pass the class.");
        }

    }
}