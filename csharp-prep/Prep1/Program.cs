using System;

class Program
{
    static void Main(string[] args)
    {
        // Examples from prep module:
        
        // Console.WriteLine("Hello Prep1 World!");
        // int number = 5;
        // number = number +3;
        // Console.WriteLine(number);

        // Console.Write("What is you fav color?");
        // string color = Console.ReadLine();
        // Console.WriteLine($"your color is{color}");

        // int x, y;
        // x = 5;
        // y = 1;
        // Console.WriteLine(x);
        // // or 
        // // int x = 5;
        // // Console.WriteLine(x);

        // Console.Write("What is your favorite color?");
        // string color = Console.ReadLine();
        
        // if (x > y)
        // {
        //     Console.WriteLine("greater");
        // }
        // string school = "BYU-Idaho";
        // Console.WriteLine($"I am studying at {school}");

        Console.Write("What is your first name?");
        string first = Console.ReadLine();

        Console.Write("What is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
        
    }
}