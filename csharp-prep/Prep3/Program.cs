using System;

class Program
{
    static void Main(string[] args)
    {
        // string response = "yes";

        // a normal while loop: "while this is true, this thing will continue"
        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue?");
        //     response = Console.ReadLine();
        // }


        // a do-while loop. runs the body of loop first, then the
        // while part happens. Guaranteed that the body will run
        // at least once. 
        // do
        // {
        //     Console.Write("Do you want to continue?");
        //     response = Console.ReadLine();
        // } while (response == "yes");


        // for loop. this one counts from 0-9. '++' incremements the
        // value in the variable by one, so like '+=' in python
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // used extensively in next prep material
        // foreach (string color in colors)
        // {
        //     Console.WriteLine(color);
        // }

        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1,11);
        
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,100);

        int guess = 0;
        int numGuesses = 0;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            string response = Console.ReadLine();
            guess = int.Parse(response);

            if (guess < magicNum)
            {
                Console.WriteLine("higher");
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

            numGuesses++;
            
        }

        Console.WriteLine($"Guesses: {numGuesses}");

    }
}