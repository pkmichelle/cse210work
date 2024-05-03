using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int sqauredNumber = SqaureNumber(userNumber);

        DisplayResult(userName, sqauredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        return number;
    }

    static int SqaureNumber(int number)
    {
        int sqaured = number * number;
        return sqaured;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the sqaure of your number is {squared}");
    }
}