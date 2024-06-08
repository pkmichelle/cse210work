public class Scripture
{
    private Reference _reference;
    private List<Word> _wordsList;
    private string[] wordArray;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _wordsList = new List<Word>();
        wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            _wordsList.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine($"{_reference.GetFormattedReference()}");

        foreach (Word word in _wordsList)
        {
            Console.Write(word.GetText() + " ");
        }

        Console.WriteLine();
    }

    public bool AllHidden()
    {
        foreach(Word word in _wordsList)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideWord(int numToHide)
    {
        Random randomNum = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numToHide)
        {
            int index = randomNum.Next(_wordsList.Count);
            Word word = _wordsList[index];

            if (!word.IsHidden())
            {
                word.Hide();
                wordsHidden++;
            }
        }
    }

    public int GetVisibleCount()
    {
        int visibleCount = 0;

        foreach (Word word in _wordsList)
        {
            if(!word.IsHidden())
            {
                visibleCount++;
            }
        }
        return visibleCount;
    }

    public void ResetWords()
    {
        foreach(Word word in _wordsList)
        {
            word.Reset();
        }
    }
}