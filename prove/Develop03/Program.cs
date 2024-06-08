using System;
using System.ComponentModel.Design;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Scripture[] scriptArray = new Scripture[4];

        scriptArray[0] = new Scripture(new Reference("John", 14, 27), "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.");

        scriptArray[1] = new Scripture(new Reference("Alma", 37, 37), "37 Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord,"+
                                                                            "that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things,"+
                                                                            "ye shall be lifted up at the last day.");

        scriptArray[2] = new Scripture(new Reference("Alma", 37, 36, 37), "36 Yea, and cry unto God for all thy support; yea, let all thy doings be unto the Lord, and whithersoever thou goest let it be in the Lord; yea,"+
                                                                                "let all thy thoughts be directed unto the Lord; yea, let the affections of thy heart be placed upon the Lord forever.\n"+
                                                                                "37 Counsel with the Lord in all thy doings, and he will direct thee for good; yea, when thou liest down at night lie down unto the Lord,"+
                                                                                "that he may watch over you in your sleep; and when thou risest in the morning let thy heart be full of thanks unto God; and if ye do these things,"+
                                                                                "ye shall be lifted up at the last day.");
  
        scriptArray[3] = new Scripture(new Reference("Moroni", 7, 45), "45 And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil,"+ 
                                                                                "and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things.");

        string selection = "";
        Random random = new Random();

        Scripture randScripture = scriptArray[random.Next(0, scriptArray.Length)];
        randScripture.ResetWords();

        randScripture.Display();
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish");

        while (true)
        {
            selection = Console.ReadLine();
            if (selection.ToLower() == "quit")
            { 
                break;
            }   
        
            int visibleWords = randScripture.GetVisibleCount();
            if (visibleWords >= 3)
            {
                randScripture.HideWord(3);
            }
            else if (visibleWords == 2)
            {
                randScripture.HideWord(2);
            }
            else if (visibleWords == 1)
            {
                randScripture.HideWord(1);
            }

            Console.Clear(); // Clear the console before updating the display
            randScripture.Display(); // Update display with hidden words
            Console.WriteLine(); // New blank line
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            
            if (randScripture.AllHidden())
                {
                    break;
                }
        }
    }
}

// Showing Creativity and Exceeding Requirements
// 
// Instead of using a library of scriptures, I created a small array of scriptures
// and chose randomly from it to present it to the user.
// 
// I made sure that the underscores of the hidden word match the character length
// of each word.
// 
// I added conditions for the amount of words hiding for each "enter" based on the 
// amount of still visible words to ensure that all words are able to be hidden by 
// the end. So when there are more than 3 visible words left, 3 words are hidden at
// a time. When there are only 2 visible words left, 2 words are hidden to finish
// hiding it. Then when there is 1 visible word left, 1 word is hidden.
//
// I made sure to accomodate for both one and two verse scriptures by using Alma 37
// for both. One using just verse 37 and the other using 36 and 37.