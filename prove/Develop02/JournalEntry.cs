using System;

public class JournalEntry
{
    public string _prompt;
    public string _response;
    public string _date;
    public string _rating;

    public void GetPrompt()
    {
        var random = new Random();
        var _promptsList = new List<string>{
            "Who was the most interesting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "What was the strongest emotion I felt today? ",
            "If I had one thing I could do over today, what would it be? ",
            "What is one significant realization that I've had today? ",
        };
        int index = random.Next(_promptsList.Count);
        _prompt = _promptsList[index];

        Console.WriteLine(_prompt);
    }

    public void GetResponse()
    {
        Console.Write("> ");
        _response = Console.ReadLine();
    }

    // public void SetEntry(string response, string prompt, string date)
    // {
    //     _response = response;
    //     _prompt = prompt;
    //     _date = date;
    // }

    public void GetDate()
    {
        DateTime today = DateTime.Now;
        _date = today.ToShortDateString();
    }

    public void GetRating()
    {
        Console.Write("On a scale of 1-10, how was your day? ");
        _rating = Console.ReadLine();

        int _numRating = int.Parse(_rating);
        string _description = "";

        if (_numRating == 1 || _numRating == 2)
        {
            _description = "Seems like you had a pretty bad day :(\n";
        }
        if (_numRating == 3 || _numRating == 4)
        {
            _description = "Not the best day huh? but not terrible! :/\n";
        }
        if (_numRating == 5 || _numRating == 6)
        {
            _description = "You had good day!\n";
        }
        if (_numRating == 7 || _numRating == 8)
        {
            _description = "You had a very good day!! Yay!\n";
        }
        if (_numRating == 9 || _numRating == 10)
        {
            _description = "Sounds like you had a super awesome day!! Let's go!\n";
        }

        Console.WriteLine(_description);

    }

    


    // public void DisplayFormat()
    // {
    //     _date = GetDate();
    //     _prompt = GetPrompt();
    //     _response = GetResponse();
    //     Console.WriteLine($"Date: {_date} — Prompt: {_prompt} \n{_response}");
    // }

    
}
