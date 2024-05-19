using System;
using System.IO;

public class Journal
{
    public List<JournalEntry> _entryList = new List<JournalEntry>();



    public void Add()
    {
        JournalEntry _newEntry = new JournalEntry();
        _newEntry.GetDate();
        _newEntry.GetPrompt();
        _newEntry.GetResponse();
        _newEntry.GetRating();

        _entryList.Add(_newEntry);

        // string _date = _newEntry.GetDate();
        // string _prompt = _newEntry.GetPrompt();
        // Console.WriteLine($"Prompt: {_prompt}");
        
        // string _response = _newEntry.GetResponse();

        // _newEntry.SetEntry(_prompt,_response,_date);
        // _entryList.Add(_newEntry);
    }

    public void Display()
    {
        foreach (JournalEntry entry in _entryList)
        {
            Console.WriteLine($"Date: {entry._date}\n"+
                                $"Day Rating: {entry._rating}\n"+
                                $"Prompt: {entry._prompt}\n"+
                                $"Response: {entry._response} \n"
                                );
            
        }
    }

    public void LoadFile()
    {
        Console.Write("What is the name of the file you want to load? ");
        string _fileName = Console.ReadLine();
        Console.WriteLine("");

        using (StreamReader reader = new StreamReader(_fileName))
        {
            while(reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }
    }

    public void SaveFile()
    {
        Console.Write("What is the name of the file you want to save? ");
        string _fileName = Console.ReadLine();
        Console.WriteLine();

        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            foreach (JournalEntry entry in _entryList)
            {
                writer.WriteLine($"Date: {entry._date} \n"+
                                $"Day Rating: {entry._rating}\n"+
                                $"Prompt: {entry._prompt} \n"+
                                $"Response: {entry._response}\n"
                                );
            }
        }
    }
}
