using System;

class Program
{
    static void Main(string[] args)
    {
        // List<int> numbers;
        // numbers = new List<int>();
        // Usually in one line:

        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();

        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // // To get the size of the list (number of items)
        // // how to print the list
        // Console.WriteLine(words.Count);
        // words.ForEach(Console.WriteLine);

        // // easiest way to iterate through list:
        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }
        // //accessing items by index:
        // for (int i=0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }

        List<int> numbers = new List<int>();

        Console.Write("Enter a list of numbers, type 0 when finished.\n");
        int numEntered = -1;
        while (numEntered != 0)
        {
            Console.Write("Enter Number: ");
            string response = Console.ReadLine();
            numEntered = int.Parse(response);
            
            numbers.Add(numEntered);
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count; 

        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}