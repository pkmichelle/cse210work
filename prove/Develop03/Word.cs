public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string text)
    {
        _word = text;
        _isHidden = false;
    }
    
    public string GetText()
    {
        if(_isHidden)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Reset()
    {
        _isHidden = false;
    }
}